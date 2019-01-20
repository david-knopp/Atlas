using UnityEngine;
using System;

namespace Atlas
{
    public abstract class EffectEmitterBase : MonoBehaviour
    {
        public event Action EmissionFinishedEvent
        {
            add { m_emissionFinishedEvent += value; }
            remove { m_emissionFinishedEvent -= value; }
        }

        public bool IsPlaying
        {
            get;
            private set;
        }

        public virtual void Play()
        {
            IsPlaying = true;
        }

        public virtual void Stop()
        {
            IsPlaying = false;
        }

        protected abstract bool IsFinished
        {
            get;
        }

        protected virtual void Update()
        {
            if ( IsPlaying && 
                 IsFinished )
            {
                m_emissionFinishedEvent.Invoke();
                IsPlaying = false;
            }
        }

        private Action m_emissionFinishedEvent = () => { };
    }
}