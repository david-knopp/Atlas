using UnityEngine;

namespace Atlas
{
    public class CrossDebugDrawer : IDebugDrawer
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
            // calculate line end-points
            float d = m_lineLength / 2.828f; // about 2 * sqrt( 2 )
            Vector3 min = new Vector3( m_position.x - d, m_position.y - d, 0.0f );
            Vector3 max = new Vector3( m_position.x + d, m_position.y + d, 0.0f );

            GL.Begin( GL.LINES );
            GL.Color( Color );

            // first line
            GL.Vertex( min );
            GL.Vertex( max );

            // second line
            GL.Vertex( new Vector3( min.x, max.y, 0.0f ) );
            GL.Vertex( new Vector3( max.x, min.y, 0.0f ) );

            GL.End();
        }

        private Vector3 m_position;
        private float m_lineLength;
    }
}