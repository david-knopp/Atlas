using System;
using UnityEngine;

namespace Atlas
{
    /// <summary>
    /// A serializable class for simplifying easing/tweening workflow
    /// </summary>
    [Serializable]
    public sealed class Ease : ISerializationCallbackReceiver
    {
        #region public
        /// <summary>
        /// Type of ease function to use when evaluating
        /// </summary>
        public EaseType Type
        {
            get { return m_type; }
            set
            {
                m_type = value;
                Reset();
            }
        }

        /// <summary>
        /// Calculates the eased value of <paramref name="t"/>
        /// </summary>
        /// <param name="t">The time value to evaluate at</param>
        /// <param name="duration">The duration of this ease</param>
        /// <returns>The eased value</returns>
        public float Evaluate( float t, float duration = 1f )
        {
            Mathf.Max( duration, Mathf.Epsilon );
            return m_easeFunction.Invoke( t, duration );
        }

        /// <summary>
        /// Eases between the two given float values at time <paramref name="t"/>
        /// </summary>
        /// <param name="from">Initial value</param>
        /// <param name="to">Final value</param>
        /// <param name="t">The time value to evaluate at, normalized to [0, 1]</param>
        /// <returns>The eased value</returns>
        public float Interpolate( float from, float to, float t )
        {
            float ease = Evaluate( t );
            return from * ( 1f - ease ) + to * ease;
        }

        /// <summary>
        /// Eases between two given <see cref="Vector4"/> values at time <paramref name="t"/>
        /// </summary>
        /// <param name="from">Initial value</param>
        /// <param name="to">Final value</param>
        /// <param name="t">The time value to evaluate at, normalized to [0, 1]</param>
        /// <returns>The eased value</returns>
        public Vector4 Interpolate( Vector4 from, Vector4 to, float t )
        {
            float ease = Evaluate( t );
            return from * ( 1f - ease ) + to * ease;
        }

        /// <summary>
        /// Eases between two given <see cref="Vector3"/> values at time <paramref name="t"/>
        /// </summary>
        /// <param name="from">Initial value</param>
        /// <param name="to">Final value</param>
        /// <param name="t">The time value to evaluate at, normalized to [0, 1]</param>
        /// <returns>The eased value</returns>
        public Vector3 Interpolate( Vector3 from, Vector3 to, float t )
        {
            float ease = Evaluate( t );
            return from * ( 1f - ease ) + to * ease;
        }

        /// <summary>
        /// Eases between two given <see cref="Vector2"/> values at time <paramref name="t"/>
        /// </summary>
        /// <param name="from">Initial value</param>
        /// <param name="to">Final value</param>
        /// <param name="t">The time value to evaluate at, normalized to [0, 1]</param>
        /// <returns>The eased value</returns>
        public Vector2 Interpolate( Vector2 from, Vector2 to, float t )
        {
            float ease = Evaluate( t );
            return from * ( 1f - ease ) + to * ease;
        }

        /// <summary>
        /// Eases between two given <see cref="Quaternion"/> values at time <paramref name="t"/>
        /// </summary>
        /// <param name="from">Initial value</param>
        /// <param name="to">Final value</param>
        /// <param name="t">The time value to evaluate at, normalized to [0, 1]</param>
        /// <returns>The eased value</returns>
        public Quaternion Interpolate( Quaternion from, Quaternion to, float t )
        {
            float ease = Evaluate( t );
            return Quaternion.LerpUnclamped( from, to, ease );
        }

        #region ISerializationCallbackReceiver
        public void OnBeforeSerialize()
        {
        }

        public void OnAfterDeserialize()
        {
            Reset();
        }
        #endregion // ISerializationCallbackReceiver 
        #endregion public

        #region private
        [SerializeField] private EaseType m_type;

        private Func<float, float, float> m_easeFunction;

        private void Reset()
        {
            switch ( m_type )
            {
            case EaseType.LinearIn:
                m_easeFunction = LinearEase.In;
                break;

            case EaseType.LinearOut:
                m_easeFunction = LinearEase.Out;
                break;

            case EaseType.LinearInOut:
                m_easeFunction = LinearEase.InOut;
                break;

            case EaseType.ExponentialIn:
                m_easeFunction = ExponentialEase.In;
                break;

            case EaseType.ExponentialOut:
                m_easeFunction = ExponentialEase.Out;
                break;

            case EaseType.ExponentialInOut:
                m_easeFunction = ExponentialEase.InOut;
                break;

            case EaseType.QuadraticIn:
                m_easeFunction = QuadraticEase.In;
                break;

            case EaseType.QuadraticOut:
                m_easeFunction = QuadraticEase.Out;
                break;

            case EaseType.QuadraticInOut:
                m_easeFunction = QuadraticEase.InOut;
                break;

            case EaseType.CubicIn:
                m_easeFunction = CubicEase.In;
                break;

            case EaseType.CubicOut:
                m_easeFunction = CubicEase.Out;
                break;

            case EaseType.CubicInOut:
                m_easeFunction = CubicEase.InOut;
                break;

            case EaseType.QuarticIn:
                m_easeFunction = QuarticEase.In;
                break;

            case EaseType.QuarticOut:
                m_easeFunction = QuarticEase.Out;
                break;

            case EaseType.QuarticInOut:
                m_easeFunction = QuarticEase.InOut;
                break;

            case EaseType.QuinticIn:
                m_easeFunction = QuinticEase.In;
                break;

            case EaseType.QuinticOut:
                m_easeFunction = QuinticEase.Out;
                break;

            case EaseType.QuinticInOut:
                m_easeFunction = QuinticEase.InOut;
                break;

            case EaseType.BackIn:
                m_easeFunction = BackEase.In;
                break;

            case EaseType.BackOut:
                m_easeFunction = BackEase.Out;
                break;

            case EaseType.BackInOut:
                m_easeFunction = BackEase.InOut;
                break;

            case EaseType.CircularIn:
                m_easeFunction = CircularEase.In;
                break;

            case EaseType.CircularOut:
                m_easeFunction = CircularEase.Out;
                break;

            case EaseType.CircularInOut:
                m_easeFunction = CircularEase.InOut;
                break;

            case EaseType.BounceIn:
                m_easeFunction = BounceEase.In;
                break;

            case EaseType.BounceOut:
                m_easeFunction = BounceEase.Out;
                break;

            case EaseType.BounceInOut:
                m_easeFunction = BounceEase.InOut;
                break;

            case EaseType.ElasticIn:
                m_easeFunction = ElasticEase.In;
                break;

            case EaseType.ElasticOut:
                m_easeFunction = ElasticEase.Out;
                break;

            case EaseType.ElasticInOut:
                m_easeFunction = ElasticEase.InOut;
                break;

            case EaseType.SineIn:
                m_easeFunction = SineEase.In;
                break;

            case EaseType.SineOut:
                m_easeFunction = SineEase.Out;
                break;

            case EaseType.SineInOut:
                m_easeFunction = SineEase.InOut;
                break;

            default:
                Debug.LogWarningFormat( "Ease.Reset: No ease function exists for {0}", m_type );
                m_easeFunction = LinearEase.InOut;
                break;
            }
        } 
        #endregion private
    }
}
