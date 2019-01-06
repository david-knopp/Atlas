using UnityEngine;

namespace Atlas
{
    public struct CrossDebugDrawer : IDebugDrawer
    {
        public CrossDebugDrawer( float lineLength, Color color )
        {
            m_lineLength = lineLength;
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
            Vector3 up = Vector3.up;
            Vector3 right = Vector3.right;

            // calculate line end-points
            float d = m_lineLength * 0.7071f; // about sin(45)

            GL.Begin( GL.LINES );
            GL.Color( Color );

            // first line
            GL.Vertex( new Vector2( -d, -d ) );
            GL.Vertex( new Vector2(  d,  d ) );

            // second line
            GL.Vertex( new Vector2( -d,  d ) );
            GL.Vertex( new Vector2(  d, -d ) );

            GL.End();
        }
        
        private float m_lineLength;
    }
}