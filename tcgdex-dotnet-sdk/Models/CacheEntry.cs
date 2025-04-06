using System;

namespace Net.Tcgdex.Sdk.Models
{
    /// <summary>
    /// CacheEntry class to store the cache data
    /// </summary>
    public class CacheEntry
    {
        /// <summary>
        /// The value of the cache entry
        /// </summary>
        public string Value { get; }

        /// <summary>
        /// The time of the cache entry
        /// </summary>
        public DateTime Time { get; }

        /// <summary>
        /// CacheEntry constructor
        /// </summary>
        /// <param name="value">Value of the entry</param>
        public CacheEntry(string value)
        {
            Value = value;
            Time = DateTime.Now;
        }
    }
}
