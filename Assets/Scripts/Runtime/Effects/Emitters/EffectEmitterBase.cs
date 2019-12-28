using UnityEngine;
using System;

namespace Atlas
{
    /// <summary>
    /// Base emitter class to be used with the <see cref="Effect"/> system
    /// </summary>
    public abstract class EffectEmitterBase : MonoBehaviour
    {
        #region public
        /// <summary>
        /// Event that gets fired when the effect has finished emitting
        /// </summary>
        public event Action EmissionFinishedEvent
        {
            add { m_emissionFinishedEvent += value; }
            remove { m_emissionFinishedEvent -= value; }
        }

        /// <summary>
        /// Whether or not the effect is currently playing
        /// </summary>
        public bool IsPlaying
        {
            get;
            private set;
        }

        /// <summary>
        /// Plays the emitter
        /// </summary>
        public virtual void Play()
        {
            IsPlaying = true;
        }

        /// <summary>
        /// Stops the emitter
        /// </summary>
        public virtual void Stop()
        {
            IsPlaying = false;
        }
        #endregion public

        #region protected
        /// <summary>
        /// Whether or not the emitter has finished emitting
        /// </summary>
        protected abstract bool IsFinished
        {
            get;
        }

        /// <summary>
        /// Updates the emitter, called once per frame
        /// </summary>
        protected virtual void Update()
        {
            if ( IsPlaying &&
                 IsFinished )
            {
                m_emissionFinishedEvent?.Invoke();
                IsPlaying = false;
            }
        }
        #endregion protected

        #region private
        private Action m_emissionFinishedEvent;
        #endregion private
    }
}
