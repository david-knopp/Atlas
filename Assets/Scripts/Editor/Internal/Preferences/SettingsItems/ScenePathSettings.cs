using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Atlas.Internal
{
    internal sealed class ScenePathSettings : ISettingsItem
    {
        #region ISettingsItem
        public string Name => "[ScenePath] Settings";
        public List<string> Keywords => new List<string>() { "scene", "path", "scenepath", "filter" };

        public void OnInitialize()
        {
            m_pathHolder = ScriptableObject.CreateInstance<PathHolder>();
            m_pathHolder.Path = GetDefaultScenePathFolder();

            m_pathHolderObject = new SerializedObject( m_pathHolder );
            m_pathProperty = m_pathHolderObject.FindProperty( "Path" );
        }

        public void OnGUI()
        {
            m_pathHolderObject.Update();

            EditorGUI.BeginChangeCheck();

            EditorGUILayout.PropertyField( m_pathProperty, new GUIContent( "Default Scenes Folder" ) );

            if ( EditorGUI.EndChangeCheck() )
            {
                m_pathHolderObject.ApplyModifiedProperties();
                Preferences.Set( c_scenePathFilterKey, m_pathHolder.Path );
            }
        }
        #endregion ISettingsItem

        public static string GetDefaultScenePathFolder()
        {
            return Preferences.Get( c_scenePathFilterKey, "Assets" );
        }

        private sealed class PathHolder : ScriptableObject
        {
            [Path( PathAttribute.Path.Directory, PathAttribute.Relativity.ProjectRelative )]
            public string Path;
        }

        private const string c_scenePathFilterKey = "ScenePath_Filter";

        private PathHolder m_pathHolder;
        private SerializedObject m_pathHolderObject;
        private SerializedProperty m_pathProperty;
    }
}
