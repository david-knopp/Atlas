using UnityEngine;
using UnityEditor;

namespace Atlas.Internal
{
    internal static class PreferencesWindow
    {
        private static class DebugDrawPrefs
        {
            public enum State
            {
                Disabled = 0,
                Enabled = 1,
                EditorOnly = 2
            }

            public static State CurState
            {
                get;
                set;
            }

            public static bool IsVisibleAtStart
            {
                get;
                set;
            }

            public static readonly string[] s_stateOptions = new string[] { "Disabled", "Enabled", "Editor Only" };

            public const string c_statePrefsKey = "Atlas_DebugDraw_State";
            public const string c_runtimeDefineSymbol = "ATLAS_DEBUGDRAW_RUNTIME";
            public const string c_editorDefineSymbol = "ATLAS_DEBUGDRAW_EDITOR";
            public const string c_visibleDefineSymbol = "ATLAS_DEBUGDRAW_VISIBLEATSTART";
        }

        [InitializeOnLoadMethod]
        private static void Initialize()
        {
            DebugDrawPrefs.CurState = ( DebugDrawPrefs.State )EditorPrefs.GetInt( DebugDrawPrefs.c_statePrefsKey, 0 );
            UpdateDebugDrawStateSymbols();

            DebugDrawPrefs.IsVisibleAtStart = ScriptingDefines.ContainsSymbol( DebugDrawPrefs.c_visibleDefineSymbol );
        }

        [PreferenceItem( "Atlas" )]
        private static void OnGUI()
        {
            DrawInfo();

            EditorGUILayout.Separator();
            EditorGUILayoutUtils.HorizontalLine();
            EditorGUILayout.Separator();

            DrawDebugDrawPrefs();
        }

        private static void DrawInfo()
        {
            using ( new GUIColorScope( new Color( 0.6f, 0.6f, 0.6f ) ) )
            {
                var labelStyle = EditorStyles.label;
                labelStyle.richText = true;
                EditorGUILayout.LabelField( "<b>Atlas Utility Library</b> by David Knopp", labelStyle );
                EditorGUILayout.LabelField( string.Format( "Version {0}", Version.Full ) );
            }
        }

        private static void DrawDebugDrawPrefs()
        {
            EditorGUI.BeginChangeCheck();
            GUIContent debugDrawContent = new GUIContent( "Debug Draw", "Determines whether the Debug Draw feature is compiled away or not" );
            int state = EditorGUILayout.Popup( debugDrawContent, ( int )DebugDrawPrefs.CurState, DebugDrawPrefs.s_stateOptions );
            if ( EditorGUI.EndChangeCheck() )
            {
                DebugDrawPrefs.CurState = ( DebugDrawPrefs.State )state;
                UpdateDebugDrawStateSymbols();
                EditorPrefs.SetInt( DebugDrawPrefs.c_statePrefsKey, state );
            }

            using ( new EditorGUI.DisabledScope( DebugDrawPrefs.CurState == DebugDrawPrefs.State.Disabled ) )
            {
                using ( new EditorGUI.IndentLevelScope() )
                {
                    if ( !Application.isPlaying )
                    {
                        GUIContent defaultContent = new GUIContent( "Visible at start", "Sets whether drawing is initially visible or not (can be toggled on/off through code later)" );

                        EditorGUI.BeginChangeCheck();
                        bool isVisibleAtStart = EditorGUILayout.Toggle( defaultContent, DebugDrawPrefs.IsVisibleAtStart );
                        if ( EditorGUI.EndChangeCheck() )
                        {
                            DebugDrawPrefs.IsVisibleAtStart = isVisibleAtStart;
                            if ( DebugDrawPrefs.IsVisibleAtStart )
                            {
                                ScriptingDefines.AddSymbol( DebugDrawPrefs.c_visibleDefineSymbol );
                            }
                            else
                            {
                                ScriptingDefines.RemoveSymbol( DebugDrawPrefs.c_visibleDefineSymbol );
                            }
                        }
                    }
                    else
                    {
                        DebugDraw.IsEnabled = EditorGUILayout.Toggle( new GUIContent( "Visible", "Sets whether drawing is visible or not" ),
                                                                      DebugDraw.IsEnabled );
                    }
                }
            }
        }

        private static void UpdateDebugDrawStateSymbols()
        {
            switch ( DebugDrawPrefs.CurState )
            {
            default:
            case DebugDrawPrefs.State.Disabled:
                ScriptingDefines.RemoveSymbol( DebugDrawPrefs.c_runtimeDefineSymbol );
                ScriptingDefines.RemoveSymbol( DebugDrawPrefs.c_editorDefineSymbol );
                break;

            case DebugDrawPrefs.State.Enabled:
                ScriptingDefines.AddSymbol( DebugDrawPrefs.c_runtimeDefineSymbol );
                ScriptingDefines.RemoveSymbol( DebugDrawPrefs.c_editorDefineSymbol );
                break;

            case DebugDrawPrefs.State.EditorOnly:
                ScriptingDefines.RemoveSymbol( DebugDrawPrefs.c_runtimeDefineSymbol );
                ScriptingDefines.AddSymbol( DebugDrawPrefs.c_editorDefineSymbol );
                break;
            }
        }
    }
}