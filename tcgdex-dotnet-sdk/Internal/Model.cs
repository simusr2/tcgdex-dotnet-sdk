using System.Text.Json;

namespace Net.Tcgdex.Sdk.Internal
{
    /// <summary>
    /// Base class for all models
    /// </summary>
    public abstract class Model
    {
        /// <summary>
        /// Gives you a string representation of the Model
        /// </summary>
        /// <returns>The model data as JSON</returns>
        public override string ToString()
        {
            return JsonSerializer.Serialize(this, GetType());
        }

        /// <summary>
        /// The TCGdexClient instance that created this model
        /// </summary>
        public TCGdexClient TcgDex { get; set; }
    }
}
