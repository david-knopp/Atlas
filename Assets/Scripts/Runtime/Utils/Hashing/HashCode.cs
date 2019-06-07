namespace Atlas
{
    /// <summary>
    /// A utility class to aid in working with hashcodes
    /// </summary>
    public static class HashCode
    {
        /// <summary>
        /// Combines 2 hash codes
        /// </summary>
        /// <returns>The combined hash value</returns>
        public static int Combine( int hash1, int hash2 )
        {
            int hash = 13;

            hash = ( hash * 7 ) + hash1;
            hash = ( hash * 7 ) + hash2;

            return hash;
        }

        /// <summary>
        /// Combines 3 hash codes
        /// </summary>
        /// <returns>The combined hash value</returns>
        public static int Combine( int hash1, int hash2, int hash3 )
        {
            int hash = 13;

            hash = ( hash * 7 ) + hash1;
            hash = ( hash * 7 ) + hash2;
            hash = ( hash * 7 ) + hash3;

            return hash;
        }

        /// <summary>
        /// Combines 4 hash codes
        /// </summary>
        /// <returns>The combined hash value</returns>
        public static int Combine( int hash1, int hash2, int hash3, int hash4 )
        {
            int hash = 13;

            hash = ( hash * 7 ) + hash1;
            hash = ( hash * 7 ) + hash2;
            hash = ( hash * 7 ) + hash3;
            hash = ( hash * 7 ) + hash4;

            return hash;
        }

        /// <summary>
        /// Generates a hashcode representing the given objects
        /// </summary>
        /// <returns>The generated hashcode</returns>
        public static int Get<T1, T2>( T1 obj1, T2 obj2 )
        {
            return Combine( obj1.GetHashCode(), obj2.GetHashCode() );
        }

        /// <summary>
        /// Generates a hashcode representing the given objects
        /// </summary>
        /// <returns>The generated hashcode</returns>
        public static int Get<T1, T2, T3>( T1 obj1, T2 obj2, T3 obj3 )
        {
            return Combine( obj1.GetHashCode(), obj2.GetHashCode(), obj3.GetHashCode() );
        }

        /// <summary>
        /// Generates a hashcode representing the given objects
        /// </summary>
        /// <returns>The generated hashcode</returns>
        public static int Get<T1, T2, T3, T4>( T1 obj1, T2 obj2, T3 obj3, T4 obj4 )
        {
            return Combine( obj1.GetHashCode(), obj2.GetHashCode(), obj3.GetHashCode(), obj4.GetHashCode() );
        }
    }
}
