using Net.Tcgdex.Sdk.Internal;
using System.Collections.Generic;

namespace Net.Tcgdex.Sdk.Models
{
    /// <summary>
    /// String endpoint model
    /// </summary>
    public class StringEndpoint : Model
    {
        /// <summary>
        /// The endpoint value
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The cards that contain `name` in them
        /// </summary>
        public List<CardResume> Cards { get; set; }
    }

}
