using UnityEngine;

namespace Atlas
{
    public class MaxValueAttribute : PropertyAttribute
    {
        public MaxValueAttribute( float maxValue )
        {
            m_maxValue = maxValue;
        }

        public float MaxValue { get { return m_maxValue; } }

        private float m_maxValue;
    }
}