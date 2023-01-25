using System.Collections.Generic;

namespace Atlas
{
    public static class KeyValuePairExtensions
    {
        /// <summary>
        /// Allows for breaking apart Key-value pairs, allowing syntax such as:
        /// foreach ( ( TKey key, TValue value ) in myDictionary ) {}
        /// </summary>
        public static void Deconstruct<TKey, TValue>(
            this KeyValuePair<TKey, TValue> kvp,
            out TKey key,
            out TValue value )
        {
            key = kvp.Key;
            value = kvp.Value;
        }
    }
}
