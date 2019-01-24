using System;
using UnityEngine;

namespace Atlas
{
    /// <summary>
    /// Sets a minimum value for the target field. 
    /// Automatically prevents assigning a value less than the specified 
    /// value when editing the field in the inspector window
    /// </summary>
    /// <seealso cref="MaxValueAttribute"/>
    [AttributeUsage( AttributeTargets.Field, AllowMultiple = false )]
    public sealed class MinValueAttribute : PropertyAttribute
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="minValue">The minimum allowable value the field can have</param>
        public MinValueAttribute( float minValue )
        {
            MinValue = minValue;
        }

        /// <summary>
        /// The minimum allowable value the field can have
        /// </summary>
        public float MinValue { get; private set; }
    }
}