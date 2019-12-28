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
            /// Automatically activate on <see cref="Start"/>
            /// </summary>
            Start = 0,

            /// <summary>
            /// Manually control activation, e.g. via code (by calling <see cref="Play"/>)
            /// </summary>
            AdHoc = 1
        }

        /// <summary>
        /// Event defining how the effect will be destroyed
        /// </summary>
        public enum DestructionEventType
        {
            /// <summary>
            /// Automatically destroy when all child emitters finish
            /// </summary>
            Finished = 0,

            /// <summary>
            /// Manually control destruction, e.g. via code (by calling <see cref="Object.Destroy"/>)
            /// </summary>
            AdHoc = 1,

            /// <summary>
            /// Automatically destroy after a set amount of time
            /// </summary>
            Timed
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

        [ContextMenu( "Play" )]
        /// <summary>
        /// Begins playing all child emitters
        /// </summary>
        public void Play()
        {
            IsPlaying = true;

            if ( DestructionEvent == DestructionEventType.Timed )
            {
                m_destroyTimer.Start();
            }

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
        [SerializeField, Tooltip( "When this effect should become active" )] private ActivationEventType m_activationEvent;
        [SerializeField, Tooltip( "When this effect should get destroyed" )] private DestructionEventType m_destructionEvent;
        [SerializeField, MinValue( 0f )] private float m_lifetimeSeconds;

        private List<EffectEmitterBase> m_emitters = new List<EffectEmitterBase>();
        private Timer m_destroyTimer = new Timer();
        private int m_finishedEmittersCount;

        private void Awake()
        {
            GetComponentsInChildren( m_emitters );

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

        private void Update()
        {
            if ( m_destroyTimer.IsTiming &&
                 m_destroyTimer.HasElapsed( m_lifetimeSeconds ) )
            {
                m_destroyTimer.Stop();
                Destroy();
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
                Destroy();
            }
        }

        private void Destroy()
        {
            Destroy( gameObject );
        }
        #endregion private
    }
}
