using System;
using UnityEngine;

namespace Atlas
{
    /// <summary>
    /// Represents a closed mathematical interval of integer values
    /// </summary>
    [Serializable]
    public struct RangeInt
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="minValue">Minimum value of the range (inclusive)</param>
        /// <param name="maxValue">Maximum value of the range (inclusive)</param>
        public RangeInt( int minValue, int maxValue )
        {
            m_minValue = Mathf.Min( minValue, maxValue );
            m_maxValue = Mathf.Max( minValue, maxValue );
        }

        /// <summary>
        /// The minimum value of the range (inclusive)
        /// </summary>
        public int MinValue => m_minValue;

        /// <summary>
        /// The maximum value of the range (inclusive)
        /// </summary>
        public int MaxValue => m_maxValue;

        /// <summary>
        /// Represents the difference between the minimum and maximum values
        /// </summary>
        public int Length => Mathf.Max( MaxValue - MinValue, 0 );

        /// <summary>
        /// Sets the range with the given values. If minValue > maxValue, the values will be swapped
        /// so the Range's MinValue and MaxValue are preserved
        /// </summary>
        /// <param name="minValue">The smallest inclusive value for the range</param>
        /// <param name="maxValue">The largest inclusive value for the range</param>
        public void Set( int minValue, int maxValue )
        {
            if ( minValue < maxValue )
            {
                m_minValue = minValue;
                m_maxValue = maxValue;
            }
            else
            {
                m_maxValue = minValue;
                m_minValue = maxValue;
            }
        }

        /// <summary>
        /// Returns a random number between <see cref="MinValue"/> (inclusive) and <see cref="MaxValue"/>
        /// </summary>
        /// <param name="isMaxExclusive">If true, the maximum returned value will be <see cref="MaxValue"/> - 1.
        /// Otherwise, it will <see cref="MaxValue"/></param>
        /// <returns>A random value within the range</returns>
        public int GetRandomValue( bool isMaxExclusive = true )
        {
            if ( isMaxExclusive )
            {
                return UnityEngine.Random.Range( MinValue, MaxValue );
            }
            else
            {
                return UnityEngine.Random.Range( MinValue, MaxValue + 1 );
            }
        }

        /// <summary>
        /// Returns a linearly interpolated value between <see cref="MinValue"/> and <see cref="MaxValue"/>
        /// where an input <paramref name="t"/> of 0 will return <see cref="MinValue"/>, and an input of 1 will
        /// return <see cref="MaxValue"/>
        /// </summary>
        /// <param name="t">The value to interpulate normalized to [0, 1]</param>
        /// <returns>The linearly interpolated value</returns>
        public int GetLerpedValue( float t )
        {
            return Mathf.RoundToInt( Mathf.Lerp( MinValue, MaxValue, Mathf.Clamp01( t ) ) );
        }

        /// <summary>
        /// Calculates a value representing the normalized position of the provided <paramref name="value"/> 
        /// within the range, clamped to [0, 1]
        /// </summary>
        /// <param name="value">The value to normalize</param>
        /// <returns>The normalized value</returns>
        public float GetNormalizedValue( int value )
        {
            // special case for if the range represents a single point
            if ( MaxValue == MinValue )
            {
                if ( value == MaxValue )
                {
                    return 1f;
                }

                return 0f;
            }

            float normalizedValue = ( value - MinValue ) / ( float )( MaxValue - MinValue );
            return Mathf.Clamp01( normalizedValue );
        }

        /// <summary>
        /// Determines whether or not the given <paramref name="value"/> is within this numerical range (inclusive)
        /// </summary>
        /// <param name="value">The value to determine</param>
        /// <returns>Whether or not the value is within the range</returns>
        public bool Contains( int value )
        {
            return value >= MinValue && value <= MaxValue;
        }

        /// <summary>
        /// Determines whether or not the given <paramref name="range"/> value is contained within this
        /// numerical range (inclusive)
        /// </summary>
        /// <param name="range">The range value to determine</param>
        /// <returns>Whether or not the range value is contained</returns>
        public bool Contains( RangeInt range )
        {
            return Contains( range.MinValue ) &&
                   Contains( range.MaxValue );
        }

        /// <summary>
        /// Determines whether or not the given <paramref name="range"/> value overlaps this range
        /// </summary>
        /// <param name="range">The range value to test</param>
        /// <returns>Whether or not the ranges overlap eachother</returns>
        public bool Intersects( RangeInt range )
        {
            return MinValue <= range.MaxValue &&
                   MaxValue >= range.MinValue;
        }

        /// <summary>
        /// Clamps the given <paramref name="value"/> between the range
        /// </summary>
        /// <param name="value">The value to clamp</param>
        /// <returns>If the value is within the range, the value is returned unchanged. Otherwise, a value clamped
        /// to the range limits is returned.</returns>
        public int Clamp( int value )
        {
            return Mathf.Clamp( value, MinValue, MaxValue );
        }

        /// <summary>
        /// Combines the range with the given <paramref name="range"/>, growing the range
        /// to span both ranges
        /// </summary>
        /// <param name="range">The range to encapsulate</param>
        /// <returns>The combined range</returns>
        public RangeInt Encapsulate( RangeInt range )
        {
            return new RangeInt( Mathf.Min( MinValue, range.MinValue ),
                                 Mathf.Max( MaxValue, range.MaxValue ) );
        }

        /// <summary>
        /// Calculates the range of values where this range overlaps with the given <paramref name="range"/>.
        /// If the ranges don't overlap, an invalid range is returned.
        /// </summary>
        /// <param name="range">The range to intersect with</param>
        /// <returns>The intersecting range</returns>
        public RangeInt IntersectionWith( RangeInt range )
        {
            if ( Intersects( range ) )
            {
                return new RangeInt( Mathf.Max( MinValue, range.MinValue ),
                                     Mathf.Min( MaxValue, range.MaxValue ) );
            }

            // no intersection
            return default;
        }

        [SerializeField] private int m_minValue;
        [SerializeField] private int m_maxValue;
    }
}
