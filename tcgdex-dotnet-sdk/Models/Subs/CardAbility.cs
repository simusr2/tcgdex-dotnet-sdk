namespace Net.Tcgdex.Sdk.Models.Subs
{
    /// <summary>
    /// Describes a single ability of a pokemon
    /// </summary>
    public class CardAbility
    {
        /// <summary>
        /// The Ability type (language dependant)
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Name of the ability
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description/Effect of the ability
        /// </summary>
        public string Effect { get; set; }
    }
}
