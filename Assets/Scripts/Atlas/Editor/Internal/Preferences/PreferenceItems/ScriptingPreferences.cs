using UnityEngine;
using UnityEditor;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

namespace Atlas.Internal
{
    internal class ScriptingPreferences : IPreferenceItem
    {
        public static string NamespaceName
        {
            get { return Preferences.Get( c_namespacePrefKey, c_defaultNamespace ); }
        }

        public static string RuntimePath
        {
            get { return Preferences.Get( c_runtimePathPrefKey, "Scripts/Runtime/" ); }
        }

        #region IPreferenceItem
        public string Name
        {
            get { return "Scripting"; }
        }

        public void OnInitialize()
        {
            m_namespaceName = NamespaceName;
            m_runtimePath = RuntimePath;
        }

        public void OnGUI()
        {
            // namespace
            EditorGUI.BeginChangeCheck();
            GUIContent namespaceContent = new GUIContent( "Namespace", "Namespace to use when generating code" );
            m_namespaceName = EditorGUILayout.TextField( namespaceContent, m_namespaceName );
            if ( EditorGUI.EndChangeCheck() )
            {
                m_namespaceName = ValidateCodeName( m_namespaceName );
                if ( string.IsNullOrEmpty( m_namespaceName ) )
                {
                    m_namespaceName = c_defaultNamespace;
                }
                Preferences.Set( c_namespacePrefKey, m_namespaceName );
            }

            // runtime path
            EditorGUI.BeginChangeCheck();
            GUIContent runtimePathContent = new GUIContent( "Generated Code Path", "Path to runtime script folder" );
            m_runtimePath = EditorGUILayout.TextField( runtimePathContent, m_runtimePath );
            if ( EditorGUI.EndChangeCheck() )
            {
                m_runtimePath = ValidatePath( m_runtimePath );
                if ( m_runtimePath.EndsWith( "/" ) == false )
                {
                    m_runtimePath += "/";
                }
                Preferences.Set( c_runtimePathPrefKey, m_runtimePath );
            }
        }
        #endregion // IPreferenceItem

        private const string c_defaultNamespace = "Atlas";
        private const string c_namespacePrefKey = "Scripting_Namespace";
        private const string c_runtimePathPrefKey = "Scripting_RuntimePath";

        private string m_namespaceName;
        private string m_runtimePath;

        private static string ValidateCodeName( string str )
        {
            return Regex.Replace( str, @"^\s*[0-9]+|\s+|\W", string.Empty );
        }

        private string ValidatePath( string str )
        {
            string format = string.Format( "[{0}]|[{1}]",
                                           Regex.Escape( new string( Path.GetInvalidPathChars() ) ),
                                           Regex.Escape( ( ":*?|\"<>|" ) ) );
            return Regex.Replace( str, format, string.Empty );
        }
    }
}