#if ATLAS_TRANSFORM_EDITOR_DISABLED == false

using UnityEngine;
using UnityEditor;
using System;
using System.Reflection;

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

            DrawResettableProp( m_posProp, m_positionContent, Vector3.zero, new GUIContent( "↺", "Reset Position" ), resetButtonStyle );
            DrawRotationProp( m_rotProp, new GUIContent( "↺", "Reset Rotation" ), resetButtonStyle );
            DrawResettableProp( m_scaleProp, m_scaleContent, Vector3.one, new GUIContent( "↺", "Reset Scale" ), resetButtonStyle );

            Transform transform = target as Transform;
            Vector3 position = transform.position;
            if ( Mathf.Abs( position.x ) > 100000f || Mathf.Abs( position.y ) > 100000f || Mathf.Abs( position.z ) > 100000f )
            {
                EditorGUILayout.HelpBox( m_floatingPointWarning, MessageType.Warning );
            }

            serializedObject.ApplyModifiedProperties();
        }

        private static Type m_rotationGUIType;
        private static MethodInfo m_rotationFieldMethod;
        private static MethodInfo m_rotationGUIEnableMethod;

        private SerializedProperty m_posProp;
        private SerializedProperty m_rotProp;
        private SerializedProperty m_scaleProp;

        private object m_rotationGUI;
        private GUIContent m_positionContent = EditorGUIUtility.TrTextContent( "Position", "The local position of this GameObject relative to the parent.", ( Texture )null );
        private GUIContent m_scaleContent = EditorGUIUtility.TrTextContent( "Scale", "The local scaling of this GameObject relative to the parent.", ( Texture )null );
        private GUIContent m_rotationContent = EditorGUIUtility.TrTextContent( "Rotation", "The local rotation of this GameObject relative to the parent.", ( Texture )null );
        private string m_floatingPointWarning = "Due to floating-point precision limitations, it is recommended to bring the world coordinates of the GameObject within a smaller range.";
        private Type[] m_emptyTypeArray = new Type[] { };

        private void OnEnable()
        {
            m_posProp = serializedObject.FindProperty( "m_LocalPosition" );
            m_rotProp = serializedObject.FindProperty( "m_LocalRotation" );
            m_scaleProp = serializedObject.FindProperty( "m_LocalScale" );

            if ( m_rotationGUIType == null )
            {
                var assembly = typeof( SerializedProperty ).Assembly;
                m_rotationGUIType = assembly.GetType( "UnityEditor.TransformRotationGUI" ); 
            }

            m_rotationGUI = Activator.CreateInstance( m_rotationGUIType );

            if ( m_rotationFieldMethod == null )
            {
                m_rotationFieldMethod = m_rotationGUIType.GetMethod( "RotationField", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, m_emptyTypeArray, null ); 
            }

            if ( m_rotationGUIEnableMethod == null )
            {
                m_rotationGUIEnableMethod = m_rotationGUIType.GetMethod( "OnEnable", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof( SerializedProperty ), typeof( GUIContent ) }, null ); 
            }
            m_rotationGUIEnableMethod.Invoke( m_rotationGUI, new object[] { m_rotProp, m_rotationContent }  );
        }

        private void DrawResettableProp( SerializedProperty property, GUIContent propContent, Vector3 resetValue, GUIContent buttonContent, GUIStyle buttonStyle )
        {
            GUILayout.BeginHorizontal();

            EditorGUILayout.PropertyField( property, propContent, true );

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

        private void DrawRotationProp( SerializedProperty property, GUIContent buttonContent, GUIStyle buttonStyle )
        {
            GUILayout.BeginHorizontal();

            m_rotationFieldMethod.Invoke( m_rotationGUI, m_emptyTypeArray );

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
