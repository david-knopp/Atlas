using UnityEngine;
using UnityEditor;
using UnityEditorInternal;

namespace Atlas
{
    [CustomEditor( typeof( PointGraph3D ) )]
    public class PointGraph3DEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            serializedObject.Update();

            m_nodeList.DoLayoutList();

            serializedObject.ApplyModifiedProperties();
        }

        private SerializedProperty m_graphProp;
        private SerializedProperty m_nodesProp;
        private ReorderableList m_nodeList;

        private void OnEnable()
        {
            EditorUtils.HideTools = true;

            m_graphProp = serializedObject.FindProperty( "m_graph" );
            m_nodesProp = m_graphProp.FindPropertyRelative( "m_nodes" );

            m_nodeList = new ReorderableList( serializedObject, m_nodesProp );
            m_nodeList.drawHeaderCallback = OnDrawNodesHeader;
            m_nodeList.drawElementCallback = OnDrawNodeElement;
        }

        private void OnDisable()
        {
            EditorUtils.HideTools = false;
        }

        private void OnSceneGUI()
        {
            if ( m_nodesProp != null )
            {
                EditorGUI.BeginChangeCheck();

                for ( int i = 0; i < m_nodesProp.arraySize; i++ )
                {
                    var posProp = m_nodesProp.GetArrayElementAtIndex( i );

                    posProp.vector3Value = Handles.PositionHandle( posProp.vector3Value, Quaternion.identity );
                }

                if ( EditorGUI.EndChangeCheck() )
                {
                    serializedObject.ApplyModifiedProperties();
                }
            }
        }

        private void OnDrawNodesHeader( Rect rect )
        {
            EditorGUI.LabelField( rect, "Nodes" );
        }

        private void OnDrawNodeElement( Rect rect, int index, bool isActive, bool isFocused )
        {
            SerializedProperty posProp = m_nodesProp.GetArrayElementAtIndex( index );
            EditorGUI.PropertyField( rect, posProp, GUIContent.none, true );
        }
    }
}