﻿using UnityEngine;
using System.Collections.Generic;

namespace Atlas
{
    public sealed class DebugDraw : SingletonBehavior<DebugDraw>
    {
        #region public
        public static bool IsEnabled
        {
            get { return m_isEnabled; }
            set { m_isEnabled = value; }
        }

#if ATLAS_DEBUGDRAW_RUNTIME || ( ATLAS_DEBUGDRAW_EDITOR && UNITY_EDITOR )
        public static void DrawLine( Vector3 startPos, Vector3 endPos, Color color )
        {
            if ( IsEnabled )
            {
                Instance.m_drawers.Add( new LineDebugDrawer( startPos, endPos, color ) );
            }
        }

        public static void DrawLine( Vector3 startPos, Vector3 endPos, Color color, float lifetime )
        {
            if ( IsEnabled )
            {
                Instance.m_drawers.Add( new LineDebugDrawer( startPos, endPos, color ).Timed( lifetime ) );
            }
        }

        public static void DrawRay( Vector3 position, Vector3 direction, Color color )
        {
            if ( IsEnabled )
            {
                Instance.m_drawers.Add( new LineDebugDrawer( position, position + direction, color ) );
            }
        }

        public static void DrawRay( Vector3 position, Vector3 direction, Color color, float lifetime )
        {
            if ( IsEnabled )
            {
                Instance.m_drawers.Add( new LineDebugDrawer( position, position + direction, color ).Timed( lifetime ) );
            }
        }

        public static void DrawCross( Vector3 position, float lineLength, Color color )
        {
            if ( IsEnabled )
            {
                Instance.m_drawers.Add( new CrossDebugDrawer( lineLength, color ).Billboarded( position ) );
            }
        }

        public static void DrawCross( Vector3 position, float lineLength, Color color, float lifetime )
        {
            if ( IsEnabled )
            {
                Instance.m_drawers.Add( new CrossDebugDrawer( lineLength, color ).Billboarded( position ).Timed( lifetime ) );
            }
        }

        public static void DrawCross( Vector3 position, Quaternion rotation, float lineLength, Color color )
        {
            if ( IsEnabled )
            {
                Instance.m_drawers.Add( new CrossDebugDrawer( lineLength, color ).Transformed( position, rotation ) );
            }
        }

        public static void DrawCross( Vector3 position, Quaternion rotation, float lineLength, Color color, float lifetime )
        {
            if ( IsEnabled )
            {
                Instance.m_drawers.Add( new CrossDebugDrawer( lineLength, color ).Transformed( position, rotation ).Timed( lifetime ) );
            }
        }

        public static void DrawCircle( Vector3 position, float radius, Color color, int numSegments = 16 )
        {
            if ( IsEnabled )
            {
                Instance.m_drawers.Add( new CircleDebugDrawer( radius, color, numSegments ).Billboarded( position ) );
            }
        }

        public static void DrawCircle( Vector3 position, float radius, Color color, float lifetime, int numSegments = 16 )
        {
            if ( IsEnabled )
            {
                Instance.m_drawers.Add( new CircleDebugDrawer( radius, color, numSegments ).Billboarded( position ).Timed( lifetime ) );
            }
        }

        public static void DrawCircle( Vector3 position, Quaternion rotation, float radius, Color color, int numSegments = 16 )
        {
            if ( IsEnabled )
            {
                Instance.m_drawers.Add( new CircleDebugDrawer( radius, color, numSegments ).Transformed( position, rotation ) );
            }
        }

        public static void DrawCircle( Vector3 position, Quaternion rotation, float radius, Color color, float lifetime, int numSegments = 16 )
        {
            if ( IsEnabled )
            {
                Instance.m_drawers.Add( new CircleDebugDrawer( radius, color, numSegments ).Transformed( position, rotation ).Timed( lifetime ) );
            }
        }

        public static void DrawRectangle( Vector3 position, float width, float height, Color color )
        {
            if ( IsEnabled )
            {
                Instance.m_drawers.Add( new RectangleDebugDrawer( width, height, color ).Billboarded( position ) );
            }
        }

        public static void DrawRectangle( Vector3 position, float width, float height, Color color, float lifetime )
        {
            if ( IsEnabled )
            {
                Instance.m_drawers.Add( new RectangleDebugDrawer( width, height, color ).Billboarded( position ).Timed( lifetime ) );
            }
        }

