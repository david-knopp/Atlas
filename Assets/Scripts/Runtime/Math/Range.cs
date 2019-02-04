using System;
using UnityEngine;

namespace Atlas
{
    /// <summary>
    /// Represents a closed mathematical interval of float values
    /// </summary>
    [Serializable]
    public struct Range
    {
        /// <summary>
        /// The minimum value of the range (inclusive)
        /// </summary>
        public float m_minValue;

        /// <summary>
        /// The maximum value of the range (inclusive)
        /// </summary>
        public float m_maxValue;

        /// <summary>
        /// Returns a random number between <see cref="m_minValue"/> (inclusive) and <see cref="m_maxValue"/> (inclusive)
        /// </summary>
        /// <returns>A random value within the range</returns>
        public float GetRandomValue()
        {
            return UnityEngine.Random.Range( m_minValue, m_maxValue );
        }

        /// <summary>
        /// Returns a linearly interpolated value between <see cref="m_minValue"/> and <see cref="m_maxValue"/>
        /// where an input <param name="t"> of 0 will return <see cref="m_minValue"/>, and an input of 1 will
        /// return <see cref="m_maxValue"/>
        /// </summary>
        /// <param name="t">The value to interpulate normalized to [0, 1]</param>
        /// <returns>The linearly interpolated value</returns>
        public float GetLerpedValue( float t )
        {
            return Mathf.Lerp( m_minValue, m_maxValue, Mathf.Clamp01( t ) );
        }

        /// <summary>
        /// Calculates a value representing the normalized position of the provided <paramref name="value"/> 
        /// within the range, clamped to [0, 1]
        /// </summary>
        /// <param name="value">The value to normalize</param>
        /// <returns>The normalized value</returns>
        public float GetNormalizedValue( float value )
        {

            // special case for if the range represents a single point
            if ( m_maxValue == m_minValue )
            {
                if ( value == m_maxValue )
                {
                    return 1f;
                }

                return 0f;
            }

            float normalizedValue = ( value - m_minValue ) / ( m_maxValue - m_minValue );
            return Mathf.Clamp01( normalizedValue );
        }

        /// <summary>
        /// Determines whether or not the given <paramref name="value"/> is within this numerical range (inclusive)
        /// </summary>
        /// <param name="value">The value to determine</param>
        /// <returns>Whether or not the value is within the range</returns>
        public bool Contains( float value )
        {
            return value >= m_minValue && value <= m_maxValue;
        }

        /// <summary>
        /// Determines whether or not the given <paramref name="range"/> value is contained within this
        /// numerical range (inclusive)
        /// </summary>
        /// <param name="range">The range value to determine</param>
        /// <returns>Whether or not the range value is contained</returns>
        public bool Contains( Range range )
        {
            return Contains( range.m_minValue ) &&
                   Contains( range.m_maxValue );
        }

        /// <summary>
        /// Clamps the given <paramref name="value"/> between the range
        /// </summary>
        /// <param name="value">The value to clamp</param>
        /// <returns>If the value is within the range, the value is returned unchanged. Otherwise, a value clamped
        /// to the range limits is returned.</returns>
        public float Clamp( float value )
        {
            return Mathf.Clamp( value, m_minValue, m_maxValue );
        }

        /// <summary>
        /// Combines the range with the given <paramref name="range"/> into a mathematical union, creating
        /// a range that spans both ranges
        /// </summary>
        /// <param name="range">The range to union with</param>
        /// <returns>The combined range</returns>
        public Range UnionWith( Range range )
        {
            return new Range()
            {
                m_minValue = Mathf.Min( m_minValue, range.m_minValue ),
                m_maxValue = Mathf.Max( m_maxValue, range.m_maxValue )
            };
        }
    }
}