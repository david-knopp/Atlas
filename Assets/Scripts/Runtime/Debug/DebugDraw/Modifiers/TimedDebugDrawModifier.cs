using UnityEngine;

namespace Atlas
{
    /// <summary>
    /// Causes the modified <see cref="IDebugDrawer"/> to render for the given amount of time
    /// </summary>
    public struct TimedDebugDrawModifier : IDebugDrawer
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="drawer">Element to draw</param>
        /// <param name="lifetime">Amount of time (in seconds) to draw the element for</param>
        public TimedDebugDrawModifier( IDebugDrawer drawer, float lifetime )
        {
            m_drawer = drawer;
            m_lifetime = lifetime;
            m_initialAlpha = m_drawer.Color.a;

            m_timer = new Timer( TimeScale.Unscaled );
            m_timer.Start();
        }

        /// <summary>
        /// Whether or not the modified element has finished drawing
        /// </summary>
        public bool IsFinished
        {
            get
            {
                return m_timer.Elapsed >= m_lifetime;
            }
        }

        /// <summary>
        /// Color of the modified element
        /// </summary>
        public Color Color
        {
            get { return m_drawer.Color; }
            set { m_drawer.Color = value; }
        }

        /// <summary>
        /// Draws the modified element
        /// </summary>
        public void Draw()
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

        private IDebugDrawer m_drawer;
        private Timer m_timer;
        private float m_lifetime;
        private float m_initialAlpha;
    }
}