using Microsoft.Maui.Graphics;
using Net.Tcgdex.Sdk.Internal;
using Net.Tcgdex.Sdk.Models.Subs;
using System.Threading.Tasks;

namespace Net.Tcgdex.Sdk.Models
{
    /// <summary>
    /// Set resume model
    /// </summary>
    public class SetResume : Model
    {
        /// <summary>
        /// Globally unique set ID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The Set name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The Set Logo incomplete URL (use GetLogoUrl/GetLogo)
        /// </summary>
        public string Logo { get; set; }

        /// <summary>
        /// The Set Symbol incomplete URL (use GetSymbolUrl/GetSymbol)
        /// </summary>
        public string Symbol { get; set; }

        /// <summary>
        /// The number of cards in the set
        /// </summary>
        public SetCardCountResume CardCount { get; set; }

        /// <summary>
        /// Get logo URL
        /// </summary>
        public string GetLogoUrl(Extension extension)
        {
            return Logo is null ? null : $"{Logo}.{extension.ToString().ToLowerInvariant()}";
        }

        /// <summary>
        /// Get logo as an image
        /// </summary>
        public async Task<IImage> GetLogo(Extension extension)
        {
            string logoUrl = GetLogoUrl(extension);
            return logoUrl is null ? null : await Utils.DownloadImageAsync(logoUrl);
        }

        /// <summary>
        /// Get symbol URL
        /// </summary>
        public string GetSymbolUrl(Extension extension)
        {
            return Symbol is null ? null : $"{Symbol}.{extension.ToString().ToLowerInvariant()}";
        }

        /// <summary>
        /// Get symbol as an image
        /// </summary>
        public async Task<IImage> GetSymbol(Extension extension)
        {
            string symbolUrl = GetSymbolUrl(extension);
            return symbolUrl is null ? null : await Utils.DownloadImageAsync(symbolUrl);
        }

        /// <summary>
        /// Get the full set if available
        /// </summary>
        public Task<Set> GetFullSet()
        {
            return TcgDex.FetchSet(Id);
        }
    }
}
