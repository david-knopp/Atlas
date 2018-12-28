using UnityEngine;
using UnityEditor;
using System;
using System.Collections.Generic;
using System.Linq;

namespace f9
{
}

namespace Atlas.Internal
{
    internal static class PreferencesWindow
    {
        private static List<IPreferenceItem> s_preferences;

        [InitializeOnLoadMethod]
        private static void Initialize()
        {
            s_preferences = new List<IPreferenceItem>();

            // add preference items
            Type interfaceType = typeof( IPreferenceItem );
            var preferenceTypes = AppDomain.CurrentDomain.GetAssemblies()
                                                         .SelectMany( x => x.GetTypes() )
                                                         .Where( x => x.IsClass && interfaceType.IsAssignableFrom( x ) );

            foreach ( Type prefType in preferenceTypes )
            {
                IPreferenceItem preferenceItem = Activator.CreateInstance( prefType ) as IPreferenceItem;
                if ( preferenceItem != null )
                {
                    s_preferences.Add( preferenceItem ); 
                }
            }

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
            EditorGUILayoutUtils.HorizontalLine( 2f, 0.95f );

            for ( int i = 0; i < s_preferences.Count; i++ )
            {
                IPreferenceItem preference = s_preferences[i];

                EditorGUILayoutUtils.RichLabelField( string.Format( "<b>{0}</b>", preference.Name ) );

                using ( new EditorGUI.IndentLevelScope() )
                {
                    preference.OnGUI();
                }

                if ( i < s_preferences.Count - 1 )
                {
                    EditorGUILayoutUtils.HorizontalLine( 1f, 0.85f );
                }
            }
        }

        private static void DrawInfo()
        {
            using ( new GUIColorScope( new Color( 0.6f, 0.6f, 0.6f ) ) )
            {
                EditorGUILayoutUtils.RichLabelField( "<b>Atlas Utility Library</b> by David Knopp" );
                EditorGUILayout.LabelField( string.Format( "Version {0}", Version.Full ) );
            }
        }
    }
}