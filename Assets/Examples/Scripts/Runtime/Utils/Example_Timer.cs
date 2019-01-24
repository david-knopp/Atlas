using UnityEngine;

namespace Atlas.Examples
{
    public sealed class Example_Timer : MonoBehaviour
    {
        private Timer m_timer = new Timer( TimeScale.Unscaled );

        private void Start()
        {
            m_timer.Start();
        }

        private void Update()
        {
            if ( m_timer.Elapsed >= 3.0f )
            {
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