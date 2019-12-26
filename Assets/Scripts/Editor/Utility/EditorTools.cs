using UnityEditor;
using System;
using System.Reflection;

namespace Atlas
{
    public static class EditorTools
    {
        /// <summary>
        /// Whether or not the default editor tools (scale, rotate, translate, rect) are hidden
        /// </summary>
        public static bool HideTools
        {
            get
            {
                FieldInfo field = GetHiddenField();
                return ( bool )field.GetValue( null );
            }

            set
            {
                FieldInfo field = GetHiddenField();
                field.SetValue( null, value );
            }
        }

        private static FieldInfo GetHiddenField()
        {
            Type type = typeof( Tools );
            return type.GetField( "s_Hidden", BindingFlags.NonPublic | BindingFlags.Static );
        }
    }
}
