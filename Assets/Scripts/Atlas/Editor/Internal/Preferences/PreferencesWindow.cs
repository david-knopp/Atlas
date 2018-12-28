using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

namespace Atlas.Internal
{
    internal static class PreferencesWindow
    {
        private static List<IPreferenceItem> s_preferences;

        [InitializeOnLoadMethod]
        private static void Initialize()
        {
            s_preferences = new List<IPreferenceItem>();

            s_preferences.Add( new DebugDrawPreferences() );

            foreach ( var preference in s_preferences )
            {
                preference.OnInitialize();
            }

        }

        [PreferenceItem( "Atlas" )]
        private static void OnGUI()
        {
            DrawInfo();

            EditorGUILayout.Separator();

            for ( int i = 0; i < s_preferences.Count; i++ )
            {
                EditorGUILayoutUtils.HorizontalLine( height: i == 0 ? 2f : 1f, 
                                                     widthPct: i == 0 ? 0.95f : 0.85f );

                IPreferenceItem preference = s_preferences[i];
                preference.OnGUI();
            }
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
    }
}