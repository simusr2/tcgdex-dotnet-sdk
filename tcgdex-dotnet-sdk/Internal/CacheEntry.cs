using System;

namespace Net.Tcgdex.Sdk.Internal
{
    /// <summary>
    /// Cache entry for the cache manager
    /// </summary>
    /// <typeparam name="T">Type of the cache entry</typeparam>
    public class CacheEntry<T>
    {
        /// <summary>
        /// The value of the cache entry
        /// </summary>
        public T Value { get; set; }

        /// <summary>
        /// The time of the cache entry
        /// </summary>
        public DateTime Time { get; set; }

        /// <summary>
        /// CacheEntry constructor
        /// </summary>
        /// <param name="value">Value of the cache entry</param>
        public CacheEntry(T value)
        {
            Value = value;
            Time = DateTime.Now;
        }
    }
}
