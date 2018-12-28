using UnityEditor;
using UnityEngine;

namespace Atlas
{
    public static class EditorGUILayoutUtils
    {
        public static void HorizontalLine( float height = 1f, float widthPct = 1f )
        {
            HorizontalLine( Color.gray, height, widthPct );
        }

        public static void HorizontalLine( Color color, float height = 1f, float widthPct = 1f )
        {
            Rect rect = EditorGUILayout.GetControlRect( false );
            rect.height = height;

            float targetWidth = rect.width * widthPct;
            rect.x += ( rect.width - targetWidth ) * 0.5f;
            rect.width = targetWidth;

            EditorGUI.DrawRect( rect, color );
        }

        public static void RichLabelField( string label )
        {
            GUIStyle richStyle = EditorStyles.label;
            richStyle.richText = true;
            EditorGUILayout.LabelField( label, richStyle );
        }
    }
}