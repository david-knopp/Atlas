using UnityEditor;
using UnityEngine;

namespace Atlas
{
    [CustomPropertyDrawer( typeof( Ease ) )]
    public sealed class EasePropertyDrawer : PropertyDrawer
    {
        public override float GetPropertyHeight( SerializedProperty property, GUIContent label )
        {
            return EditorGUIUtility.singleLineHeight;
        }

        public override void OnGUI( Rect position, SerializedProperty property, GUIContent label )
        {
            var typeProperty = property.FindPropertyRelative( "m_type" );
            EditorGUI.PropertyField( position, typeProperty, label );
        }
    }
}
