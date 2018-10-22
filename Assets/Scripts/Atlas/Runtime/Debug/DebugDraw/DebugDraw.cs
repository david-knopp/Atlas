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

#if ATLAS_DEBUG_DRAW_RUNTIME || ( ATLAS_DEBUG_DRAW_EDITOR && UNITY_EDITOR )
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

        public static void DrawCircle( Vector3 centerPos, float radius, Color color, int numSegments = 16 )
        {
            if ( IsEnabled )
            {
                Instance.m_drawers.Add( new CircleDebugDrawer( centerPos, radius, color, numSegments ) );
            }
        }

        public static void DrawCircle( Vector3 centerPos, float radius, Color color, float lifetime, int numSegments = 16 )
        {
            if ( IsEnabled )
            {
                Instance.m_drawers.Add( new TimedDebugDrawer( new CircleDebugDrawer( centerPos, radius, color, numSegments ), lifetime ) );
            }
        }
#else
        public static void DrawLine( Vector3 startPos, Vector3 endPos, Color color ) { }
        public static void DrawRay( Vector3 pos, Vector3 dir, Color color ) { }
        public static void DrawCross( Vector3 pos, float lineLength, Color color ) { }
        public static void DrawLine( Vector3 startPos, Vector3 endPos, Color color, float lifetime ) { }
        public static void DrawRay( Vector3 pos, Vector3 dir, Color color, float lifetime ) { }
        public static void DrawCross( Vector3 pos, float lineLength, Color color, float lifetime ) { }
        public static void DrawCircle( Vector3 centerPos, float radius, Color color, int numSegments = 16 ) { }
        public static void DrawCircle( Vector3 centerPos, float radius, Color color, float lifetime, int numSegments = 16 ) { }
#endif
        #endregion // public

        #region private
#if ATLAS_DEBUGDRAW_VISIBLEATSTART
        private static bool m_isEnabled = true;
#else
        private static bool m_isEnabled = false;
#endif

#if ATLAS_DEBUG_DRAW_RUNTIME || ( ATLAS_DEBUG_DRAW_EDITOR && UNITY_EDITOR )
        private List<IDebugDrawer> m_drawers = new List<IDebugDrawer>();
        private Material m_material;
        private GUIListener m_guiListener;

        private void OnEnable()
        {
            m_guiListener = GUIListener.Instance;
            if ( m_guiListener )
            {
                m_guiListener.OnGUIRender += OnGUIRender;
            }
        }

        private void OnDisable()
        {
            if ( m_guiListener )
            {
                m_guiListener.OnGUIRender -= OnGUIRender;
            }
        }

        private void Start()
        {
            Shader debugShader = Shader.Find( "UI/Unlit/Transparent" );
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

        private void OnGUIRender()
        {
            if ( m_material )
            {
                Camera camera = Camera.main;
                if ( camera )
                {
                    GL.PushMatrix();
                    GL.LoadProjectionMatrix( camera.projectionMatrix );
                    GL.modelview = camera.worldToCameraMatrix;

                    m_material.SetPass( 0 );

                    for ( int i = m_drawers.Count - 1; i >= 0; --i )
                    {
                        IDebugDrawer drawable = m_drawers[i];
                        if ( drawable != null )
                        {
                            drawable.Draw();
                            if ( drawable.IsFinished == false )
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
#endif
        #endregion // private
    }
}