using UnityEngine;

namespace Atlas
{
    /// <summary>
    /// Debug cross (X) element
    /// </summary>
    /// <seealso cref="DebugDraw"/>
    public struct CrossDebugDrawer : IDebugDrawer
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="lineLength">Length of each line</param>
        /// <param name="color">Color of the cross</param>
        public CrossDebugDrawer( float lineLength, Color color )
        {
            m_lineLength = lineLength;
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
        /// The color of the cross
        /// </summary>
        public Color Color
        {
            get;
            set;
        }

        /// <summary>
        /// Draws the cross
        /// </summary>
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
