using UnityEngine;
using UnityEditor;

namespace Atlas
{
    /// <summary>
    /// Handles inspector drawing for <see cref="Range"/>
    /// </summary>
    [CustomPropertyDrawer( typeof( RangeInt ) )]
    public sealed class RangeIntDrawer : PropertyDrawer
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
                maxValueProperty.intValue = Mathf.Max( minValueProperty.intValue, maxValueProperty.intValue );
            }

            position.x += position.width + c_horizontalSpacing;

            // draw max property
            EditorGUI.BeginChangeCheck();
            EditorGUI.PropertyField( position, maxValueProperty, new GUIContent( "Max" ) );
            if ( EditorGUI.EndChangeCheck() )
            {
                minValueProperty.intValue = Mathf.Min( minValueProperty.intValue, maxValueProperty.intValue );
            }

            EditorGUI.EndProperty();
        }

        private const float c_horizontalSpacing = 5.0f;
    }
}
