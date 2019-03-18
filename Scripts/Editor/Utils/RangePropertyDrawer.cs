using UnityEngine;
using UnityEditor;

namespace Atlas
{
    /// <summary>
    /// Handles inspector drawing for <see cref="Range"/>
    /// </summary>
    [CustomPropertyDrawer( typeof( Range ) )]
    public sealed class RangeDrawer : PropertyDrawer
    {
        public override void OnGUI( Rect position, SerializedProperty property, GUIContent label )
        {
            SerializedProperty minValueProperty = property.FindPropertyRelative( "m_minValue" );
            SerializedProperty maxValueProperty = property.FindPropertyRelative( "m_maxValue" );

            float labelWidth = EditorGUIUtility.labelWidth;
            float propertyWidth = ( position.width - c_horizontalSpacing - labelWidth ) * 0.5f;

            EditorGUI.BeginProperty( position, label, property );

            // draw label
            position.width = labelWidth;
            EditorGUI.LabelField( position, label );

            // recalc position
            EditorGUIUtility.labelWidth = propertyWidth * 0.4f;
            position.x += labelWidth;
            position.width = propertyWidth;

            // draw min property
            EditorGUI.BeginChangeCheck();
            EditorGUI.PropertyField( position, minValueProperty, new GUIContent( "Min" ) );
            if ( EditorGUI.EndChangeCheck() )
            {
                maxValueProperty.floatValue = Mathf.Max( minValueProperty.floatValue, maxValueProperty.floatValue );
            }
            
            position.x += position.width + c_horizontalSpacing;

            // draw max property
            EditorGUI.BeginChangeCheck();
            EditorGUI.PropertyField( position, maxValueProperty, new GUIContent( "Max" ) );
            if ( EditorGUI.EndChangeCheck() )
            {
                minValueProperty.floatValue = Mathf.Min( minValueProperty.floatValue, maxValueProperty.floatValue );
            }

            EditorGUI.EndProperty();
        }

        private const float c_horizontalSpacing = 5.0f;
    }
}