        public static void DrawRectangle( Vector3 position, Quaternion rotation, float width, float height, Color color )
        {
            if ( IsEnabled )
            {
                Instance.m_drawers.Add( new RectangleDebugDrawer( width, height, color ).Transformed( position, rotation ) );
            }
        }

        public static void DrawRectangle( Vector3 position, Quaternion rotation, float width, float height, Color color, float lifetime )
        {
            if ( IsEnabled )
            {
                Instance.m_drawers.Add( new RectangleDebugDrawer( width, height, color ).Transformed( position, rotation ).Timed( lifetime ) );
            }
        }

        public static void DrawText( Vector3 position, string text, Color color, float fontSize, AnchorPosition anchor = AnchorPosition.TopLeft )
        {
            if ( IsEnabled )
            {
                Instance.m_drawers.Add( new TextDebugDrawer( text, color, fontSize, anchor ).Billboarded( position ) );
            }
        }

        public static void DrawText( Vector3 position, string text, Color color, float fontSize, float lifetime, AnchorPosition anchor = AnchorPosition.TopLeft )
        {
            if ( IsEnabled )
            {
                Instance.m_drawers.Add( new TextDebugDrawer( text, color, fontSize, anchor ).Billboarded( position ).Timed( lifetime ) );
            }
        }

        public static void DrawText( Vector3 position, Quaternion rotation, string text, Color color, float fontSize, AnchorPosition anchor = AnchorPosition.TopLeft )
        {
            if ( IsEnabled )
            {
                Instance.m_drawers.Add( new TextDebugDrawer( text, color, fontSize, anchor ).Transformed( position, rotation ) );
            }
        }

        public static void DrawText( Vector3 position, Quaternion rotation, string text, Color color, float fontSize, float lifetime, AnchorPosition anchor = AnchorPosition.TopLeft )
        {
            if ( IsEnabled )
            {
                Instance.m_drawers.Add( new TextDebugDrawer( text, color, fontSize, anchor ).Transformed( position, rotation ).Timed( lifetime ) );
            }
        }
#else
        public static void DrawLine( Vector3 startPos, Vector3 endPos, Color color ) { }
        public static void DrawLine( Vector3 startPos, Vector3 endPos, Color color, float lifetime ) { }
        public static void DrawRay( Vector3 pos, Vector3 dir, Color color ) { }
        public static void DrawRay( Vector3 pos, Vector3 dir, Color color, float lifetime ) { }
        public static void DrawCross( Vector3 pos, float lineLength, Color color ) { }
        public static void DrawCross( Vector3 pos, float lineLength, Color color, float lifetime ) { }
        public static void DrawCircle( Vector3 centerPos, float radius, Color color, int numSegments = 16 ) { }
        public static void DrawCircle( Vector3 centerPos, float radius, Color color, float lifetime, int numSegments = 16 ) { }
        public static void DrawText( Vector3 pos, string text, Color color, float fontSize, AnchorPosition anchor = AnchorPosition.TopLeft ) { }
        public static void DrawText( Vector3 pos, string text, Color color, float fontSize, float lifetime, AnchorPosition anchor = AnchorPosition.TopLeft ) { }
        public static void DrawText( Vector3 pos, Quaternion rotation, string text, Color color, float fontSize, AnchorPosition anchor = AnchorPosition.TopLeft ) { }
        public static void DrawText( Vector3 pos, Quaternion rotation, string text, Color color, float fontSize, float lifetime, AnchorPosition anchor = AnchorPosition.TopLeft ) { }
#endif
        #endregion // public

        #region private
#if ATLAS_DEBUGDRAW_VISIBLEATSTART
        private static bool m_isEnabled = true;
#else
        private static bool m_isEnabled = false;
#endif

#if ATLAS_DEBUGDRAW_RUNTIME || ( ATLAS_DEBUGDRAW_EDITOR && UNITY_EDITOR )
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
        }

#if UNITY_EDITOR
        // scene view drawing
        private void OnDrawGizmos()
        {
            Draw();
        } 
#endif

        private void OnGUIRender()
        {
            Draw();
        } 

        private void Draw()
        {
            if ( m_material )
            {
                Camera camera = Camera.current;
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