using UnityEngine;

namespace Atlas
{
    /// <summary>
    /// Debug circle element
    /// </summary>
    /// <seealso cref="DebugDraw"/>
    public struct CircleDebugDrawer : IDebugDrawer
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="radius">Radius of the circle</param>
        /// <param name="color">Color of the circle</param>
        /// <param name="numSegments">Number of segments to use when constructing the circle</param>
        public CircleDebugDrawer( float radius, Color color, int numSegments )
        {
            m_radius = radius;
            m_numSegments = Mathf.Max( numSegments, 1 );
            Color = color;
        }

        /// <summary>
        /// Whether or not this drawer has finished drawing yet
        /// </summary>
        public bool IsFinished
        {
            get { return true; }
        }

        /// <summary>
        /// The color of the circle
        /// </summary>
        public Color Color
        {
            get;
            set;
        }

        /// <summary>
        /// Draws the circle
        /// </summary>
        public void Draw()
        {
            GL.Begin( GL.LINE_STRIP );
            GL.Color( Color );

            for ( int i = 0; i < m_numSegments + 1; ++i )
            {
                float angle = ( i % m_numSegments ) * ( 2.0f * Mathf.PI / m_numSegments );
                Vector2 vertPosition = new Vector2( Mathf.Cos( angle ) * m_radius, 
                                                    Mathf.Sin( angle ) * m_radius );
                GL.Vertex( vertPosition );
            }

            GL.End();
        }
        
        private float m_radius;
        private int m_numSegments;
    }
}