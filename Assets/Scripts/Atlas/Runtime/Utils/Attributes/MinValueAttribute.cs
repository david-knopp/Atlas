using UnityEngine;

namespace Atlas
{
    public sealed class MinValueAttribute : PropertyAttribute
    {
        public MinValueAttribute( float minValue )
        {
            MinValue = minValue;
        }

        public float MinValue { get; private set; }
    }
}