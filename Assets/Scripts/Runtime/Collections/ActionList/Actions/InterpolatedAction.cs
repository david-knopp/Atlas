using UnityEngine;

namespace Atlas
{
    public abstract class InterpolatedAction : IAction
    {
        public bool IsFinished => m_timer.HasElapsed( LengthSeconds );
        public virtual bool IsBlocking { get; } = true;
        public virtual bool IsPaused
        {
            get => m_timer.IsPaused;
            set => m_timer.IsPaused = value;
        }

        public virtual void OnStart()
        {
            m_timer = new Timer( TimeScale );
            m_timer.Start();
        }

        public virtual void OnStop()
        {
            m_timer.Stop();
        }

        public void Tick()
        {
            if ( LengthSeconds > 0f )
            {
                float t = m_timer.GetElapsedPercent( LengthSeconds );
                OnTick( Mathf.Clamp01( t ) );
            }
        }

        protected abstract float LengthSeconds { get; }
        protected virtual TimeScale TimeScale => TimeScale.Scaled;

        protected abstract void OnTick( float elapsedPercent );

        private Timer m_timer;
    }
}
