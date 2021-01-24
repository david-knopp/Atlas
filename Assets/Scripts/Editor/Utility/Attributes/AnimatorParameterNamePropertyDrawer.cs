using System;
using System.Linq;
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
            Animator animator = GetAnimator( property );
            if ( animator != null )
            {
                var parameters = GetSelectableParameters( ParamAttribute, animator );
                int selectedIndex = Array.FindIndex( parameters, 0, x => x.name == property.stringValue );

                if ( selectedIndex < 0 )
                {
                    return base.GetPropertyHeight( property, label ) * 2 + EditorGUIUtility.standardVerticalSpacing;
                }
            }

            return base.GetPropertyHeight( property, label );
        }

        public override void OnGUI( Rect position, SerializedProperty property, GUIContent label )
        {
            if ( property.propertyType != SerializedPropertyType.String )
            {
                EditorGUI.PropertyField( position, property, label );
                return;
            }

            position.height = EditorGUIUtility.singleLineHeight;

            Animator animator = GetAnimator( property );
            if ( animator != null )
            {
                ;
                // get popup labels
                var parameters = GetSelectableParameters( ParamAttribute, animator );
                var parameterNames = parameters.Select( x => x.name ).ToArray();
                int selectedIndex = Array.IndexOf( parameterNames, property.stringValue );
                var popupLabels = parameters.Select( GetParameterLabel ).ToList();
                popupLabels.Add( new GUIContent( "Other..." ) );

                if ( selectedIndex < 0 )
                {
                    selectedIndex = popupLabels.Count - 1;
                }

                // show popup
                EditorGUI.BeginChangeCheck();

                selectedIndex = EditorGUI.Popup( position, label, selectedIndex, popupLabels.ToArray() );

                if ( EditorGUI.EndChangeCheck() )
                {
                    if ( selectedIndex < parameterNames.Length )
                    {
                        property.stringValue = parameterNames[selectedIndex];
                    }
                    else
                    {
                        property.stringValue = null;
                    }
                }

                // show manual input field for "other" option
                if ( selectedIndex == popupLabels.Count - 1 )
                {
                    position.y += position.height + EditorGUIUtility.standardVerticalSpacing;

                    property.stringValue = EditorGUI.TextField( position, " ", property.stringValue );
                }
            }
            else
            {
                EditorGUI.PropertyField( position, property, label );
            }
        }

        private Animator Animator { get; set; }

        private AnimatorParameterNameAttribute ParamAttribute => attribute as AnimatorParameterNameAttribute;

        private Animator GetAnimator( SerializedProperty property )
        {
            // use cached animator reference
            if ( Animator != null )
            {
                return Animator;
            }

            // try fetching animator
            MonoBehaviour parentBehavior = property.serializedObject.targetObject as MonoBehaviour;

            switch ( ParamAttribute.TargetAnimatorSource )
            {
                case AnimatorParameterNameAttribute.AnimatorSource.Children:
                    Animator = parentBehavior?.GetComponentInChildren<Animator>();
                    break;

                case AnimatorParameterNameAttribute.AnimatorSource.Parents:
                    Animator = parentBehavior?.GetComponentInParent<Animator>();
                    break;

                case AnimatorParameterNameAttribute.AnimatorSource.ThisObject:
                    Animator = parentBehavior?.GetComponent<Animator>();
                    break;
            }

            return Animator;
        }

        private AnimatorControllerParameter[] GetSelectableParameters( AnimatorParameterNameAttribute attribute, Animator animator )
        {
            AnimatorController controller = animator.runtimeAnimatorController as AnimatorController;

            if ( attribute.ParameterTypeFilter.HasValue )
            {
                return controller.parameters.Where( x => x.type == attribute.ParameterTypeFilter.Value ).ToArray();
            }

            return controller.parameters;
        }

        private GUIContent GetParameterLabel( AnimatorControllerParameter parameter )
        {
            switch ( ParamAttribute.TypeDisplay )
            {
                case AnimatorParameterNameAttribute.ParameterTypeDisplay.Show:
                    return new GUIContent( $"{parameter.name} ({parameter.type})" );

                default:
                    return new GUIContent( parameter.name );
            }
        }
    }
}
