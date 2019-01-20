using UnityEngine;
using UnityEditor;

namespace Atlas.Internal
{
    internal sealed class DebugDrawPreferences : IPreferenceItem
    {
        #region IPreferenceItem
        public string Name
        {
            get { return "Debug Draw"; }
        }

        public void OnInitialize()
        {
            CurState = Preferences.Get( c_statePrefKey, State.Disabled );
            UpdateDebugDrawStateSymbols();

            IsVisibleAtStart = ScriptingDefines.ContainsSymbol( c_visibleDefineSymbol );
        }

        public void OnGUI()
        {
            EditorGUI.BeginChangeCheck();
            GUIContent debugDrawContent = new GUIContent( "State", "Determines whether the Debug Draw feature is compiled away or not" );
            int state = EditorGUILayout.Popup( debugDrawContent, ( int )CurState, s_stateOptions );
            if ( EditorGUI.EndChangeCheck() )
            {
                CurState = ( State )state;
                UpdateDebugDrawStateSymbols();
                Preferences.Set( c_statePrefKey, CurState );
            }

            using ( new EditorGUI.DisabledScope( CurState == State.Disabled ) )
            {
                if ( !Application.isPlaying )
                {
                    GUIContent defaultContent = new GUIContent( "Visible at start", "Sets whether drawing is initially visible or not (can be toggled on/off through code later)" );

                    EditorGUI.BeginChangeCheck();
                    bool isVisibleAtStart = EditorGUILayout.Toggle( defaultContent, IsVisibleAtStart );
                    if ( EditorGUI.EndChangeCheck() )
                    {
                        IsVisibleAtStart = isVisibleAtStart;
                        if ( IsVisibleAtStart )
                        {
                            ScriptingDefines.AddSymbol( c_visibleDefineSymbol );
                        }
                        else
                        {
                            ScriptingDefines.RemoveSymbol( c_visibleDefineSymbol );
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
        #endregion // IPreferenceItem

        private enum State
        {
            Disabled = 0,
            Enabled = 1,
            EditorOnly = 2
        }

        private static State CurState
        {
            get;
            set;
        }

        private static bool IsVisibleAtStart
        {
            get;
            set;
        }

        private static readonly string[] s_stateOptions = new string[] { "Disabled", "Enabled", "Editor Only" };

        private const string c_statePrefKey = "DebugDraw_State";
        private const string c_runtimeDefineSymbol = "ATLAS_DEBUGDRAW_RUNTIME";
        private const string c_editorDefineSymbol = "ATLAS_DEBUGDRAW_EDITOR";
        private const string c_visibleDefineSymbol = "ATLAS_DEBUGDRAW_VISIBLEATSTART";

        private static void UpdateDebugDrawStateSymbols()
        {
            switch ( CurState )
            {
            default:
            case State.Disabled:
                ScriptingDefines.RemoveSymbol( c_runtimeDefineSymbol );
                ScriptingDefines.RemoveSymbol( c_editorDefineSymbol );
                break;

            case State.Enabled:
                ScriptingDefines.AddSymbol( c_runtimeDefineSymbol );
                ScriptingDefines.RemoveSymbol( c_editorDefineSymbol );
                break;

            case State.EditorOnly:
                ScriptingDefines.RemoveSymbol( c_runtimeDefineSymbol );
                ScriptingDefines.AddSymbol( c_editorDefineSymbol );
                break;
            }
        }
    }
}