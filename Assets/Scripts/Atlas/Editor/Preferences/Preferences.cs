using UnityEngine;
using UnityEditor;

namespace Atlas
{
    public static class Preferences
    {
        public static bool IsDebugDrawEnabledRuntime
        {
            get;
            private set;
        }

        private const string c_runtimePrefsKey = "IsDebugDrawEnabled_Runtime";
        private const string c_compileTimePrefsKey = "IsDebugDrawEnabled_CompileTIme";
        private const string c_debugDrawDefineSymbol = "ATLAS_DEBUG_DRAW";

        [InitializeOnLoadMethod]
        private static void Initialize()
        {
            IsDebugDrawEnabledRuntime = EditorPrefs.GetBool( c_runtimePrefsKey, false );
        }

        [PreferenceItem( "Atlas" )]
        private static void OnGUI()
        {
            using ( new GUIColorScope( new Color( 0.6f, 0.6f, 0.6f ) ) )
            {
                var labelStyle = EditorStyles.label;
                labelStyle.richText = true;
                EditorGUILayout.LabelField( "<b>Atlas Utility Library</b> by David Knopp", labelStyle );
                EditorGUILayout.LabelField( "Version 0.5.0" );
            }

            EditorGUILayout.Separator();
            EditorGUILayout.Separator();

            EditorGUILayout.LabelField( "Debug Draw" );
            using ( new EditorGUI.IndentLevelScope() )
            {
                EditorGUI.BeginChangeCheck();
                bool isToggled = EditorGUILayout.Toggle( "Runtime", IsDebugDrawEnabledRuntime );
                if ( EditorGUI.EndChangeCheck() )
                {

                }
            }
        }
    }
}