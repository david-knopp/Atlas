using System;
using UnityEngine;

namespace Atlas
{
    [Serializable]
    public struct Range
    {
        public float m_minValue;
        public float m_maxValue;

        public float GetRandomValue()
        {
            return UnityEngine.Random.Range( m_minValue, m_maxValue );
        }

        public float GetLerpedValue( float t )
        {
            return Mathf.Lerp( m_minValue, m_maxValue, Mathf.Clamp01( t ) );
        }

        public bool Contains( float value )
        {
            return value >= m_minValue && value <= m_maxValue;
        }

        public float Clamp( float value )
        {
            return Mathf.Clamp( value, m_minValue, m_maxValue );
        }
    }
}