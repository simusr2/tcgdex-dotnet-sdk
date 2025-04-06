using Microsoft.Maui.Graphics;
using Microsoft.Maui.Graphics.Skia;
using Net.Tcgdex.Sdk.Internal;
using Net.Tcgdex.Sdk.Models;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Net.Tcgdex.Sdk
{
    /// <summary>
    /// Utility class for the TCGdex API
    /// </summary>
    public static class Utils
    {
        /// <summary>
        /// The time to live for the cache in minutes
        /// </summary>
        public static long Ttl { get; set; } = 60; // Request Time to Live in minutes used for the cache expiration

        /// <summary>
        /// Cache for the API responses
        /// </summary>
        private static readonly Dictionary<string, CacheEntry> Cache = new Dictionary<string, CacheEntry>();

        /// <summary>
        /// The JsonSerializerOptions to use for deserialization
        /// </summary>
        private static readonly JsonSerializerOptions JsonSettings = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        /// <summary>
        /// Fetch from the API
        /// </summary>
        /// <param name="tcgdex">The TCGdex instance to link with it</param>
        /// <param name="url">The URL to fetch from</param>
        /// <param name="cls">The Class to build the response into</param>
        /// <returns>An initialized cls or null</returns>
        public static async Task<T> Fetch<T>(TCGdexClient tcgdex, string url)
        {
            if (Cache.TryGetValue(url, out CacheEntry value) && value.Time > DateTime.Now.AddMinutes(-Ttl))
            {
                T model = JsonSerializer.Deserialize<T>(value.Value, JsonSettings);
                if (model != null)
                {
                    return model;
                }
            }

            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    HttpResponseMessage response = await httpClient.GetAsync(url);

                    if (response.StatusCode == HttpStatusCode.NotFound)
                    {
                        return default;
                    }

                    response.EnsureSuccessStatusCode();

                    string content = await response.Content.ReadAsStringAsync();

                    CacheEntry cacheEntry = new CacheEntry(content);
                    Cache[url] = cacheEntry;

                    T model = JsonSerializer.Deserialize<T>(content, JsonSettings);
                    if (model is Model modelObject)
                    {
                        modelObject.TcgDex = tcgdex;
                    }

                    return model;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Download an image from the internet
        /// </summary>
        /// <param name="path">The URL to the image</param>
        /// <returns>The downloaded image buffer</returns>
        public static async Task<IImage> DownloadImageAsync(string url)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                byte[] imageBytes = await httpClient.GetByteArrayAsync(url);

                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    SKBitmap skiaBitmap = SKBitmap.Decode(ms);

                    return skiaBitmap != null ? new SkiaImage(skiaBitmap) : null;
                }
            }
        }
    }
}
