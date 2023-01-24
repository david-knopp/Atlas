using UnityEditor;
using UnityEngine;

namespace Atlas
{
    /// <summary>
    /// Handles inspector drawing for <see cref="PreventEditInPlayModeAttribute"/>
    /// </summary>
    [CustomPropertyDrawer( typeof( PreventEditInPlayModeAttribute ) )]
    public sealed class PreventEditInPlayModePropertyDrawer : PropertyDrawer
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
