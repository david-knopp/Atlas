using UnityEditor;
using UnityEngine;

namespace Atlas
{
    /// <summary>
    /// Handles inspector drawing for <see cref="PreventEditInEditModeAttribute"/>
    /// </summary>
    [CustomPropertyDrawer( typeof( PreventEditInEditModeAttribute ) )]
    public sealed class PreventEditInEditModePropertyDrawer : PropertyDrawer
    {
        public override void OnGUI( Rect position, SerializedProperty property, GUIContent label )
        {
            using ( new EditorGUI.DisabledScope( Application.isPlaying ) )
            {
                EditorGUI.PropertyField( position, property, label );
            }
        }
    }
}
