#define ATLAS_TRANSFORM_EDIT_ENABLED

#if ATLAS_TRANSFORM_EDIT_ENABLED

using UnityEngine;
using UnityEditor;

namespace Atlas
{
    [CustomEditor( typeof( Transform ) )]
    public class TransformEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            serializedObject.Update();

            GUILayoutOption buttonWidth = GUILayout.Width( 50.0f );
            DrawResettableProp( m_posProp, new GUIContent( "Pos", "Reset Position" ), Vector3.zero, buttonWidth );
            DrawRotationProp( m_rotProp, new GUIContent( "Rot", "Reset Rotation" ), buttonWidth );
            DrawResettableProp( m_scaleProp, new GUIContent( "Scale", "Reset Scale" ), Vector3.one, buttonWidth );

            serializedObject.ApplyModifiedProperties();
        }

        [SerializeField] private SerializedProperty m_posProp;
        [SerializeField] private SerializedProperty m_rotProp;
        [SerializeField] private SerializedProperty m_scaleProp;

        private void OnEnable()
        {
            m_posProp = serializedObject.FindProperty( "m_LocalPosition" );
            m_rotProp = serializedObject.FindProperty( "m_LocalRotation" );
            m_scaleProp = serializedObject.FindProperty( "m_LocalScale" );
        }

        private void DrawResettableProp( SerializedProperty property, GUIContent resetBtnContent, Vector3 resetValue, params GUILayoutOption[] btnOptions )
        {
            GUILayout.BeginHorizontal();

            if ( GUILayout.Button( resetBtnContent, btnOptions ) )
            {
                property.vector3Value = resetValue;
            }

            EditorGUILayout.PropertyField( property, GUIContent.none, true );

            GUILayout.EndHorizontal();
        }

        private void DrawRotationProp( SerializedProperty property, GUIContent resetBtnContent, params GUILayoutOption[] btnOptions )
        {
            GUILayout.BeginHorizontal();

            if ( GUILayout.Button( resetBtnContent, btnOptions ) )
            {
                property.quaternionValue = Quaternion.identity;
            }
            
            Vector3 eulerAngles = property.quaternionValue.eulerAngles;

            EditorGUI.BeginChangeCheck();
            eulerAngles = EditorGUILayout.Vector3Field( GUIContent.none, eulerAngles );
            if ( EditorGUI.EndChangeCheck() )
            {
                property.quaternionValue = Quaternion.Euler( eulerAngles );
            }

            GUILayout.EndHorizontal();
        }
    }
}
#endif