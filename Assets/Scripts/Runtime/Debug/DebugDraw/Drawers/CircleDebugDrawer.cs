using UnityEngine;

namespace Atlas
{
    public struct CircleDebugDrawer : IDebugDrawer
    {
        public CircleDebugDrawer( float radius, Color color, int numSegments )
        {
            m_radius = radius;
            m_numSegments = Mathf.Max( numSegments, 1 );
            Color = color;
        }

        public bool IsFinished
        {
            get { return true; }
        }

        public Color Color
        {
            get;
            set;
        }

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