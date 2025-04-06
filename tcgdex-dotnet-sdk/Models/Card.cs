using Microsoft.Maui.Graphics;
using Net.Tcgdex.Sdk.Internal;
using Net.Tcgdex.Sdk.Models.Subs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Net.Tcgdex.Sdk.Models
{
    /// <summary>
    /// Card: it contains every information about a specific card
    /// </summary>
    public class Card : Model
    {
        /// <summary>
        /// Globally unique card ID based on the set ID and the card's ID within the set
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// ID indexing this card within its set, usually just its number
        /// </summary>
        public string LocalId { get; set; }

        /// <summary>
        /// Card name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Card image URL without the extension and quality
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Card illustrator
        /// </summary>
        public string Illustrator { get; set; }

        /// <summary>
        /// Card rarity
        /// </summary>
        public string Rarity { get; set; }

        /// <summary>
        /// Card category
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// The card's possible variants
        /// </summary>
        public CardVariants Variants { get; set; }

        /// <summary>
        /// Resume of the set the card belongs to
        /// </summary>
        public SetResume Set { get; set; }

        /// <summary>
        /// The Pokémon Pokédex IDs (multiple if multiple Pokémon appear on the card)
        /// </summary>
        public List<int> DexId { get; set; }

        /// <summary>
        /// HP of the Pokémon
        /// </summary>
        public int? Hp { get; set; }

        /// <summary>
        /// Types of the Pokémon (multiple because some have multiple in the older sets)
        /// </summary>
        public List<string> Types { get; set; }

        /// <summary>
        /// Name of the Pokémon this one evolves from
        /// </summary>
        public string EvolveFrom { get; set; }

        /// <summary>
        /// The Pokémon Pokédex-like description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The Pokémon Level (can be "X" if the card is of level X)
        /// </summary>
        public string Level { get; set; }

        /// <summary>
        /// The Pokémon Stage (changes depending on the API language)
        /// </summary>
        public string Stage { get; set; }

        /// <summary>
        /// The Pokémon Suffix (changes depending on the API language)
        /// </summary>
        public string Suffix { get; set; }

        /// <summary>
        /// The Item the Pokémon has
        /// </summary>
        public CardItem Item { get; set; }

        /// <summary>
        /// The Card abilities (some cards have multiple abilities)
        /// </summary>
        public List<CardAbility> Abilities { get; set; }

        /// <summary>
        /// The Card Attacks
        /// </summary>
        public List<CardAttack> Attacks { get; set; }

        /// <summary>
        /// The Pokémon Weaknesses
        /// </summary>
        public List<CardWeakRes> Weaknesses { get; set; }

        /// <summary>
        /// The Pokémon Resistances
        /// </summary>
        public List<CardWeakRes> Resistances { get; set; }

        /// <summary>
        /// The Pokémon retreat Cost
        /// </summary>
        public int? Retreat { get; set; }

        /// <summary>
        /// Effect of the Card (Trainer/Energy only)
        /// </summary>
        public string Effect { get; set; }

        /// <summary>
        /// The trainer sub-type (changes depending on the API language)
        /// </summary>
        public string TrainerType { get; set; }

        /// <summary>
        /// The energy sub-type (changes depending on the API language)
        /// </summary>
        public string EnergyType { get; set; }

        /// <summary>
        /// The Card Regulation mark
        /// </summary>
        public string RegulationMark { get; set; }

        /// <summary>
        /// The card's ability to be played in tournaments
        /// </summary>
        public Legal Legal { get; set; }

        /// <summary>
        /// The Card Image full URL
        /// </summary>
        /// <param name="quality">The quality you want your image to be in</param>
        /// <param name="extension">Extension you want your image to be</param>
        /// <returns>The full card URL with the extension and quality</returns>
        public string GetImageUrl(Quality quality, Extension extension)
        {
            return $"{Image}/{quality}.{extension}";
        }

        /// <summary>
        /// Get image buffer
        /// </summary>
        /// <param name="quality">The quality you want your image to be in</param>
        /// <param name="format">Extension you want your image to be</param>
        /// <returns>The full card Buffer in the format you want</returns>
        public async Task<IImage> GetImage(Quality quality, Extension format)
        {
            return await Utils.DownloadImageAsync(GetImageUrl(quality, format));
        }
    }
}