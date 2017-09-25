using UnityEngine;

namespace Atlas
{
    public class MinValueAttribute : PropertyAttribute
    {
        public MinValueAttribute( float minValue )
        {
            m_minValue = minValue;
        }

        public float MinValue { get { return m_minValue; } }

        private float m_minValue;
    }
}