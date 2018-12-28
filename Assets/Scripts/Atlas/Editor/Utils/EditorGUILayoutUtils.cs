using UnityEditor;
using UnityEngine;

namespace Atlas
{
    public static class EditorGUILayoutUtils
    {
        public static void HorizontalLine( float height = 1f )
        {
            HorizontalLine( Color.gray, height );
        }

        public static void HorizontalLine( Color color, float height = 1f )
        {
            Rect rect = EditorGUILayout.GetControlRect( false, height );
            rect.height = height;
            EditorGUI.DrawRect( rect, color );
        }
    }
}