using UnityEngine;

namespace Atlas
{
    public abstract class InterpolatedActionBase : IAction
    {
        public bool IsFinished => m_timer.HasElapsed( LengthSeconds );
        public virtual bool IsBlocking { get; protected set; } = true;
        public bool IsPaused { get; set; }

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
