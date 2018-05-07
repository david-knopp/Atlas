using System;

namespace Atlas
{
    [Serializable]
    public struct Range
    {
        public float m_minValue;
        public float m_maxValue;

        public float GetRandom()
        {
            return UnityEngine.Random.Range( m_minValue, m_maxValue );
        }

        public bool Contains( float value )
        {
            return value >= m_minValue && value <= m_maxValue;
        }
    }
}