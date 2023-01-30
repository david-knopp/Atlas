using UnityEngine;

namespace Atlas
{
    /// <summary>
    /// Base class for simple ease animations, providing various
    /// options for ease types, and looping methods
    /// </summary>
    public abstract class EaseComponent : MonoBehaviour
    {
        #region public
        /// <summary>
        /// Type of loop to use when the ease finishes
        /// </summary>
        public enum LoopType
        {
            /// <summary>
            /// No looping, the ease will stop after 1 cycle has finished
            /// </summary>
            None = 0,

            /// <summary>
            /// Repeats the ease from the beginning each cycle
            /// </summary>
            Cycle = 1,

            /// <summary>
            /// Eases back and forth from the starting position to the target
            /// </summary>
            PingPong = 2,

            /// <summary>
            /// Repeats the original ease, but offset to start at the last ease's ending position
            /// </summary>
            Offset = 3
        }

        /// <summary>
        /// True if the ease is running
        /// </summary>
        public bool IsPlaying
        {
            get => m_timer.IsTiming;
            set
            {
                if ( value )
                {
                    Play();
                }
                else
                {
                    Stop();
                }
            }
        }


        /// <summary>
        /// True if the ease is paused
        /// </summary>
        public bool IsPaused
        {
            get => m_timer.IsPaused;
        }

        /// <summary>
        /// Starts the ease. If an ease is already running,
        /// it will be restarted
        /// </summary>
        [InspectorButton]
        public void Play()
        {
            m_timer.Start();
            m_loopCount = 0;
        }

        /// <summary>
        /// Stops the ease
        /// </summary>
        [InspectorButton]
        public void Stop()
        {
            m_timer.Stop();
            m_loopCount = 0;
        }

        /// <summary>
        /// Pauses playback
        /// </summary>
        public void Pause()
        {
            m_timer.IsPaused = true;
        }
        #endregion public

        #region protected
        /// <summary>
        /// Called every update when the ease is playing
        /// </summary>
        /// <param name="t">An eased [0, 1] percentage of completion. Note that
        /// the range can be outside of [0, 1] depending on the ease and loop types used. </param>
        protected abstract void OnUpdate( float t );

        protected virtual void Awake()
        {
            m_timer = new Timer( m_timeScale );

            if ( m_playOnAwake )
            {
                Play();
            }
        }

        protected virtual void Update()
        {
            if ( m_timer.IsTiming )
            {
                if ( m_timer.HasElapsed( m_durationSeconds ) )
                {
                    Evaluate( 1.0f );
                    OnEaseFinished();
                }
                else
                {
                    float elapsedPercent = m_timer.GetElapsedPercent( m_durationSeconds );
                    Evaluate( elapsedPercent );
                }
            }
        }
        #endregion protected

        #region private
        [SerializeField]
        private Ease m_ease;

        [SerializeField, MinValue( 0.0f )]
        private float m_durationSeconds = 1.0f;

        [SerializeField, Tooltip( "Which Unity time scale is used for calculation" )]
        private TimeScale m_timeScale = TimeScale.Scaled;

        [SerializeField, Tooltip( "When enabled, the ease will start playing on Awake" )]
        private bool m_playOnAwake = true;

        [SerializeField]
        private LoopType m_loopType = LoopType.None;

        [SerializeField, Tooltip( "Enables a 2nd ease type when returning to the original position in a ping-pong loop" )]
        private bool m_overrideReturnEase = false;

        [SerializeField, Tooltip( "Ease used on the return of a ping-pong loop cycle" )]
        private Ease m_returnEase;

        private Timer m_timer;
        private int m_loopCount;

        private void OnEaseFinished()
        {
            if ( m_loopType == LoopType.None )
            {
                Stop();
                return;
            }

            m_loopCount++;
            m_timer.Start();
        }

        private void Evaluate( float t )
        {
            switch ( m_loopType )
            {
                case LoopType.PingPong:
                    // play forward
                    if ( m_loopCount.IsEven() )
                    {
                        OnUpdate( m_ease.Evaluate( t ) );
                    }
                    // play return ease
                    else if ( m_overrideReturnEase )
                    {
                        OnUpdate( 1.0f - m_returnEase.Evaluate( t ) );
                    }
                    // replay backwards
                    else
                    {
                        OnUpdate( 1.0f - m_ease.Evaluate( t ) );
                    }
                    break;

                case LoopType.Offset:
                    OnUpdate( m_ease.Evaluate( t ) + m_loopCount );
                    break;

                default:
                    OnUpdate( m_ease.Evaluate( t ) );
                    break;
            }
        } 
        #endregion private
    }
}
