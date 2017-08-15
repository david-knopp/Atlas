namespace Atlas
{
    public static class HashCode
    {
        public static int Combine( int hashA, int hashB )
        {
            int hash = 13;

            hash = ( hash * 7 ) + hashA;
            hash = ( hash * 7 ) + hashB;

            return hash;
        }

        public static int Combine( int hashA, int hashB, int hashC )
        {
            int hash = 13;

            hash = ( hash * 7 ) + hashA;
            hash = ( hash * 7 ) + hashB;
            hash = ( hash * 7 ) + hashC;

            return hash;
        }

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