using UnityEngine;

namespace Atlas
{
    public struct CircleDebugDrawer : IDebugDrawer
    {
        public CircleDebugDrawer( Vector3 centerPos, float radius, Color color, int numSegments )
        {
            m_centerPos = centerPos;
            m_radius = radius;
            m_numSegments = Mathf.Max( numSegments, 1 );
            Color = color;
        }

        public bool IsFinished
        {
            get
            {
                return true;
            }
        }

        public Color Color
        {
            get;
            set;
        }

        public void Draw()
        {
            Vector3 up = Vector3.up;
            Vector3 right = Vector3.right;

            if ( Camera.main != null )
            {
                up = Camera.main.transform.up;
                right = Camera.main.transform.right;
            }

            GL.Begin( GL.LINE_STRIP );
            GL.Color( Color );

            for ( int i = 0; i < m_numSegments + 1; ++i )
            {
                float angle = ( i % m_numSegments ) * ( 2.0f * Mathf.PI / m_numSegments );
                Vector3 offset = right * Mathf.Cos( angle ) * m_radius +
                                 up * Mathf.Sin( angle ) * m_radius;
                GL.Vertex( m_centerPos + offset );
            }

            GL.End();
        }

        private Vector3 m_centerPos;
        private float m_radius;
        private int m_numSegments;
    }
}