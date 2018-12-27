using UnityEngine;

namespace Atlas
{
    public struct Timer
    {
        #region public
        public Timer( TimeScale scale = TimeScale.Scaled )
        {
            m_timeScale = scale;
            m_startTimestamp = float.NegativeInfinity;
            m_pauseTimestamp = float.NegativeInfinity;
        }

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

        public bool IsPaused
        {
            get { return float.IsNegativeInfinity( m_pauseTimestamp ) == false; }
        }

        public bool IsTiming
        {
            get
            {
                return IsPaused == false && 
                       float.IsNegativeInfinity( m_startTimestamp ) == false;
            }
        }

        public void Start()
        {
            m_startTimestamp = CurrentTime;
            m_pauseTimestamp = float.NegativeInfinity;
        }

        public void Start( float timeOffset )
        {
            m_startTimestamp = CurrentTime - timeOffset;
            m_pauseTimestamp = float.NegativeInfinity;
        }

        public void Stop()
        {
            m_startTimestamp = float.NegativeInfinity;
            m_pauseTimestamp = float.NegativeInfinity;
        }

        public void Pause()
        {
            m_pauseTimestamp = CurrentTime;
        }

        public void Unpause()
        {
            m_startTimestamp += CurrentTime - m_pauseTimestamp;
            m_pauseTimestamp = float.NegativeInfinity;
        }

        public bool HasElapsed( float time )
        {
            return Elapsed >= time;
        }
        #endregion // public

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
        #endregion // private
    }
}