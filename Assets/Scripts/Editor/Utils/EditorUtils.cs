using UnityEditor;
using System;
using System.Reflection;

namespace Atlas
{
    public static class EditorUtils
    {
        /// <summary>
        /// Whether or not the default editor tools (scale, rotate, translate, rect) are hidden
        /// </summary>
        public static bool HideTools
        {
            get
            {
                Type type = typeof( Tools );
                FieldInfo field = type.GetField( "s_Hidden", BindingFlags.NonPublic | BindingFlags.Static );
                return ( ( bool )field.GetValue( null ) );
            }
            set
            {
                Type type = typeof( Tools );
                FieldInfo field = type.GetField( "s_Hidden", BindingFlags.NonPublic | BindingFlags.Static );
                field.SetValue( null, value );
            }
        }
    }
}