using Net.Tcgdex.Sdk.Converters;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Net.Tcgdex.Sdk.Models.Subs
{
    /// <summary>
    /// Describes a single attack of a Pokémon, for example 'Confuse Ray'.
    /// </summary>
    public class CardAttack
    {
        /// <summary>
        /// Name of the attack
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Cost of the attack in the same order as listed on the card
        /// </summary>
        public List<string> Cost { get; set; }

        /// <summary>
        /// Effect/Description of the attack, may be null for attacks without text
        /// </summary>
        public string Effect { get; set; }

        /// <summary>
        /// Damage the attack deals. May just be a number like '30', but can also be a multiplier like 'x20'
        /// </summary>
        [JsonConverter(typeof(DamageToStringConverter))]
        public string Damage { get; set; }
    }
}
