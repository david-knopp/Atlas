using UnityEngine;

namespace Atlas
{
    public struct RectangleDebugDrawer : IDebugDrawer
    {
        public RectangleDebugDrawer( float width, float height, Color color )
        {
            float halfWidth = width * 0.5f;
            float halfHeight = height * 0.5f;

            m_topLeftPos = new Vector2( -halfWidth, halfHeight );
            m_topRightPos = new Vector2( halfWidth, halfHeight );
            m_bottomLeftPos = new Vector2( -halfWidth, -halfHeight );
            m_bottomRightPos = new Vector2( halfWidth, -halfHeight );

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

            GL.Vertex( m_topLeftPos );
            GL.Vertex( m_topRightPos );
            GL.Vertex( m_bottomRightPos );
            GL.Vertex( m_bottomLeftPos );
            GL.Vertex( m_topLeftPos );

            GL.End();
        }

        private Vector2 m_topLeftPos;
        private Vector2 m_topRightPos;
        private Vector2 m_bottomLeftPos;
        private Vector2 m_bottomRightPos;
    }
}