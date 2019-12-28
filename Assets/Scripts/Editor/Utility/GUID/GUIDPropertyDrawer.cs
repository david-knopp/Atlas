using UnityEditor;
using UnityEngine;

namespace Atlas
{
    [CustomPropertyDrawer( typeof ( GUID ) )]
    public sealed class GUIDPropertyDrawer : PropertyDrawer
    {
        public override void OnGUI( Rect position, SerializedProperty property, GUIContent label )
        {
            GUID guid = ( GUID )fieldInfo.GetValue( property.serializedObject.targetObject );

            using ( new EditorGUI.DisabledScope( true ) )
            {
                EditorGUI.TextField( position, label, guid.Value.ToString() );
            }
        }
    }
}
