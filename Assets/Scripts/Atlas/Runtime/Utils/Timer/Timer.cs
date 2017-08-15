using UnityEngine;

namespace Atlas
{
    public class Timer
    {
        #region public
        public float Elapsed
        {
            get
            {
                if ( IsPaused )
                {
                    return m_pauseTimestamp - m_startTimestamp;
                }
                else if ( m_startTimestamp > 0.0f )
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
            get { return m_pauseTimestamp > 0.0f; }
        }

        public bool IsTiming
        {
            get { return !IsPaused && m_startTimestamp > 0.0f; }
        }

        public virtual void Start()
        {
            m_startTimestamp = CurrentTime;
            m_pauseTimestamp = 0.0f;
        }

        public void Stop()
        {
            m_startTimestamp = 0.0f;
        }

        public void Pause()
        {
            m_pauseTimestamp = CurrentTime;
        }

        public void Unpause()
        {
            m_startTimestamp += CurrentTime - m_pauseTimestamp;
            m_pauseTimestamp = 0.0f;
        }
        #endregion // public

        #region protected
        protected virtual float CurrentTime
        {
            get { return Time.time; }
        }
        #endregion // protected

        #region private
        private float m_startTimestamp;
        private float m_pauseTimestamp;
        #endregion // private
    }
}