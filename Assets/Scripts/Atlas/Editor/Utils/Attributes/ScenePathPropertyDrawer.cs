using UnityEngine;
using UnityEditor;
using System.Linq;
using System;
using System.IO;

namespace Atlas
{
    [CustomPropertyDrawer( typeof( ScenePathAttribute ) )]
    public class ScenePathAttributePropertyDrawer : PropertyDrawer
    {
        public override void OnGUI( Rect position, SerializedProperty property, GUIContent label )
        {
            if ( property.propertyType == SerializedPropertyType.String )
            {
                Rect propertyRect = position;
                propertyRect.height = EditorGUIUtility.singleLineHeight;

                string[] sceneGUIDs = AssetDatabase.FindAssets( "t:Scene" );
                if ( sceneGUIDs != null )
                {
                    string[] scenePaths = sceneGUIDs.Select( ConvertGUIDToFilename ).ToArray();
                    int selectedIndex = Mathf.Max( Array.IndexOf( scenePaths, property.stringValue ), 0 );

                    EditorGUI.BeginChangeCheck();
                    selectedIndex = EditorGUI.Popup( propertyRect,
                                                     label,
                                                     selectedIndex,
                                                     scenePaths.Select( x => new GUIContent( x ) ).ToArray() );
                    if ( EditorGUI.EndChangeCheck() )
                    {
                        if ( selectedIndex >= 0 &&
                            selectedIndex < scenePaths.Length )
                        {
                            property.stringValue = Path.GetFileNameWithoutExtension( scenePaths[selectedIndex] );
                        }
                    }

                    if ( IsSceneValid( property.stringValue ) == false )
                    {
                        propertyRect.y += EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing;
                        propertyRect.height = EditorGUIUtility.singleLineHeight * c_warningHeightScale;
                        EditorGUI.HelpBox( propertyRect, "Scene is not included in editor build settings", MessageType.Error );
                    }
                }
            }
            else
            {
                EditorGUI.PropertyField( position, property, label );
            }
        }

        public override float GetPropertyHeight( SerializedProperty property, GUIContent label )
        {
            if ( property.propertyType == SerializedPropertyType.String )
            {
                if ( IsSceneValid( property.stringValue ) )
                {
                    return base.GetPropertyHeight( property, label );
                }
                else
                {
                    return base.GetPropertyHeight( property, label ) + EditorGUIUtility.singleLineHeight * c_warningHeightScale + EditorGUIUtility.standardVerticalSpacing;
                } 
            }
            else
            {
                return base.GetPropertyHeight( property, label );
            }
        }

        private static string ConvertGUIDToFilename( string guid )
        {
            return Path.GetFileNameWithoutExtension( AssetDatabase.GUIDToAssetPath( guid ) );
        }

        private static bool IsSceneValid( string sceneName )
        {
            return EditorBuildSettings.scenes.Any( x => Path.GetFileNameWithoutExtension( x.path ) == sceneName );
        }

        private const float c_warningHeightScale = 1.4f;
    }
}