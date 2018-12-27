using UnityEngine;

namespace Atlas
{
    public class TimedDebugDrawer : IDebugDrawer
    {
        public TimedDebugDrawer( IDebugDrawer drawer, float lifetime )
        {
            m_drawer = drawer;
            m_lifetime = lifetime;
            m_initialAlpha = m_drawer.Color.a;

            m_timer = new Timer( TimeScale.Unscaled );
            m_timer.Start();
        }

        public bool IsFinished
        {
            get
            {
                return m_timer.Elapsed >= m_lifetime;
            }
        }

        public Color Color
        {
            get { return m_drawer.Color; }
            set { m_drawer.Color = value; }
        }

        public void Draw()
        {
            if ( m_drawer != null )
            {
                // fade alpha over lifetime
                if ( m_lifetime > 0.0f )
                {
                    float t = Mathf.Clamp01( m_timer.Elapsed / m_lifetime );
                    Color color = m_drawer.Color;
                    color.a = m_initialAlpha * ( 1.0f - t );
                    m_drawer.Color = color;
                }

                m_drawer.Draw();
            }
        }

        private IDebugDrawer m_drawer;
        private Timer m_timer;
        private float m_lifetime;
        private float m_initialAlpha;
    }
}