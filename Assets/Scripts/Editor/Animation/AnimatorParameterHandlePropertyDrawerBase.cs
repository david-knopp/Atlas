using UnityEditor;
using UnityEngine;

namespace Atlas
{
    public abstract class AnimatorParameterHandlePropertyDrawerBase : PropertyDrawer
    {
        public override float GetPropertyHeight( SerializedProperty property, GUIContent label )
        {
            SerializedProperty nameProperty = property.FindPropertyRelative( "m_name" );
            return EditorGUI.GetPropertyHeight( nameProperty );
        }

        public override void OnGUI( Rect position, SerializedProperty property, GUIContent label )
        {
            SerializedProperty nameProperty = property.FindPropertyRelative( "m_name" );
            EditorGUI.PropertyField( position, nameProperty, label );
        }
    }
}
