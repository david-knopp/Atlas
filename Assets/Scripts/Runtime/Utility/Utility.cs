namespace Atlas
{
    public static class Utility
    {
        public static void Swap<T>( ref T lhs, ref T rhs )
        {
            T temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
    }
}
