using System;
using UnityEngine;

namespace Atlas
{
    [AttributeUsage( AttributeTargets.Field, AllowMultiple = false )]
    public sealed class MinValueAttribute : PropertyAttribute
    {
        public MinValueAttribute( float minValue )
        {
            MinValue = minValue;
        }

        public float MinValue { get; private set; }
    }
}