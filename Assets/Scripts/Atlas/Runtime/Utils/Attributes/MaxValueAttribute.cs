using System;
using UnityEngine;

namespace Atlas
{
    [AttributeUsage( AttributeTargets.Field, AllowMultiple = false )]
    public sealed class MaxValueAttribute : PropertyAttribute
    {
        public MaxValueAttribute( float maxValue )
        {
            MaxValue = maxValue;
        }

        public float MaxValue { get; private set; }
    }
}