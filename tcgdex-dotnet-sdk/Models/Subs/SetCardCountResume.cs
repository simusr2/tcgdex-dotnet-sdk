namespace Net.Tcgdex.Sdk.Models.Subs
{
    /// <summary>
    /// Set card count resume
    /// </summary>
    public class SetCardCountResume
    {
        /// <summary>
        /// Total number of cards
        /// </summary>
        public int Total { get; set; }

        /// <summary>
        /// Number of cards officially (on the bottom of each card)
        /// </summary>
        public int Official { get; set; }
    }
}
