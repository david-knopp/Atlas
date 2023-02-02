using System;

namespace Atlas
{
    /// <summary>
    /// A utility class to aid in working with bit fields
    /// </summary>
    public static class BitField
    {
        /// <summary>
        /// Sets a flag in the given field
        /// </summary>
        /// <param name="bitField">Bit field to modify</param>
        /// <param name="flag">The target flag to set</param>
        /// <param name="value">The value to set the flag to</param>
        /// <returns>The modified bit field</returns>
        public static int SetFlag( int bitField, int flag, bool value )
        {
            if ( value )
            {
                return SetFlag( bitField, flag );
            }
            else
            {
                return ClearFlag( bitField, flag );
            }
        }

        /// <summary>
        /// Sets a flag in the given field
        /// </summary>
        /// <param name="bitField">Bit field to modify</param>
        /// <param name="flag">The target flag to set</param>
        /// <returns>The modified bit field</returns>
        public static int SetFlag( int bitField, int flag )
        {
            return bitField |= flag;
        }

        /// <summary>
        /// Sets a flag in the given field
        /// </summary>
        /// <param name="bitField">Bit field to modify</param>
        /// <param name="flag">The target flag to set</param>
        /// <returns>The modified bit field</returns>
        public static int SetFlag( Enum bitField, Enum flag )
        {
            return SetFlag( Convert.ToInt32( bitField ), Convert.ToInt32( flag ) );
        }

        /// <summary>
        /// Sets a flag in the given field
        /// </summary>
        /// <param name="bitField">Bit field to modify</param>
        /// <param name="flag">The target flag to set</param>
        /// <returns>The modified bit field</returns>
        public static int SetFlag( int bitField, Enum flag )
        {
            return SetFlag( bitField, Convert.ToInt32( flag ) );
        }

        /// <summary>
        /// Clears a flag in the given field
        /// </summary>
        /// <param name="bitField">Bit field to modify</param>
        /// <param name="flag">The target flag to clear</param>
        /// <returns>The modified bit field</returns>
        public static int ClearFlag( int bitField, int flag )
        {
            return bitField &= ~flag;
        }

        /// <summary>
        /// Clears a flag in the given field
        /// </summary>
        /// <param name="bitField">Bit field to modify</param>
        /// <param name="flag">The target flag to clear</param>
        /// <returns>The modified bit field</returns>
        public static int ClearFlag( Enum bitField, Enum flag )
        {
            return ClearFlag( Convert.ToInt32( bitField ), Convert.ToInt32( flag ) );
        }

        /// <summary>
        /// Clears a flag in the given field
        /// </summary>
        /// <param name="bitField">Bit field to modify</param>
        /// <param name="flag">The target flag to clear</param>
        /// <returns>The modified bit field</returns>
        public static int ClearFlag( int bitField, Enum flag )
        {
            return ClearFlag( bitField, Convert.ToInt32( flag ) );
        }

        /// <summary>
        /// Toggles a flag in the given field
        /// </summary>
        /// <param name="bitField">The bit field to modify</param>
        /// <param name="flag">The target flag to toggle</param>
        /// <returns>The modified bit field</returns>
        public static int ToggleFlag( int bitField, int flag )
        {
            return bitField ^= flag;
        }

        /// <summary>
        /// Toggles a flag in the given field
        /// </summary>
        /// <param name="bitField">The bit field to modify</param>
        /// <param name="flag">The target flag to toggle</param>
        /// <returns>The modified bit field</returns>
        public static int ToggleFlag( Enum bitField, Enum flag )
        {
            return ToggleFlag( Convert.ToInt32( bitField ), Convert.ToInt32( flag ) );
        }

        /// <summary>
        /// Toggles a flag in the given field
        /// </summary>
        /// <param name="bitField">The bit field to modify</param>
        /// <param name="flag">The target flag to toggle</param>
        /// <returns>The modified bit field</returns>
        public static int ToggleFlag( int bitField, Enum flag )
        {
            return ToggleFlag( bitField, Convert.ToInt32( flag ) );
        }

        /// <summary>
        /// Determines whether or not the flag is set in the given bit field
        /// </summary>
        /// <param name="bitField">The bit field to check</param>
        /// <param name="flag">The target flag to look for</param>
        /// <returns>True if the flag is set, false if not</returns>
        public static bool IsFlagSet( int bitField, int flag )
        {
            return ( bitField & flag ) == flag;
        }

        /// <summary>
        /// Determines whether or not the flag is set in the given bit field
        /// </summary>
        /// <param name="bitField">The bit field to check</param>
        /// <param name="flag">The target flag to look for</param>
        /// <returns>True if the flag is set, false if not</returns>
        public static bool IsFlagSet( Enum bitField, Enum flag )
        {
            return IsFlagSet( Convert.ToInt32( bitField ), Convert.ToInt32( flag ) );
        }

        /// <summary>
        /// Determines whether or not the flag is set in the given bit field
        /// </summary>
        /// <param name="bitField">The bit field to check</param>
        /// <param name="flag">The target flag to look for</param>
        /// <returns>True if the flag is set, false if not</returns>
        public static bool IsFlagSet( int bitField, Enum flag )
        {
            return IsFlagSet( bitField, Convert.ToInt32( flag ) );
        }
    } 
}
