using System;
using System.Reflection;

namespace Atlas
{
    public static class EnumExtensions
    {
        public static bool IsObsolete( this Enum e )
        {
            FieldInfo field = e.GetType().GetField( e.ToString() );
            ObsoleteAttribute[] attributes = ( ObsoleteAttribute[] )field.GetCustomAttributes( typeof( ObsoleteAttribute ), false );

            if ( attributes != null &&
                 attributes.Length > 0 )
            {
                return true;
            }

            return false;
        }
    }
}