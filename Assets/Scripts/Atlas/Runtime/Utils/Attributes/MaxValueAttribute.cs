using UnityEngine;

namespace Atlas
{
    public sealed class MaxValueAttribute : PropertyAttribute
    {
        public MaxValueAttribute( float maxValue )
        {
            MaxValue = maxValue;
        }

        public float MaxValue { get; private set; }
    }
}