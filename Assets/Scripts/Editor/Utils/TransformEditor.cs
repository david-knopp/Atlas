#if ATLAS_TRANSFORM_EDITOR_DISABLED == false

using UnityEngine;
using UnityEditor;

namespace Atlas
{
    /// <summary>
    /// Overrides the default Transform editor that adds handy buttons for resetting transform values
    /// </summary>
    [CustomEditor( typeof( Transform ) ), CanEditMultipleObjects]
    public sealed class TransformEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            serializedObject.Update();

            GUIStyle resetButtonStyle = new GUIStyle( "button" );
            resetButtonStyle.fontSize = 18;
            resetButtonStyle.fixedHeight = EditorGUIUtility.singleLineHeight + 1;
            resetButtonStyle.fixedWidth = 40;
            resetButtonStyle.normal.textColor = Color.white;

            GUILayoutOption labelWidth = GUILayout.Width( 50.0f );
            DrawResettableProp( m_posProp, new GUIContent( "Pos", "Reset Position" ), Vector3.zero, new GUIContent( "↺", "Reset Position" ), resetButtonStyle, labelWidth );
            DrawRotationProp( m_rotProp, new GUIContent( "Rot" ), new GUIContent( "↺", "Reset Rotation" ), resetButtonStyle, labelWidth );
            DrawResettableProp( m_scaleProp, new GUIContent( "Scale", "Reset Scale" ), Vector3.one, new GUIContent( "↺", "Reset Scale" ), resetButtonStyle, labelWidth );

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

        private void DrawResettableProp( SerializedProperty property, GUIContent labelContent, Vector3 resetValue, GUIContent buttonContent, GUIStyle buttonStyle, params GUILayoutOption[] labelOptions )
        {
            GUILayout.BeginHorizontal();

            EditorGUILayout.LabelField( labelContent, labelOptions );
            EditorGUILayout.PropertyField( property, GUIContent.none, true );

            bool isButtonDisabled = property.vector3Value == resetValue;
            using ( new EditorGUI.DisabledScope( isButtonDisabled ) )
            {
                using ( new GUIBackgroundColorScope( Color.cyan, !isButtonDisabled ) )
                {
                    if ( GUILayout.Button( buttonContent, buttonStyle ) )
                    {
                        property.vector3Value = resetValue;
                    }
                } 
            }

            GUILayout.EndHorizontal();
        }

        private void DrawRotationProp( SerializedProperty property, GUIContent labelContent, GUIContent buttonContent, GUIStyle buttonStyle, params GUILayoutOption[] labelOptions )
        {
            GUILayout.BeginHorizontal();

            EditorGUILayout.LabelField( labelContent, labelOptions );

            Vector3 eulerAngles = property.quaternionValue.eulerAngles;

            EditorGUI.BeginChangeCheck();
            eulerAngles = EditorGUILayout.Vector3Field( GUIContent.none, eulerAngles );
            if ( EditorGUI.EndChangeCheck() )
            {
                property.quaternionValue = Quaternion.Euler( eulerAngles );
            }

            bool isButtonDisabled = property.quaternionValue == Quaternion.identity;
            using ( new EditorGUI.DisabledScope( isButtonDisabled ) )
            {
                using ( new GUIBackgroundColorScope( Color.cyan, !isButtonDisabled ) )
                {
                    if ( GUILayout.Button( buttonContent, buttonStyle ) )
                    {
                        property.quaternionValue = Quaternion.identity;
                    }
                }
            }

            GUILayout.EndHorizontal();
        }
    }
}
#endif
