using UnityEngine;

namespace Atlas
{
    public struct BillboardDebugDrawModifier : IDebugDrawer
    {
        public BillboardDebugDrawModifier( IDebugDrawer drawer, Vector3 position )
        {
            m_drawer = drawer;
            m_position = position;
            m_camera = Camera.main;

            if ( m_camera == null )
            {
                Debug.LogError( "No main camera exists for use with debug draw billboarding, ensure one is tagged with `main camera` in the scene" );
            }
        }

        public BillboardDebugDrawModifier( IDebugDrawer drawer, Vector3 position, Camera camera )
        {
            m_drawer = drawer;
            m_position = position;
            m_camera = camera;
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
            if ( m_camera != null )
            {
                GL.PushMatrix();
                GL.MultMatrix( Matrix4x4.Translate( m_position ) * Matrix4x4.Rotate( m_camera.transform.rotation ) );

                m_drawer.Draw();

                GL.PopMatrix(); 
            }
        }

        private IDebugDrawer m_drawer;
        private Vector3 m_position;
        private Camera m_camera;
    }
}