using System.Collections.Generic;
using UnityEditor;

namespace Atlas
{
    public static class SerializedObjectExtensions
    {
        /// <summary>
        /// Iterates the given SerializedObject's properties
        /// </summary>
        /// <param name="obj">Object to iterate</param>
        /// <returns>An enumerable for each property</returns>
        public static IEnumerable<SerializedProperty> GetProperties( this SerializedObject obj )
        {
            SerializedProperty prop = obj.GetIterator();

            if ( prop != null &&
                 prop.NextVisible( enterChildren: true ) )
            {
                do
                {
                    yield return prop;
                } while ( prop.NextVisible( enterChildren: false ) );
            }
        }
    }
}
