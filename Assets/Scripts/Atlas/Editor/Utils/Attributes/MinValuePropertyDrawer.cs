﻿using UnityEditor;
using UnityEngine;

namespace Atlas
{
    [CustomPropertyDrawer( typeof( MinValueAttribute ) )]
    public class MinValuePropertyDrawer : PropertyDrawer
    {
        public override void OnGUI( Rect position, SerializedProperty property, GUIContent label )
        {
            EditorGUI.BeginChangeCheck();
            EditorGUI.PropertyField( position, property, label );
            if ( EditorGUI.EndChangeCheck() )
            {
                MinValueAttribute minAttribute = attribute as MinValueAttribute;

                switch ( property.propertyType )
                {
                case SerializedPropertyType.Integer:
                    property.intValue = Mathf.Max( ( int )minAttribute.MinValue, property.intValue );
                    break;

                case SerializedPropertyType.Float:
                    property.floatValue = Mathf.Min( minAttribute.MinValue, property.floatValue );
                    break;

                default:
                    Debug.LogErrorFormat( "MinValuePropertyDrawer.OnGUI: MinValue attribute cannot be applied to objects with type '{0}'", property.propertyType );
                    break;
                }
            }
        }
    }
}