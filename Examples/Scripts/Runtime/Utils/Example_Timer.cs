using UnityEngine;

namespace Atlas.Examples
{
    public sealed class Example_Timer : MonoBehaviour
    {
        // create a timer that ticks based on Unity's Time.unscaledTime
        private Timer m_timer = new Timer( TimeScale.Unscaled );

        private void Start()
        {
            // start timing
            m_timer.Start();
        }

        private void Update()
        {
            // check if 3 seconds has passed since starting
            if ( m_timer.HasElapsed( 3.0f ) )
            {
                // stop timing
                m_timer.Stop();
            }

            // Toggle pause
            if ( Input.GetKeyDown( KeyCode.Pause ) )
            {
                if ( m_timer.IsPaused )
                {
                    m_timer.Unpause();
                }
                else
                {
                    m_timer.Pause();
                }
            }
        }
    }
}
