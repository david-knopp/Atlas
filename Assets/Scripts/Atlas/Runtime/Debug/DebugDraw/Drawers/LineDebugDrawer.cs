using UnityEngine;

namespace Atlas
{
    public class LineDebugDrawer : IDebugDrawer
    {
        public LineDebugDrawer( Vector3 startPos, Vector3 endPos, Color color )
        {
            m_startPos = startPos;
            m_endPos = endPos;
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
            GL.Begin( GL.LINES );
            GL.Color( Color );

            GL.Vertex( m_startPos );
            GL.Vertex( m_endPos );

            GL.End();
        }

        private Vector3 m_startPos;
        private Vector3 m_endPos;
    }
}