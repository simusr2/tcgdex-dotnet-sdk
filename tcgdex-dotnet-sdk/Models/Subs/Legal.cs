namespace Net.Tcgdex.Sdk.Models.Subs
{
    /// <summary>
    /// Card Legality
    /// 
    /// Note: Cards are always usable in unlimited tournaments
    /// </summary>
    public class Legal
    {
        /// <summary>
        /// Card is usable in standard tournaments
        /// </summary>
        public bool Standard { get; set; }

        /// <summary>
        /// Card is usable in expanded tournaments
        /// </summary>
        public bool Expanded { get; set; }
    }
}
