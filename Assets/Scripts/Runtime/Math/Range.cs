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
        /// Constructor
        /// </summary>
        /// <param name="minValue">Minimum value of the range (inclusive)</param>
        /// <param name="maxValue">Maximum value of the range (inclusive)</param>
        public Range( float minValue, float maxValue )
        {
            MinValue = minValue;
            MaxValue = maxValue;
        }

        /// <summary>
        /// The minimum value of the range (inclusive)
        /// </summary>
        public float MinValue;

        /// <summary>
        /// The maximum value of the range (inclusive)
        /// </summary>
        public float MaxValue;

        /// <summary>
        /// Represents the difference between the minimum and maximum values
        /// </summary>
        public float Length => Mathf.Max( MaxValue - MinValue, 0f );

        /// <summary>
        /// Returns a random number between <see cref="MinValue"/> (inclusive) and <see cref="MaxValue"/> (inclusive)
        /// </summary>
        /// <returns>A random value within the range</returns>
        public float GetRandomValue()
        {
            return UnityEngine.Random.Range( MinValue, MaxValue );
        }

        /// <summary>
        /// Returns a linearly interpolated value between <see cref="MinValue"/> and <see cref="MaxValue"/>
        /// where an input <paramref name="t"/> of 0 will return <see cref="MinValue"/>, and an input of 1 will
        /// return <see cref="MaxValue"/>
        /// </summary>
        /// <param name="t">The value to interpulate normalized to [0, 1]</param>
        /// <returns>The linearly interpolated value</returns>
        public float GetLerpedValue( float t )
        {
            return Mathf.Lerp( MinValue, MaxValue, Mathf.Clamp01( t ) );
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
            if ( MaxValue == MinValue )
            {
                if ( value == MaxValue )
                {
                    return 1f;
                }

                return 0f;
            }

            float normalizedValue = ( value - MinValue ) / ( MaxValue - MinValue );
            return Mathf.Clamp01( normalizedValue );
        }

        /// <summary>
        /// Determines whether or not the given <paramref name="value"/> is within this numerical range (inclusive)
        /// </summary>
        /// <param name="value">The value to determine</param>
        /// <returns>Whether or not the value is within the range</returns>
        public bool Contains( float value )
        {
            return value >= MinValue && value <= MaxValue;
        }

        /// <summary>
        /// Determines whether or not the given <paramref name="range"/> value is contained within this
        /// numerical range (inclusive)
        /// </summary>
        /// <param name="range">The range value to determine</param>
        /// <returns>Whether or not the range value is contained</returns>
        public bool Contains( Range range )
        {
            return Contains( range.MinValue ) &&
                   Contains( range.MaxValue );
        }

        /// <summary>
        /// Determines whether or not the given <paramref name="range"/> value overlaps this range
        /// </summary>
        /// <param name="range">The range value to test</param>
        /// <returns>Whether or not the ranges overlap eachother</returns>
        public bool Intersects( Range range )
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
        public float Clamp( float value )
        {
            return Mathf.Clamp( value, MinValue, MaxValue );
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
                MinValue = Mathf.Min( MinValue, range.MinValue ),
                MaxValue = Mathf.Max( MaxValue, range.MaxValue )
            };
        }

        /// <summary>
        /// Calculates the range of values where this range overlaps with the given <paramref name="range"/>.
        /// If the ranges don't overlap, an invalid range is returned.
        /// </summary>
        /// <param name="range">The range to intersect with</param>
        /// <returns>The intersecting range</returns>
        public Range IntersectionWith( Range range )
        {
            if ( Intersects( range ) )
            {
                return new Range()
                {
                    MinValue = Mathf.Max( MinValue, range.MinValue ),
                    MaxValue = Mathf.Min( MaxValue, range.MaxValue )
                };
            }

            // no intersection
            return new Range()
            {
                MinValue = float.NaN,
                MaxValue = float.NaN
            };
        }
    }
}
