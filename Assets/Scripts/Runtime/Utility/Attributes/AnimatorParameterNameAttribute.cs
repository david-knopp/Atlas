using System;
using UnityEngine;

namespace Atlas
{
    [AttributeUsage( AttributeTargets.Field, AllowMultiple = false )]
    public sealed class AnimatorParameterNameAttribute : PropertyAttribute
    {
        /// <summary>
        /// Component search location relative to the MonoBehaviour serializing the target
        /// </summary>
        public enum AnimatorSource
        { 
            Children = 0,
            Parents = 1,
            ThisObject = 2
        }

        /// <summary>
        /// Options for showing/hiding parameter type when displaying parameter names
        /// </summary>
        public enum ParameterTypeDisplay
        {
            Show = 0,
            Hide = 1
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="animatorSource">GameObject-relative source location to extract the Animator from</param>
        /// <param name="typeDisplay">Controls whether or not the parameter type is shown next to its name in the inspector</param>
        public AnimatorParameterNameAttribute( AnimatorSource animatorSource = AnimatorSource.Children,
            ParameterTypeDisplay typeDisplay = ParameterTypeDisplay.Show )
        {
            TargetAnimatorSource = animatorSource;
            ParameterTypeFilter = null;
            TypeDisplay = typeDisplay;
        }

        /// <summary>
        /// Contructor
        /// </summary>
        /// <param name="parameterTypeFilter">Type to filter displayed parameters by</param>
        /// <param name="animatorSource">GameObject-relative source location to extract the Animator from</param>
        public AnimatorParameterNameAttribute( AnimatorControllerParameterType parameterTypeFilter,
            AnimatorSource animatorSource = AnimatorSource.Children )
        {
            TargetAnimatorSource = animatorSource;
            ParameterTypeFilter = parameterTypeFilter;
            TypeDisplay = ParameterTypeDisplay.Hide;
        }

        /// <summary>
        /// GameObject-relative source location to get the target Animator from
        /// </summary>
        public AnimatorSource TargetAnimatorSource { get; }

        /// <summary>
        /// Optional filter for displaying Animator controller parameters of only a given type
        /// </summary>
        public AnimatorControllerParameterType? ParameterTypeFilter { get; }

        /// <summary>
        /// Options for displaying the type of a parameter next to its name in the inspector
        /// </summary>
        public ParameterTypeDisplay TypeDisplay { get; }
    }
}
