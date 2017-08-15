using System;

namespace Atlas
{
    public static class BitField
    {
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

        public static int SetFlag( int bitField, int flag )
        {
            return bitField |= flag;
        }

        public static int SetFlag( Enum bitField, Enum flag )
        {
            return SetFlag( Convert.ToInt32( bitField ), Convert.ToInt32( flag ) );
        }

        public static int SetFlag( int bitField, Enum flag )
        {
            return SetFlag( bitField, Convert.ToInt32( flag ) );
        }

        public static int ClearFlag( int bitField, int flag )
        {
            return bitField &= ~flag;
        }

        public static int ClearFlag( Enum bitField, Enum flag )
        {
            return ClearFlag( Convert.ToInt32( bitField ), Convert.ToInt32( flag ) );
        }

        public static int ClearFlag( int bitField, Enum flag )
        {
            return ClearFlag( bitField, Convert.ToInt32( flag ) );
        }

        public static int ToggleFlag( int bitField, int flag )
        {
            return bitField ^= flag;
        }

        public static int ToggleFlag( Enum bitField, Enum flag )
        {
            return ToggleFlag( Convert.ToInt32( bitField ), Convert.ToInt32( flag ) );
        }

        public static int ToggleFlag( int bitField, Enum flag )
        {
            return ToggleFlag( bitField, Convert.ToInt32( flag ) );
        }

        public static bool IsFlagSet( int bitField, int flag )
        {
            return ( bitField & flag ) == flag;
        }

        public static bool IsFlagSet( Enum bitField, Enum flag )
        {
            return IsFlagSet( Convert.ToInt32( bitField ), Convert.ToInt32( flag ) );
        }

        public static bool IsFlagSet( int bitField, Enum flag )
        {
            return IsFlagSet( bitField, Convert.ToInt32( flag ) );
        }
    } 
}