using UnityEngine;

namespace Atlas
{
    /// <summary>
    /// A helper action that will execute for the given amount of time,
    /// and caclulate an elapsed percentage from [0, 1]
    /// </summary>
    public abstract class InterpolatedAction : IAction
    {
        /// <summary>
        /// Returns true when the given time has elapsed
        /// </summary>
        public bool IsFinished => m_timer.HasElapsed( LengthSeconds );

        /// <summary>
        /// Whether or not this action will block the execution of subsequent actions
        /// until it has finished running
        /// </summary>
        public virtual bool IsBlocking { get; } = true;

        /// <summary>
        /// Whether or not the execution of this action is paused
        /// </summary>
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

        /// <summary>
        /// The amount of time this action takes to execute, in seconds
        /// </summary>
        protected abstract float LengthSeconds { get; }

        /// <summary>
        /// The <see cref="TimeScale"/> this action will use to calculate time
        /// </summary>
        protected virtual TimeScale TimeScale => TimeScale.Scaled;

        /// <summary>
        /// Called once per tick to update the action
        /// </summary>
        /// <param name="elapsedPercent">The action's current elapsed completion on [0,1]</param>
        protected abstract void OnTick( float elapsedPercent );

        private Timer m_timer;
    }
}
