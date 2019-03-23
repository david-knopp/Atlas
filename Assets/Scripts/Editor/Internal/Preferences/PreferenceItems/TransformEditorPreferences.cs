using UnityEditor;
using UnityEngine;

namespace Atlas.Internal
{
    internal sealed class TransformEditorPreferences : IPreferenceItem
    {
        #region IPreferenceItem
        public string Name
        {
            get { return "Transform Editor"; }
        }

        public void OnInitialize()
        {
            m_isEnabled = Preferences.Get( c_statePrefKey, true );
            UpdateDefineSymbols();
        }

        public void OnGUI()
        {
            EditorGUI.BeginChangeCheck();

            GUIContent label = new GUIContent( "Enabled", "Enables or disables the Transform inspector tools" );
            m_isEnabled = EditorGUILayout.Toggle( label, m_isEnabled );

            if ( EditorGUI.EndChangeCheck() )
            {
                Preferences.Set( c_statePrefKey, m_isEnabled );
                UpdateDefineSymbols();
            }
        }
        #endregion IPreferenceItem
        
        private bool m_isEnabled;

        private const string c_statePrefKey = "TransformEditor_State";
        private const string c_disabledDefineSymbol = "ATLAS_TRANSFORM_EDITOR_DISABLED";

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