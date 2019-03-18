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
        public static int Combine( int hashA, int hashB )
        {
            int hash = 13;

            hash = ( hash * 7 ) + hashA;
            hash = ( hash * 7 ) + hashB;

            return hash;
        }

        /// <summary>
        /// Combines 3 hash codes
        /// </summary>
        /// <returns>The combined hash value</returns>
        public static int Combine( int hashA, int hashB, int hashC )
        {
            int hash = 13;

            hash = ( hash * 7 ) + hashA;
            hash = ( hash * 7 ) + hashB;
            hash = ( hash * 7 ) + hashC;

            return hash;
        }

        /// <summary>
        /// Combines 4 hash codes
        /// </summary>
        /// <returns>The combined hash value</returns>
        public static int Combine( int hashA, int hashB, int hashC, int hashD )
        {
            int hash = 13;

            hash = ( hash * 7 ) + hashA;
            hash = ( hash * 7 ) + hashB;
            hash = ( hash * 7 ) + hashC;
            hash = ( hash * 7 ) + hashD;

            return hash;
        }
    }
}
