using System;
using UnityEngine;

namespace Atlas
{
    [AttributeUsage( AttributeTargets.Field, AllowMultiple = false )]
    public sealed class AnimatorParameterNameAttribute : PropertyAttribute
    {
        /// <summary>
        /// Options for displaying parameters categorized by their type when displaying popup menu
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
        public AnimatorParameterNameAttribute( ParameterTypeDisplay typeDisplay = ParameterTypeDisplay.Show )
        {
            ParameterTypeFilter = null;
            TypeDisplay = typeDisplay;
        }

        /// <summary>
        /// Contructor
        /// </summary>
        /// <param name="parameterTypeFilter">Type to filter displayed parameters by</param>
        /// <param name="animatorSource">GameObject-relative source location to extract the Animator from</param>
        public AnimatorParameterNameAttribute( AnimatorControllerParameterType parameterTypeFilter )
        {
            ParameterTypeFilter = parameterTypeFilter;
            TypeDisplay = ParameterTypeDisplay.Hide;
        }

        /// <summary>
        /// Optional filter for displaying Animator controller parameters of only a given type
        /// </summary>
        public AnimatorControllerParameterType? ParameterTypeFilter { get; }

        /// <summary>
        /// Options for displaying parameters categorized by their type when displaying popup menu
        /// </summary>
        public ParameterTypeDisplay TypeDisplay { get; }
    }
}
