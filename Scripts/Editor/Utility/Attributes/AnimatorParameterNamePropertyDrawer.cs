using System;
using System.Collections.Generic;
using System.Net;
using UnityEditor;
using UnityEditor.Animations;
using UnityEngine;

namespace Atlas
{
    [CustomPropertyDrawer( typeof( AnimatorParameterNameAttribute ) )]
    public sealed class AnimatorParameterNamePropertyDrawer : PropertyDrawer
    {
        public override float GetPropertyHeight( SerializedProperty property, GUIContent label )
        {
            m_hasMatchedTriggerName = false;

            IterateAnimators( property, animator =>
            {
                if ( m_hasMatchedTriggerName )
                {
                    return;
                }

                IterateParameters( animator, parameter =>
                {
                    if ( parameter.name == property.stringValue )
                    {
                        m_hasMatchedTriggerName = true;
                    }
                } );
            } );

            if ( m_hasMatchedTriggerName == false )
            {
                return EditorGUIUtility.singleLineHeight * 2f + EditorGUIUtility.standardVerticalSpacing;
            }
            else
            {
                return EditorGUIUtility.singleLineHeight;
            }
        }

        public override void OnGUI( Rect position, SerializedProperty property, GUIContent label )
        {
            position.height = EditorGUIUtility.singleLineHeight;

            float dropdownXOffset = position.x + EditorGUIUtility.labelWidth;
            float dropdownWidth = position.width - EditorGUIUtility.labelWidth;

            // draw animator parameter name popup field
            if ( EditorGUI.Toggle( position, label, false, EditorStyles.popup ) )
            {
                GenericMenu menu = new GenericMenu();

                IterateAnimators( property, controller =>
                {
                    IterateParameters( controller, parameter =>
                    {
                        menu.AddItem( GetParameterMenuContent( controller, parameter ),
                            property.stringValue == parameter.name,
                            () =>
                            {
                                property.stringValue = parameter.name;
                                property.serializedObject.ApplyModifiedProperties();
                            } );
                    } );
                } );

                menu.AddSeparator( "" );
                menu.AddItem( s_otherGUIContent, m_hasMatchedTriggerName == false, () =>
                {
                    property.stringValue = string.Empty;
                    property.serializedObject.ApplyModifiedProperties();
                } );

                menu.DropDown( new Rect( dropdownXOffset, position.y, dropdownWidth, position.height ) );
            }

            // render parameter name
            GUIContent selectedParamContent;

            if ( m_hasMatchedTriggerName )
            {
                selectedParamContent = new GUIContent( property.stringValue );
            }
            else
            {
                selectedParamContent = s_otherGUIContent;
            }

            Rect selectedParamPosition = new Rect( dropdownXOffset + 4, position.y, dropdownWidth - 18, position.height );
            GUI.Label( selectedParamPosition, selectedParamContent );

            if ( m_hasMatchedTriggerName == false )
            {
                position.y += position.height + EditorGUIUtility.standardVerticalSpacing;
                EditorGUI.PropertyField( position, property, new GUIContent( " " ) );
            }
        }

        private AnimatorParameterNameAttribute NameAttribute => attribute as AnimatorParameterNameAttribute;

        private bool m_hasMatchedTriggerName = false;
        private static readonly GUIContent s_otherGUIContent = new GUIContent( "Other..." );

        private void IterateAnimators( SerializedProperty property, Action<AnimatorController> controllerCallback )
        {
            HashSet<AnimatorController> controllers = new HashSet<AnimatorController>();

            void TryInvokeCallback( Animator animator )
            {
                RuntimeAnimatorController runtimeController = null;

                if ( animator.runtimeAnimatorController is AnimatorOverrideController overrideController )
                {
                    runtimeController = overrideController.runtimeAnimatorController;
                }
                else
                {
                    runtimeController = animator.runtimeAnimatorController;
                }

                AnimatorController controller = runtimeController as AnimatorController;

                // only visit an controller once
                if ( controllers.Add( controller ) )
                {
                    controllerCallback( controller );
                }
            }

            // fetch any animators referenced as a serialized sibling field
            SerializedProperty objectIterator = property.serializedObject.GetIterator();
            while ( objectIterator.Next( enterChildren: true ) )
            {
                if ( objectIterator.propertyType == SerializedPropertyType.ObjectReference &&
                     objectIterator.objectReferenceValue is Animator animator )
                {
                    TryInvokeCallback( animator );
                }
            }

            // fetch any animators from hierarchy
            MonoBehaviour targetBehavior = property.serializedObject.targetObject as MonoBehaviour;
            if ( targetBehavior != null )
            {
                // children
                foreach ( Animator animator in targetBehavior.GetComponentsInChildren<Animator>() )
                {
                    TryInvokeCallback( animator );
                }

                // parents
                foreach ( Animator animator in targetBehavior.GetComponentsInParent<Animator>() )
                {
                    TryInvokeCallback( animator );
                }
            }
        }

        private void IterateParameters( AnimatorController controller,
            Action<AnimatorControllerParameter> parameterCallback )
        {
            if ( controller == null )
            {
                return;
            }

            foreach ( AnimatorControllerParameter parameter in controller.parameters )
            {
                if ( NameAttribute.ParameterTypeFilter.HasValue == false ||
                     NameAttribute.ParameterTypeFilter.Value == parameter.type )
                {
                    parameterCallback( parameter );
                }
            }
        }

        private GUIContent GetParameterMenuContent( AnimatorController controller, AnimatorControllerParameter parameter )
        {
            if ( NameAttribute.TypeDisplay == AnimatorParameterNameAttribute.ParameterTypeDisplay.Show )
            {
                return new GUIContent( $"{controller.name}/{parameter.type}s/{parameter.name}" );
            }

            return new GUIContent( $"{controller.name}/{parameter.name}" );
        }
    }
}
