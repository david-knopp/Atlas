using System;
using UnityEngine;

namespace Atlas
{
    /// <summary>
    /// A serializable helper class for simplifying easing workflow
    /// </summary>
    [Serializable]
    public class Ease : ISerializationCallbackReceiver
    {
        public EaseType Type
        {
            get { return m_type; }
            set
            {
                m_type = value;
                Reset();
            }
        }

        public float Evaluate( float curTime, float duration )
        {
            return m_easeFunction.Invoke( curTime, duration );
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

            default:
                Debug.LogWarningFormat( "Ease.Reset: No ease function exists for {0}", m_type );
                m_easeFunction = LinearEase.InOut;
                break;
            }
        }
    }
}