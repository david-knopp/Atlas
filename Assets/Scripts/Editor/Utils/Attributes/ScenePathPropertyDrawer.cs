using UnityEngine;
using UnityEditor;
using System.Linq;
using System;
using System.IO;

namespace Atlas
{
    /// <summary>
    /// Handles inspector drawing for <see cref="ScenePathAttribute"/>
    /// </summary>
    [CustomPropertyDrawer( typeof( ScenePathAttribute ) )]
    public sealed class ScenePathAttributePropertyDrawer : PropertyDrawer
    {
        public override void OnGUI( Rect position, SerializedProperty property, GUIContent label )
        {
            if ( property.propertyType == SerializedPropertyType.String )
            {
                Rect propertyRect = position;
                propertyRect.height = EditorGUIUtility.singleLineHeight;

                string[] sceneGUIDs = AssetDatabase.FindAssets( "t:Scene" );
                if ( sceneGUIDs != null
                     && sceneGUIDs.Length > 0 )
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

                        DrawWarningBox( rect: propertyRect,
                                        warningText: "Scene is not included in editor build settings\n",

                                        leftButtonText: "Build Settings",
                                        leftButtonCallback: () =>
                                        {
                                            EditorApplication.ExecuteMenuItem( "File/Build Settings..." );
                                        },

                                        rightButtonText: "Add it",
                                        rightButtonCallback: () =>
                                        {
                                            if ( selectedIndex >= 0 &&
                                                 selectedIndex < sceneGUIDs.Length )
                                            {
                                                EditorBuildSettingsScene scene = new EditorBuildSettingsScene( new GUID( sceneGUIDs[selectedIndex] ), true );

                                                var scenesList = new EditorBuildSettingsScene[EditorBuildSettings.scenes.Length + 1];
                                                Array.Copy( EditorBuildSettings.scenes, scenesList, scenesList.Length - 1 );
                                                scenesList[scenesList.Length - 1] = scene;

                                                EditorBuildSettings.scenes = scenesList;

                                                // force gui repaint
                                                EditorUtility.SetDirty( property.serializedObject.targetObject );
                                            }
                                        } );
                    }
                    else if ( IsSceneEnabled( property.stringValue ) == false )
                    {
                        propertyRect.y += EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing;
                        propertyRect.height = EditorGUIUtility.singleLineHeight * c_warningHeightScale;

                        DrawWarningBox( rect: propertyRect,
                                        warningText: "Scene is not enabled in editor build settings\n",

                                        leftButtonText: "Build Settings",
                                        leftButtonCallback: () =>
                                        {
                                            EditorApplication.ExecuteMenuItem( "File/Build Settings..." );
                                        },

                                        rightButtonText: "Enable it",
                                        rightButtonCallback: () =>
                                        {
                                            if ( selectedIndex >= 0 &&
                                                 selectedIndex < sceneGUIDs.Length )
                                            {
                                                GUID sceneGUID = new GUID( sceneGUIDs[selectedIndex] );
                                                var scenesList = new EditorBuildSettingsScene[EditorBuildSettings.scenes.Length];
                                                Array.Copy( EditorBuildSettings.scenes, scenesList, scenesList.Length );

                                                foreach ( var scene in scenesList )
                                                {
                                                    if ( scene.guid == sceneGUID )
                                                    {
                                                        scene.enabled = true;
                                                        break;
                                                    }
                                                }

                                                EditorBuildSettings.scenes = scenesList;

                                                // force gui repaint
                                                EditorUtility.SetDirty( property.serializedObject.targetObject );
                                            }
                                        } );
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
                if ( IsSceneEnabled( property.stringValue ) )
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

        private static EditorBuildSettingsScene GetScene( string sceneName )
        {
            foreach ( var scene in EditorBuildSettings.scenes )
            {
                if ( Path.GetFileNameWithoutExtension( scene.path ) == sceneName )
                {
                    return scene;
                }
            }

            return null;
        }

        private static bool IsSceneValid( string sceneName )
        {
            return GetScene( sceneName ) != null;
        }

        private static bool IsSceneEnabled( string sceneName )
        {
            var scene = GetScene( sceneName );

            return scene != null && 
                   scene.enabled;
        }

        private static void DrawWarningBox( Rect rect, 
                                            string warningText, 
                                            string leftButtonText, 
                                            Action leftButtonCallback, 
                                            string rightButtonText, 
                                            Action rightButtonCallback )
        {
            EditorGUI.HelpBox( rect, warningText, MessageType.Error );

            Rect buttonRect = rect;
            buttonRect.x += c_buttonLeftPadding;
            buttonRect.width -= ( c_buttonLeftPadding + c_buttonRightPadding + c_buttonSpacing );
            buttonRect.width /= 2.0f;
            buttonRect.y += EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing * 3f;
            buttonRect.height = EditorGUIUtility.singleLineHeight * 1.1f;

            if ( GUI.Button( buttonRect, leftButtonText ) )
            {
                leftButtonCallback.Invoke();
            }

            buttonRect.x += buttonRect.width + c_buttonSpacing;

            if ( GUI.Button( buttonRect, rightButtonText ) )
            {
                rightButtonCallback.Invoke();
            }
        }

        private const float c_warningHeightScale = 2.8f;
        private const float c_buttonLeftPadding = 40f;
        private const float c_buttonRightPadding = 20f;
        private const float c_buttonSpacing = 10f;
    }
}