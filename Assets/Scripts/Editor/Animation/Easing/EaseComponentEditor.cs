using UnityEditor;

namespace Atlas
{

    [CustomEditor( typeof( EaseComponent ), editorForChildClasses: true )]
    public sealed class EaseComponentEditor : MonoBehaviourEditor
    {
        public override void OnInspectorGUI()
        {
            serializedObject.Update();

            EditorGUI.BeginChangeCheck();

            var loopType = ( EaseComponent.LoopType )m_loopTypeProperty.intValue;

            foreach ( var prop in serializedObject.GetProperties() )
            {
                if ( prop.propertyPath == m_overrideReturnEasePath )
                {
                    if ( loopType != EaseComponent.LoopType.PingPong )
                    {
                        continue;
                    }
                }

                if ( prop.propertyPath == m_returnEasePath )
                {
                    if ( loopType != EaseComponent.LoopType.PingPong ||
                         m_overrideReturnEaseProperty.boolValue == false )
                    {
                        continue;
                    }
                }

                using ( new EditorGUI.DisabledScope( prop.propertyPath == "m_Script" ) )
                {
                    EditorGUILayout.PropertyField( prop );
                }
            }

            if ( EditorGUI.EndChangeCheck() )
            {
                serializedObject.ApplyModifiedProperties();
            }

            EditorGUILayout.Space();

            DrawAttributeButtons();
        }

        private const string m_loopTypePath = "m_loopType";
        private const string m_overrideReturnEasePath = "m_overrideReturnEase";
        private const string m_returnEasePath = "m_returnEase";

        private SerializedProperty m_loopTypeProperty;
        private SerializedProperty m_overrideReturnEaseProperty;

        private void OnEnable()
        {
            m_loopTypeProperty = serializedObject.FindProperty( m_loopTypePath );
            m_overrideReturnEaseProperty = serializedObject.FindProperty( m_overrideReturnEasePath );
        }
    }
}
