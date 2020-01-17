using UnityEngine;
using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;

namespace Atlas.Internal
{
    internal static class Preferences
    {
        #region public
        internal static T Get<T>( string key )
        {
            return Get( key, ( T )default( object ) );
        }

        internal static T Get<T>( string key, T defaultValue )
        {
            if ( !IsLoaded )
            {
                Load();

            }

            string strValue;
            if ( s_preferences.TryGetValue( key, out strValue ) &&
                 string.IsNullOrEmpty( strValue ) == false )
            {
                return GetValueFromString( strValue, defaultValue );
            }

            return defaultValue;
        }

        internal static void Set<T>( string key, T value )
        {
            if ( !IsLoaded )
            {
                Load();
            }

            s_preferences[key] = GetStringFromValue( value );

            Save();
        } 
        #endregion public

        #region private
        [Serializable]
        private class PreferenceList
        {
            public List<PreferenceItem> m_elements;
        }

        [Serializable]
        private class PreferenceItem
        {
            public string m_key;
            public string m_value;
        }

        private static bool IsLoaded
        {
            get { return s_preferences != null; }
        }

        private const string c_projectPreferencesPath = "ProjectSettings/AtlasPreferences.asset";

        private static Dictionary<string, string> s_preferences;

        private static void Load()
        {
            s_preferences = new Dictionary<string, string>();

            using ( FileStream fileStream = new FileStream( c_projectPreferencesPath, FileMode.OpenOrCreate ) )
            {
                using ( StreamReader reader = new StreamReader( fileStream ) )
                {
                    string prefsString = reader.ReadToEnd();
                    if ( string.IsNullOrEmpty( prefsString ) == false )
                    {
                        PreferenceList preferences = JsonUtility.FromJson<PreferenceList>( prefsString );
                        foreach ( var preference in preferences.m_elements )
                        {
                            s_preferences.Add( preference.m_key, preference.m_value );
                        }
                    }
                }
            }
        }

        private static void Save()
        {
            using ( StreamWriter writer = new StreamWriter( c_projectPreferencesPath, false ) )
            {
                PreferenceList preferenceList = new PreferenceList();
                preferenceList.m_elements = new List<PreferenceItem>();

                foreach ( var preference in s_preferences )
                {
                    preferenceList.m_elements.Add( new PreferenceItem()
                    {
                        m_key = preference.Key,
                        m_value = preference.Value
                    } );
                }

                string text = JsonUtility.ToJson( preferenceList, true );
                writer.Write( text );
            }
        } 

        private static T GetValueFromString<T>( string value, T defaultValue )
        {
            try
            {
                var converter = TypeDescriptor.GetConverter( typeof( T ) );
                if ( converter != null )
                {
                    return ( T )converter.ConvertFromString( value );
                }
            }
            catch ( Exception )
            {
                Debug.LogErrorFormat( "Can't parse type '{0}' from string '{1}'", typeof( T ), value );
            }

            return defaultValue;
        }

        private static string GetStringFromValue<T>( T value )
        {
            var converter = TypeDescriptor.GetConverter( typeof( T ) );
            if ( converter != null )
            {
                return converter.ConvertToString( value );
            }

            return string.Empty;
        }
        #endregion private
    }
}