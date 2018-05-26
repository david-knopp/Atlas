using UnityEngine;
using System.Collections.Generic;

namespace Atlas
{
    public class DebugDraw : SingletonBehavior<DebugDraw>
    {
        #region public
        public static bool IsEnabled
        {
            get { return m_isEnabled; }
            set { m_isEnabled = value; }
        }

        public static void DrawLine( Vector3 startPos, Vector3 endPos, Color color )
        {
            if ( IsEnabled )
            {
                Instance.m_drawers.Add( new LineDebugDrawer( startPos, endPos, color ) ); 
            }
        }

        public static void DrawRay( Vector3 pos, Vector3 dir, Color color )
        {
            if ( IsEnabled )
            {
                Instance.m_drawers.Add( new LineDebugDrawer( pos, pos + dir, color ) );
            }
        }

        public static void DrawCross( Vector3 pos, float lineLength, Color color )
        {
            if ( IsEnabled )
            {
                Instance.m_drawers.Add( new CrossDebugDrawer( pos, lineLength, color ) ); 
            }
        }

        public static void DrawLine( Vector3 startPos, Vector3 endPos, Color color, float lifetime )
        {
            if ( IsEnabled )
            {
                Instance.m_drawers.Add( new TimedDebugDrawer( new LineDebugDrawer( startPos, endPos, color ), lifetime ) );
            }
        }

        public static void DrawRay( Vector3 pos, Vector3 dir, Color color, float lifetime )
        {
            if ( IsEnabled )
            {
                Instance.m_drawers.Add( new TimedDebugDrawer( new LineDebugDrawer( pos, pos + dir, color ), lifetime ) ); 
            }
        }

        public static void DrawCross( Vector3 pos, float lineLength, Color color, float lifetime )
        {
            if ( IsEnabled )
            {
                Instance.m_drawers.Add( new TimedDebugDrawer( new CrossDebugDrawer( pos, lineLength, color ), lifetime ) ); 
            }
        }
        #endregion // public

        #region private
        private static bool m_isEnabled = true;

        private List<IDebugDrawer> m_drawers = new List<IDebugDrawer>();
        private Material m_material;

        private void Start()
        {
            Shader debugShader = Shader.Find( "Hidden/DebugLines" );
            if ( debugShader )
            {
                m_material = new Material( debugShader );
                m_material.hideFlags = HideFlags.HideAndDontSave;
            }
            else
            {
                Debug.LogError( "DebugDraw.Start: Couldn't find debug line shader, debug draw won't render." );
            }

            // hide debug object so it doesn't clutter the hierarchy
            gameObject.hideFlags = HideFlags.HideAndDontSave;
        }

        private void OnGUI()
        {
            if ( m_material )
            {
                Camera camera = Camera.current;
                if ( camera )
                {
                    GL.PushMatrix();
                    GL.LoadProjectionMatrix( camera.projectionMatrix );

                    m_material.SetPass( 0 );
                    
                    for ( int i = m_drawers.Count - 1; i >= 0; --i )
                    {
                        IDebugDrawer drawable = m_drawers[i];
                        if ( drawable != null )
                        {
                            drawable.Draw();
                            if ( drawable.IsFinished == false)
                            {
                                continue;
                            }
                        }

                        m_drawers.RemoveAt( i );
                    }

                    GL.PopMatrix();
                }
            }
        }
        #endregion // private
    }
}