using UnityEngine;

namespace Atlas
{
    /// <summary>
    /// Debug rectangle element
    /// </summary>
    /// <seealso cref="DebugDraw"/>
    public struct RectangleDebugDrawer : IDebugDrawer
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="width">Width of the rectangle</param>
        /// <param name="height">Height of the rectangle</param>
        /// <param name="color">Color of the rectangle</param>
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

        /// <summary>
        /// Whether or not this drawer has finished drawing yet
        /// </summary>
        public bool IsFinished
        {
            get { return true; }
        }

        /// <summary>
        /// Color of the rectangle
        /// </summary>
        public Color Color
        {
            get;
            set;
        }

        /// <summary>
        /// Draws the rectangle
        /// </summary>
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