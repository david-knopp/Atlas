using UnityEngine;

namespace Atlas
{
    /// <summary>
    /// Provides a simple interface for measuring elapsed time in seconds
    /// </summary>
    public struct Timer
    {
        #region public
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="scale">Target time scale to "tick" with</param>
        public Timer( TimeScale scale = TimeScale.Scaled )
        {
            m_timeScale = scale;
            m_startTimestamp = float.NegativeInfinity;
            m_pauseTimestamp = float.NegativeInfinity;
        }

        /// <summary>
        /// Amount of time that has elapsed (in seconds) since <see cref="Start"/> was last 
        /// called, or 0 if it the timer has not been started
        /// <remark>When the timer is paused, the return value will be the amount of time 
        /// measured before <see cref="Pause"/> was called</remark>
        /// </summary>
        public float Elapsed
        {
            get
            {
                if ( IsPaused )
                {
                    return m_pauseTimestamp - m_startTimestamp;
                }
                else if ( float.IsNegativeInfinity( m_startTimestamp ) == false )
                {
                    return CurrentTime - m_startTimestamp;
                }
                else
                {
                    return 0.0f;
                }
            }
        }

        /// <summary>
        /// Whether or not the timer is currently paused
        /// </summary>
        public bool IsPaused
        {
            get { return float.IsNegativeInfinity( m_pauseTimestamp ) == false; }
        }

        /// <summary>
        /// Whether or not the timer is currently measuring time
        /// </summary>
        public bool IsTiming
        {
            get
            {
                return IsPaused == false && 
                       float.IsNegativeInfinity( m_startTimestamp ) == false;
            }
        }

        /// <summary>
        /// Starts timing
        /// </summary>
        public void Start()
        {
            m_startTimestamp = CurrentTime;
            m_pauseTimestamp = float.NegativeInfinity;
        }

        /// <summary>
        /// Starts timing, but starts at the given time offset instead of 0
        /// </summary>
        /// <param name="timeOffset">Amount of time to start offset by</param>
        public void Start( float timeOffset )
        {
            m_startTimestamp = CurrentTime - timeOffset;
            m_pauseTimestamp = float.NegativeInfinity;
        }

        /// <summary>
        /// Stops timing
        /// </summary>
        public void Stop()
        {
            m_startTimestamp = float.NegativeInfinity;
            m_pauseTimestamp = float.NegativeInfinity;
        }

        /// <summary>
        /// Pauses timing
        /// </summary>
        public void Pause()
        {
            m_pauseTimestamp = CurrentTime;
        }

        /// <summary>
        /// Unpauses the timer
        /// </summary>
        public void Unpause()
        {
            m_startTimestamp += CurrentTime - m_pauseTimestamp;
            m_pauseTimestamp = float.NegativeInfinity;
        }

        /// <summary>
        /// Helper function to determine if the timer's elapsed time is greater or 
        /// equal to the given time
        /// </summary>
        /// <param name="time">Amount of time to compare with</param>
        /// <returns>Whether or not the given amount of time has passed</returns>
        public bool HasElapsed( float time )
        {
            return Elapsed >= time;
        }

        public float GetElapsedPercent( float duration )
        {
            if ( duration > 0f )
            {
                return Elapsed / duration;
            }

            return 0f;
        }
        #endregion public

        #region private
        private float m_startTimestamp;
        private float m_pauseTimestamp;
        private TimeScale m_timeScale;

        private float CurrentTime
        {
            get
            {
                switch ( m_timeScale )
                {
                case TimeScale.Unscaled:
                    return Time.unscaledTime;

                default:
                case TimeScale.Scaled:
                    return Time.time;

                case TimeScale.Fixed:
                    return Time.fixedTime;
                }
            }
        }
        #endregion private
    }
}
