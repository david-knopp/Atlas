using UnityEngine;
using UnityEditor;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Atlas.Internal
{
    internal class AtlasSettingsProvider : SettingsProvider
    {
        #region public
        [SettingsProvider]
        public static SettingsProvider CreateSettingsProvider()
        {
            return new AtlasSettingsProvider( "Preferences/Atlas", SettingsScope.User );
        }

        public override void OnGUI( string searchContext )
        {
            DrawInfo();

            EditorGUILayout.Separator();
            EditorGUILayoutUtils.HorizontalLine( 2f, 0.95f );

            for ( int i = 0; i < m_settingsItems.Count; i++ )
            {
                ISettingsItem settingsItem = m_settingsItems[i];

                EditorGUILayoutUtils.RichLabelField( string.Format( "<b>{0}</b>", settingsItem.Name ) );

                using ( new EditorGUI.IndentLevelScope() )
                {
                    settingsItem.OnGUI();
                }

                if ( i < m_settingsItems.Count - 1 )
                {
                    EditorGUILayout.Separator();
                    EditorGUILayoutUtils.HorizontalLine( 1f, 0.85f );
                }
            }
        }
        #endregion public

        #region private
        private AtlasSettingsProvider( string path, SettingsScope scope )
            : base( path, scope )
        {
            Initialize();
        }

        private List<ISettingsItem> m_settingsItems;

        private void Initialize()
        {
            m_settingsItems = new List<ISettingsItem>();

            List<string> itemKeywords = new List<string>();

            // add settings items
            Type interfaceType = typeof( ISettingsItem );
            var settingsTypes = AppDomain.CurrentDomain.GetAssemblies()
                                                       .SelectMany( x => x.GetTypes() )
                                                       .Where( x => x.IsClass && interfaceType.IsAssignableFrom( x ) );

            foreach ( Type settingsType in settingsTypes )
            {
                ISettingsItem settingsItem = Activator.CreateInstance( settingsType ) as ISettingsItem;
                if ( settingsItem != null )
                {
                    m_settingsItems.Add( settingsItem );
                    itemKeywords.AddRange( settingsItem.Keywords );
                }
            }

            foreach ( var settingItem in m_settingsItems )
            {
                settingItem.OnInitialize();
            }

            keywords = itemKeywords;
        }

        private static void DrawInfo()
        {
            using ( new GUIColorScope( new Color( 0.6f, 0.6f, 0.6f ) ) )
            {
                EditorGUILayoutUtils.RichLabelField( "<b>Atlas Utility Library</b> by David Knopp" );
                EditorGUILayout.LabelField( string.Format( "Version {0}", Version.Full ) );
            }

            EditorGUILayout.BeginHorizontal( GUILayout.Width( 300f ) );

            if ( GUILayout.Button( "View documentation" ) )
            {
                Application.OpenURL( "https://david-knopp.github.io/Atlas/index.html" );
            }

            if ( GUILayout.Button( "View on Github" ) )
            {
                Application.OpenURL( "https://github.com/david-knopp/Atlas" );
            }

            EditorGUILayout.EndHorizontal();
        }
        #endregion private
    }
}