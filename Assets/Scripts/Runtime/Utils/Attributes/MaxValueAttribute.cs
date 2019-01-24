using System;
using UnityEngine;

namespace Atlas
{
    /// <summary>
    /// Sets a maximum value for the target field. 
    /// Automatically prevents assigning a value greater than the specified 
    /// value when editing the field in the inspector window
    /// </summary>
    /// <seealso cref="MinValueAttribute"/>
    [AttributeUsage( AttributeTargets.Field, AllowMultiple = false )]
    public sealed class MaxValueAttribute : PropertyAttribute
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="maxValue">The maximum allowable value the field can have</param>
        public MaxValueAttribute( float maxValue )
        {
            MaxValue = maxValue;
        }

        /// <summary>
        /// The maximum allowable value the field can have
        /// </summary>
        public float MaxValue { get; private set; }
    }
}