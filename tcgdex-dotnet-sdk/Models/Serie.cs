using Microsoft.Maui.Graphics;
using Net.Tcgdex.Sdk.Internal;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Net.Tcgdex.Sdk.Models
{
    /// <summary>
    /// Serie containing sets
    /// </summary>
    public class Serie : Model
    {
        /// <summary>
        /// The Serie sets
        /// </summary>
        public List<SetResume> Sets { get; set; }
        /// <summary>
        /// The Serie unique ID
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// The Serie name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The Serie Logo
        /// </summary>
        public string Logo { get; set; }

        /// <summary>
        /// Get the logo full URL
        /// </summary>
        /// <param name="extension">Requested extension</param>
        /// <returns>Requested URL</returns>
        public string GetLogoUrl(Extension extension) => Logo is null ? null : $"{Logo}.{extension}";

        /// <summary>
        /// Get the logo as an image
        /// </summary>
        /// <param name="format">Logo extension</param>
        /// <returns>Logo image</returns>
        public async Task<IImage> GetLogoAsync(Extension format)
        {
            string logoUrl = GetLogoUrl(format);
            return logoUrl is null ? null : await Utils.DownloadImageAsync(logoUrl);
        }
    }
}
