using UnityEditor;
using UnityEngine;

namespace Atlas
{
    /// <summary>
    /// Handles inspector drawing for <see cref="MaxValueAttribute"/>
    /// </summary>
    [CustomPropertyDrawer( typeof( MaxValueAttribute ) )]
    public sealed class MaxValuePropertyDrawer : PropertyDrawer
    {
        public override void OnGUI( Rect position, SerializedProperty property, GUIContent label )
        {
            EditorGUI.BeginChangeCheck();
            EditorGUI.PropertyField( position, property, label );
            if ( EditorGUI.EndChangeCheck() )
            {
                MaxValueAttribute minAttribute = attribute as MaxValueAttribute;

                switch ( property.propertyType )
                {
                case SerializedPropertyType.Integer:
                    property.intValue = Mathf.Min( ( int )minAttribute.MaxValue, property.intValue );
                    break;

                case SerializedPropertyType.Float:
                    property.floatValue = Mathf.Min( minAttribute.MaxValue, property.floatValue );
                    break;

                default:
                    Debug.LogErrorFormat( "MaxValuePropertyDrawer.OnGUI: MaxValue attribute cannot be applied to objects with type '{0}'", property.propertyType );
                    break;
                }
            }
        }
    }
}