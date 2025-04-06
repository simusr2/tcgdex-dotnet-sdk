

using Microsoft.Maui.Graphics;
using Net.Tcgdex.Sdk.Internal;
using System.Threading.Tasks;

namespace Net.Tcgdex.Sdk.Models
{
    /// <summary>
    /// Resume of a Serie
    /// </summary>
    public class SerieResume : Model
    {
        /// <summary>
        /// The Serie unique ID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The Serie name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The Serie Logo (basically also the first set logo)
        /// </summary>
        public string Logo { get; set; }

        /// <summary>
        /// Get the logo full URL
        /// </summary>
        public string GetLogoUrl(Extension extension)
        {
            return Logo is null ? null : $"{Logo}.{extension}";
        }

        /// <summary>
        /// Get the logo as an image
        /// </summary>
        public async Task<IImage> GetLogo(Extension format)
        {
            string logoUrl = GetLogoUrl(format);
            return logoUrl is null ? null : await Utils.DownloadImageAsync(logoUrl);
        }

        /// <summary>
        /// Get the full Serie if available
        /// </summary>
        public Task<Serie> GetFullSerie()
        {
            return TcgDex.FetchSerie(Id);
        }
    }
}
