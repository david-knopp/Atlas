using UnityEditor;
using UnityEngine;

namespace Atlas
{    
    /// <summary>
    /// Handles inspector drawing for <see cref="PathAttribute"/>
    /// </summary>
    [CustomPropertyDrawer( typeof( PathAttribute ) )]
    public sealed class PathAttributePropertyDrawer : PropertyDrawer
    {
        public override void OnGUI( Rect position, SerializedProperty property, GUIContent label )
        {
            PathAttribute pathAttribute = attribute as PathAttribute;
            if ( pathAttribute == null ||
                 property.propertyType != SerializedPropertyType.String )
            {
                EditorGUI.PropertyField( position, property, label );
                return;
            }

            Rect propertyRect = position;
            propertyRect.width -= ( c_buttonWidth + c_padWidth * 2f );

            // standard string field
            EditorGUI.PropertyField( propertyRect, property, label );

            Rect buttonRect = position;
            buttonRect.x += propertyRect.width + c_padWidth;
            buttonRect.width = c_buttonWidth;

            string relativePath = pathAttribute.RelativePath;
            string curFullPath = string.Format( "{0}{1}", relativePath, property.stringValue );

            // file path selector button
            if ( GUI.Button( buttonRect, "..." ) )
            {
                string path = null;

                // open desired explorer panel
                switch ( pathAttribute.TargetType )
                {
                    case PathAttribute.Path.File:
                        path = EditorUtility.OpenFilePanel( label.text, curFullPath, string.Empty );
                        break;

                    case PathAttribute.Path.Directory:
                        path = EditorUtility.OpenFolderPanel( label.text, curFullPath, string.Empty );
                        break;
                }

                // cleanup path
                if ( string.IsNullOrEmpty( path ) == false )
                {
                    // remove relative path
                    int relativeIndex = path.IndexOf( relativePath );
                    if ( relativeIndex >= 0 )
                    {
                        property.stringValue = path.Remove( relativeIndex, relativePath.Length );
                    }
                    else
                    {
                        property.stringValue = path;
                    }
                }
            }
        }

        private const float c_buttonWidth = 30f;
        private const float c_padWidth = 5f;
    }
}