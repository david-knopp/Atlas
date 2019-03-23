namespace Atlas.Internal
{
    internal static class Version
    {
        public static int Major
        {
            get { return 0; }
        }

        public static int Minor
        {
            get { return 9; }
        }

        public static int Revision
        {
            get { return 5; }
        }

        public static string Full
        {
            get
            {
                return string.Format( "{0}.{1}.{2}", Major, Minor, Revision );
            }
        }
    }
}