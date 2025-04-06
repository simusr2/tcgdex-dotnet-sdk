using Microsoft.Maui.Graphics;
using Net.Tcgdex.Sdk.Internal;
using Net.Tcgdex.Sdk.Models.Subs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Net.Tcgdex.Sdk.Models
{
    /// <summary>
    /// Set model
    /// </summary>
    public class Set : Model
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
        /// The series this set is a part of
        /// </summary>
        public SerieResume Serie { get; set; }

        /// <summary>
        /// The TCG Online Code
        /// </summary>
        public string TcgOnline { get; set; }

        /// <summary>
        /// The Set release date as yyyy-mm-dd
        /// </summary>
        public string ReleaseDate { get; set; }

        /// <summary>
        /// The set legality (won't indicate if a card is banned)
        /// </summary>
        public Legal Legal { get; set; }

        /// <summary>
        /// The number of cards in the set
        /// </summary>
        public SetCardCount CardCount { get; set; }

        /// <summary>
        /// The cards contained in this set
        /// </summary>
        public List<CardResume> Cards { get; set; }

        /// <summary>
        /// Get logo URL
        /// </summary>
        public string GetLogoUrl(Extension extension)
        {
            return Logo is null ? null : $"{Logo}.{extension}";
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
            return Symbol is null ? null : $"{Symbol}.{extension}";
        }

        /// <summary>
        /// Get symbol as an image
        /// </summary>
        public async Task<IImage> GetSymbol(Extension extension)
        {
            string symbolUrl = GetSymbolUrl(extension);
            return symbolUrl is null ? null : await Utils.DownloadImageAsync(symbolUrl);
        }
    }
}
