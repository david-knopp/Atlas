using UnityEngine;

namespace Atlas
{
    /// <summary>
    /// Transforms the given <see cref="IDebugDrawer"/> into world space
    /// </summary>
    public struct TransformDebugDrawModifier : IDebugDrawer
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="drawer">The drawer to transform</param>
        /// <param name="position">The world position to place the element at</param>
        public TransformDebugDrawModifier( IDebugDrawer drawer, Vector3 position )
        {
            m_drawer = drawer;
            m_matrix = Matrix4x4.Translate( position );
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="drawer">The drawer to transform</param>
        /// <param name="position">The world position to place the element at</param>
        /// <param name="rotation">The rotation of the element</param>
        public TransformDebugDrawModifier( IDebugDrawer drawer, Vector3 position, Quaternion rotation )
        {
            m_drawer = drawer;
            m_matrix = Matrix4x4.Translate( position ) * Matrix4x4.Rotate( rotation );
        }

        /// <summary>
        /// Whether or not the modified element has finished drawing
        /// </summary>
        public bool IsFinished
        {
            get
            {
                return m_drawer.IsFinished;
            }
        }

        /// <summary>
        /// Color of the modified element
        /// </summary>
        public Color Color
        {
            get { return m_drawer.Color; }
            set { m_drawer.Color = value; }
        }

        /// <summary>
        /// Draws the modified element
        /// </summary>
        public void Draw()
        {
            GL.PushMatrix();
            GL.MultMatrix( m_matrix );

            m_drawer.Draw();

            GL.PopMatrix();
        }

        private IDebugDrawer m_drawer;
        private Matrix4x4 m_matrix;
    }
}