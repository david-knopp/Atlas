using UnityEditor;
using UnityEngine;

namespace Atlas
{
    [CustomPropertyDrawer( typeof( PreventEditInInspectorAttribute ) )]
    public sealed class PreventEditInInspectorPropertyDrawer : PropertyDrawer
    {
        public override void OnGUI( Rect position, SerializedProperty property, GUIContent label )
        {
            GUI.enabled = false;
            EditorGUI.PropertyField( position, property, label );
            GUI.enabled = true;
        }
    }
}