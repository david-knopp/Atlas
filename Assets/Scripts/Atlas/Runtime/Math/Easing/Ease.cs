using System;
using UnityEngine;

namespace Atlas
{
    /// <summary>
    /// A serializable version of ease functions
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

        public float Evaluate( float t, float start, float delta, float duration )
        {
            return m_easeFunction.Invoke( t, start, delta, duration );
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

        private Func<float, float, float, float, float> m_easeFunction;

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

            case EaseType.QuadIn:
                m_easeFunction = QuadEase.In;
                break;

            case EaseType.QuadOut:
                m_easeFunction = QuadEase.Out;
                break;

            case EaseType.QuadInOut:
                m_easeFunction = QuadEase.InOut;
                break;

            default:
                Debug.LogWarningFormat( "Ease.Reset: No ease function exists for {0}", m_type );
                m_easeFunction = LinearEase.InOut;
                break;
            }
        }
    }
}