using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using UnityEditor;

namespace Atlas
{
    public static class SerializedPropertyExtensions
    {
        public static T GetTargetObject<T>( this SerializedProperty property )
        {
            return ( T )GetTargetObject( property );
        }

        public static object GetTargetObject( this SerializedProperty property )
        {
            if ( property == null )
            {
                return null;
            }

            var elements = GetPropertyElements( property.propertyPath );
            return ParseObjectElements( property.serializedObject.targetObject, elements );
        }

        public static void SetTargetObject( this SerializedProperty property, object value )
        {
            var elements = GetPropertyElements( property.propertyPath );
            object obj = ParseObjectElements( property.serializedObject.targetObject, elements.Take( elements.Length - 1 ) );

            if ( ReferenceEquals( obj, null ) )
            {
                return;
            }

            string propertyName = elements.LastOrDefault();
            Type type = obj.GetType();
            FieldInfo fieldInfo = type.GetField( propertyName, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance );
            fieldInfo?.SetValue( obj, value );
        }

        private static object GetValue( object targetObject, string fieldName )
        {
            if ( targetObject == null )
            {
                return null;
            }

            Type type = targetObject.GetType();

            while ( type != null )
            {
                FieldInfo fieldInfo = type.GetField( fieldName, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance );
                if ( fieldInfo != null )
                {
                    return fieldInfo.GetValue( targetObject );
                }

                PropertyInfo propertyInfo = type.GetProperty( fieldName, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase );
                if ( propertyInfo != null )
                {
                    return propertyInfo.GetValue( targetObject );
                }

                type = type.BaseType;
            }

            return null;
        }

        private static object GetValue( object targetObject, string fieldName, int arrayIndex )
        {
            IEnumerable enumerable = GetValue( targetObject, fieldName ) as IEnumerable;
            if ( enumerable == null )
            {
                return null;
            }

            IEnumerator enumerator = enumerable.GetEnumerator();

            for ( int i = 0; i <= arrayIndex; i++ )
            {
                if ( !enumerator.MoveNext() )
                {
                    return null;
                }
            }

            return enumerator.Current;
        }

        private static int ParseElementArrayIndex( string element )
        {
            Regex regex = new Regex( @"^.*\[(\d+)\]" );
            var match = regex.Match( element );

            if ( match.Success &&
                 int.TryParse( match.Groups[0].Value, out int index ) )
            {
                return index;
            }
            else
            {
                return 0;
            }
        }

        private static string ParseArrayElementName( string element )
        {
            return element.Substring( 0, element.IndexOf( "[" ) );
        }

        private static string[] GetPropertyElements( string propertyPath )
        {
            // simplify array names
            propertyPath = propertyPath.Replace( ".Array.data[", "[" );
            return propertyPath.Split( '.' );
        }

        private static object ParseObjectElements( object obj, IEnumerable<string> elements )
        {
            foreach ( var element in elements )
            {
                if ( element.Contains( "[" ) )
                {
                    string elementName = ParseArrayElementName( element );
                    int index = ParseElementArrayIndex( element );

                    obj = GetValue( obj, elementName, index );
                }
                else
                {
                    obj = GetValue( obj, element );
                }
            }

            return obj;
        }
    }
}

