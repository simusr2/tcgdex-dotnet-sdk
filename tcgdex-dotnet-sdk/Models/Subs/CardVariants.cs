namespace Net.Tcgdex.Sdk.Models.Subs
{
    /// <summary>
    /// Card variants
    /// </summary>
    public class CardVariants
    {
        /// <summary>
        /// Basic variant, no special effects
        /// </summary>
        public bool? Normal { get; set; }

        /// <summary>
        /// The card has some shine behind colored content
        /// </summary>
        public bool? Reverse { get; set; }

        /// <summary>
        /// The card picture has some shine to it
        /// </summary>
        public bool? Holo { get; set; }

        /// <summary>
        /// The card contains a First Edition Stamp (only Base series)
        /// </summary>
        public bool? FirstEdition { get; set; }

        /// <summary>
        /// The card has a W Promo stamp on it
        /// </summary>
        public bool? WPromo { get; set; }
    }
}
