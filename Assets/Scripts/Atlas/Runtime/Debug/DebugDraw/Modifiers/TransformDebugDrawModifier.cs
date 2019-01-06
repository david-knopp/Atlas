using UnityEngine;

namespace Atlas
{
    public struct TransformDebugDrawModifier : IDebugDrawer
    {
        public TransformDebugDrawModifier( IDebugDrawer drawer, Vector3 position )
        {
            m_drawer = drawer;
            m_matrix = Matrix4x4.Translate( position );
        }

        public TransformDebugDrawModifier( IDebugDrawer drawer, Vector3 position, Quaternion rotation )
        {
            m_drawer = drawer;
            m_matrix = Matrix4x4.Translate( position ) * Matrix4x4.Rotate( rotation );
        }

        public bool IsFinished
        {
            get
            {
                return m_drawer.IsFinished;
            }
        }

        public Color Color
        {
            get { return m_drawer.Color; }
            set { m_drawer.Color = value; }
        }

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