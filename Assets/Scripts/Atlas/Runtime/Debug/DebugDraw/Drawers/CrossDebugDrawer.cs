using UnityEngine;

namespace Atlas
{
    public struct CrossDebugDrawer : IDebugDrawer
    {
        public CrossDebugDrawer( Vector3 position, float lineLength, Color color )
        {
            m_position = position;
            m_lineLength = lineLength;
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

            // calculate line end-points
            float d = m_lineLength * 0.7071f; // about sin(45)

            GL.Begin( GL.LINES );
            GL.Color( Color );

            // first line
            GL.Vertex( m_position - right * d - up * d );
            GL.Vertex( m_position + right * d + up * d );

            // second line
            GL.Vertex( m_position - right * d + up * d );
            GL.Vertex( m_position + right * d - up * d );

            GL.End();
        }

        private Vector3 m_position;
        private float m_lineLength;
    }
}