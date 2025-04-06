namespace Net.Tcgdex.Sdk.Models.Subs
{
    /// <summary>
    /// Describes the weakness/resistance of a single Pokémon, for example: 2x to Fire
    /// </summary>
    public class CardWeakRes
    {
        /// <summary>
        /// The affecting type
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The multiplier, mostly `x2`, but can also be `-30`, `+30` depending on the card
        /// </summary>
        public string Value { get; set; }
    }
}
