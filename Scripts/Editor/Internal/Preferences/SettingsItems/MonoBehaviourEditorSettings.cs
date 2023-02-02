using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Atlas.Internal
{
    internal sealed class MonoBehaviourEditorSettings : ISettingsItem
    {
        #region ISettingsItem
        public string Name
        {
            get { return "MonoBehaviour Editor"; }
        }

        public List<string> Keywords
        {
            get
            {
                return new List<string>() { "mono", "behaviour", "behavior", "editor", "inspector", "button" };
            }
        }

        public void OnInitialize()
        {
            m_isEnabled = Preferences.Get( c_statePrefKey, true );
            UpdateDefineSymbols();
        }

        public void OnGUI()
        {
            EditorGUI.BeginChangeCheck();

            GUIContent label = new GUIContent(
                "Enabled",
                "Enables or disables the MonoBehaviour inspector tools. This can be helpful when using other libraries that also extend the MonoBehaviour editor." );

            m_isEnabled = EditorGUILayout.Toggle( label, m_isEnabled );

            if ( EditorGUI.EndChangeCheck() )
            {
                Preferences.Set( c_statePrefKey, m_isEnabled );
                UpdateDefineSymbols();
            }
        }
        #endregion ISettingsItem

        private bool m_isEnabled;

        private const string c_statePrefKey = "MonoBehaviourEditor_State";
        private const string c_disabledDefineSymbol = "ATLAS_MONOBEHAVIOUR_EDITOR_DISABLED";

        private void UpdateDefineSymbols()
        {
            if ( m_isEnabled == false )
            {
                ScriptingDefines.AddSymbol( c_disabledDefineSymbol );
            }
            else
            {
                ScriptingDefines.RemoveSymbol( c_disabledDefineSymbol );
            }
        }
    }
}