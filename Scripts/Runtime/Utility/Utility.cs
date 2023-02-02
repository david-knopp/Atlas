namespace Atlas
{
    public static class Utility
    {
        /// <summary>
        /// Swaps the values of the given parameters
        /// </summary>
        public static void Swap<T>( ref T lhs, ref T rhs )
        {
            T temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
    }
}
