using UnityEngine;

namespace Atlas
{
    /// <summary>
    /// Causes the modified <see cref="IDebugDrawer"/> to get rendered facing the given camera
    /// </summary>
    /// <seealso cref="DebugDraw"/>
    public struct BillboardDebugDrawModifier : IDebugDrawer
    {
        /// <summary>
        /// Constructor, automatically uses <see cref="Camera.main"/> for billboarding
        /// </summary>
        /// <param name="drawer">The drawer to modify</param>
        /// <param name="position">The position of the element</param>
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

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="drawer">The drawer to modify</param>
        /// <param name="position">The position of the element</param>
        /// <param name="camera">The camera to face the element toward</param>
        public BillboardDebugDrawModifier( IDebugDrawer drawer, Vector3 position, Camera camera )
        {
            m_drawer = drawer;
            m_position = position;
            m_camera = camera;
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
