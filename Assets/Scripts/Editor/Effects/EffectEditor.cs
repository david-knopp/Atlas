using UnityEditor;

namespace Atlas
{
    [CustomEditor( typeof( Effect ) )]
    public sealed class EffectEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            serializedObject.Update();

            EditorGUILayout.PropertyField( m_activationEventProperty );
            EditorGUILayout.PropertyField( m_destructionEventProperty );

            var descructionEvent = ( Effect.DestructionEventType )m_destructionEventProperty.intValue;
            if ( descructionEvent == Effect.DestructionEventType.Timed )
            {
                EditorGUILayout.PropertyField( m_lifetimeProperty );
            }

            serializedObject.ApplyModifiedProperties();
        }

        private SerializedProperty m_activationEventProperty;
        private SerializedProperty m_destructionEventProperty;
        private SerializedProperty m_lifetimeProperty;

        private void OnEnable()
        {
            m_activationEventProperty = serializedObject.FindProperty( "m_activationEvent" );
            m_destructionEventProperty = serializedObject.FindProperty( "m_destructionEvent" );
            m_lifetimeProperty = serializedObject.FindProperty( "m_lifetimeSeconds" );
        }
    }
}
