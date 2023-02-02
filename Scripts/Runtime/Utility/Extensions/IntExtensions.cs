namespace Atlas
{

    public static class IntExtensions
    {
        /// <summary>
        /// Determines if the given integer is an even number (divisible by 2)
        /// </summary>
        /// <param name="value">The integer to check if even</param>
        /// <returns>True if the value is even, false otherwise</returns>
        public static bool IsEven( this int value )
        {
            return value % 2 == 0;
        }

        /// <summary>
        /// Determines if the given integer is an odd number
        /// </summary>
        /// <param name="value">The integer to check if odd</param>
        /// <returns>True if the value is odd, false otherwise</returns>
        public static bool IsOdd( this int value )
        {
            return !value.IsEven();
        }

        /// <summary>
        /// Determines if the given unsigned integer is an even number (divisible by 2)
        /// </summary>
        /// <param name="value">The integer to check if even</param>
        /// <returns>True if the value is even, false otherwise</returns>
        public static bool IsEven( this uint value )
        {
            return value % 2 == 0;
        }

        /// <summary>
        /// Determines if the given unsigned integer is an odd number
        /// </summary>
        /// <param name="value">The integer to check if odd</param>
        /// <returns>True if the value is odd, false otherwise</returns>
        public static bool IsOdd( this uint value )
        {
            return !value.IsEven();
        }
    }
}
