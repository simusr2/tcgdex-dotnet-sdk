using Microsoft.Maui.Graphics;
using System.Threading.Tasks;

namespace Net.Tcgdex.Sdk.Models
{
    /// <summary>
    /// Model for a card resume
    /// </summary>
    public class CardResume
    {
        // Globally unique card ID based on the set ID and the card's ID within the set
        public string Id { get; set; }

        // ID indexing this card within its set, usually just its number
        public string LocalId { get; set; }

        // Card name
        public string Name { get; set; }

        // Card image URL without the extension and quality
        public string Image { get; set; }

        // Get the Card Image full URL
        public string GetImageUrl(Quality quality, Extension extension)
        {
            return $"{this.Image}/{quality.ToString().ToLower()}.{extension.ToString().ToLower()}";
        }

        // Get image buffer
        public async Task<IImage> GetImage(Quality quality, Extension format)
        {
            return await Utils.DownloadImageAsync(GetImageUrl(quality, format));
        }

        // Get the full card details (returns a Card object)
        public async Task<Card> GetFullCard(TCGdexClient tcgdex)
        {
            return await tcgdex.FetchCard(this.Id);
        }
    }
}
