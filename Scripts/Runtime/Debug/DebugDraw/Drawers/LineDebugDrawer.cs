using UnityEngine;

namespace Atlas
{
    /// <summary>
    /// Debug line element
    /// </summary>
    /// <seealso cref="DebugDraw"/>
    public struct LineDebugDrawer : IDebugDrawer
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="startPos">Starting position of the line</param>
        /// <param name="endPos">Ending position of the line</param>
        /// <param name="color">Color of the line</param>
        public LineDebugDrawer( Vector3 startPos, Vector3 endPos, Color color )
        {
            m_startPos = startPos;
            m_endPos = endPos;
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
        /// Color of the line
        /// </summary>
        public Color Color
        {
            get;
            set;
        }

        /// <summary>
        /// Draws the line
        /// </summary>
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
