using UnityEngine;
using System.Collections.Generic;

namespace Atlas
{
    /// <summary>
    /// Manages activation and destruction of all effect emitters (<see cref="EffectEmitterBase"/>) that comprise a game effect.
    /// Bundling all elements of an effect into one self-contained, reusable package can be make working with effects that
    /// contain various components easier, such as audio, particles, haptics, etc.
    /// </summary>
    /// <seealso cref="EffectEmitterBase"/>
    public sealed class Effect : MonoBehaviour
    {
        #region public
        /// <summary>
        /// Event defining how the effect will be activated
        /// </summary>
        public enum ActivationEventType
        {
            /// <summary>
            /// Activate on <see cref="Start"/>
            /// </summary>
            Start = 0,

            /// <summary>
            /// Manually activate via code (by calling <see cref="Play"/>)
            /// </summary>
            Manual = 1
        }

        /// <summary>
        /// Event defining how the effect will be destroyed
        /// </summary>
        public enum DestructionEventType
        {
            /// <summary>
            /// Destroy when all child emitters finish
            /// </summary>
            Finished = 0,

            /// <summary>
            /// Manually destroy via code (by calling <see cref="Object.Destroy"/>)
            /// </summary>
            Manual = 1
        }

        /// <summary>
        /// When the effect will be activated
        /// </summary>
        public ActivationEventType ActivationEvent
        {
            get { return m_activationEvent; }
        }

        /// <summary>
        /// When the effect will be destroyed
        /// </summary>
        public DestructionEventType DestructionEvent
        {
            get { return m_destructionEvent; }
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
        /// Begins playing all child emitters
        /// </summary>
        public void Play()
        {
            IsPlaying = true;

            foreach ( var emitter in m_emitters )
            {
                emitter.Play();
            }
        }

        /// <summary>
        /// Stops all child emitters
        /// </summary>
        public void Stop()
        {
            if ( IsPlaying )
            {
                foreach ( var emitter in m_emitters )
                {
                    emitter.Stop();
                }

                OnFinished();
            }
        }
        #endregion public

        #region private
        [SerializeField] private List<EffectEmitterBase> m_emitters;
        [SerializeField] private ActivationEventType m_activationEvent;
        [SerializeField] private DestructionEventType m_destructionEvent;

        private int m_finishedEmittersCount;

        private void Awake()
        {
            for ( int i = 0; i < m_emitters.Count; i++ )
            {
                m_emitters[i].EmissionFinishedEvent += OnEmitterFinished;
            }
        }

        private void Start()
        {
            if ( ActivationEvent == ActivationEventType.Start )
            {
                Play();
            }
        }

        private void OnEmitterFinished()
        {
            ++m_finishedEmittersCount;
            if ( m_finishedEmittersCount == m_emitters.Count )
            {
                OnFinished();
            }
        }

        private void OnFinished()
        {
            IsPlaying = false;

            if ( DestructionEvent == DestructionEventType.Finished )
            {
                Destroy( gameObject );
            }
        } 
        #endregion private
    }
}
