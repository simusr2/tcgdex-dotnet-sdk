

namespace Net.Tcgdex.Sdk.Models.Subs
{
    /// <summary>
    /// Set card count
    /// </summary>
    public class SetCardCount
    {
        /// <summary>
        /// Total number of cards
        /// </summary>
        public int Total { get; set; }

        /// <summary>
        /// Number of cards officially (on the bottom of each card)
        /// </summary>
        public int Official { get; set; }

        /// <summary>
        /// Number of cards having a normal version
        /// </summary>
        public int Normal { get; set; }

        /// <summary>
        /// Number of cards having a reverse version
        /// </summary>
        public int Reverse { get; set; }

        /// <summary>
        /// Number of cards having a holo version
        /// </summary>
        public int Holo { get; set; }

        /// <summary>
        /// Number of possible cards
        /// </summary>
        public int? FirstEd { get; set; }
    }
}
