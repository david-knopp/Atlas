using System;
using System.Reflection;

namespace Atlas
{
    /// <summary>
    /// Extension methods for the <see cref="Enum"/> class
    /// </summary>
    public static class EnumExtensions
    {
        /// <summary>
        /// Determines if the given enum value has been marked with <see cref="ObsoleteAttribute"/>
        /// </summary>
        /// <param name="e">The enum value to check</param>
        /// <returns>True if the value has been marked obselete, false otherwise</returns>
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