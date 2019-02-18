using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Atlas
{
    /// <summary>
    /// A system for rendering debug elements in the game view, as well as the scene view.
    /// Options to enable in the editor or in standalone builds can be found in the Atlas
    /// preferences window.
    /// </summary>
    public sealed class DebugDraw : SingletonBehavior<DebugDraw>
    {
        #region public
        /// <summary>
        /// Whether or not the system is enabled
        /// </summary>
        public static bool IsEnabled
        {
            get { return m_isEnabled; }
            set { m_isEnabled = value; }
        }

#if ATLAS_DEBUGDRAW_RUNTIME || ( ATLAS_DEBUGDRAW_EDITOR && UNITY_EDITOR )
        /// <summary>
        /// Draws a debug line
        /// </summary>
        /// <param name="startPos">Starting point of the line (in world space)</param>
        /// <param name="endPos">Ending point of the line (in world space)</param>
        /// <param name="color">Color of the line</param>
        public static void DrawLine( Vector3 startPos, Vector3 endPos, Color color )
        {
            if ( IsEnabled )
            {
                Instance.m_drawers.Add( new LineDebugDrawer( startPos, endPos, color ) );
            }
        }

        /// <summary>
        /// Draws a debug line for the given amount of time
        /// </summary>
        /// <param name="startPos">Starting point of the line (in world space)</param>
        /// <param name="endPos">Ending point of the line (in world space)</param>
        /// <param name="color">Color of the line</param>
        /// <param name="lifetime">Length of time to draw the line (in seconds)</param>
        public static void DrawLine( Vector3 startPos, Vector3 endPos, Color color, float lifetime )
        {
            if ( IsEnabled )
            {
                Instance.m_drawers.Add( new LineDebugDrawer( startPos, endPos, color ).Timed( lifetime ) );
            }
        }

        /// <summary>
        /// Draws a debug ray
        /// </summary>
        /// <param name="position">Starting point of the ray (in world space)</param>
        /// <param name="direction">Direction and magnitude of the ray (in world space)</param>
        /// <param name="color">Color of the lirayne</param>
        public static void DrawRay( Vector3 position, Vector3 direction, Color color )
        {
            if ( IsEnabled )
            {
                Instance.m_drawers.Add( new LineDebugDrawer( position, position + direction, color ) );
            }
        }

        /// <summary>
        /// Draws a debug ray for the given amount of time
        /// </summary>
        /// <param name="position">Starting point of the ray (in world space)</param>
        /// <param name="direction">Direction and magnitude of the ray (in world space)</param>
        /// <param name="color">Color of the lirayne</param>
        /// <param name="lifetime">Length of time to draw the ray (in seconds)</param>
        public static void DrawRay( Vector3 position, Vector3 direction, Color color, float lifetime )
        {
            if ( IsEnabled )
            {
                Instance.m_drawers.Add( new LineDebugDrawer( position, position + direction, color ).Timed( lifetime ) );
            }
        }

        /// <summary>
        /// Draws a debug cross (X), billboarded to the current camera
        /// </summary>
        /// <param name="position">Position of the cross (in world space)</param>
        /// <param name="lineLength">Length of each line</param>
        /// <param name="color">Color of the cross</param>
        public static void DrawCross( Vector3 position, float lineLength, Color color )
        {
            if ( IsEnabled )
            {
                Instance.m_drawers.Add( new CrossDebugDrawer( lineLength, color ).Billboarded( position ) );
            }
        }

        /// <summary>
        /// Draws a debug cross (X) for the given amount of time, billboarded to the current camera
        /// </summary>
        /// <param name="position">Position of the cross (in world space)</param>
        /// <param name="lineLength">Length of each line</param>
        /// <param name="color">Color of the cross</param>
        /// <param name="lifetime">Length of time to draw the cross (in seconds)</param>
        public static void DrawCross( Vector3 position, float lineLength, Color color, float lifetime )
        {
            if ( IsEnabled )
            {
                Instance.m_drawers.Add( new CrossDebugDrawer( lineLength, color ).Billboarded( position ).Timed( lifetime ) );
            }
        }

        /// <summary>
        /// Draws a debug cross (X)
        /// </summary>
        /// <param name="position">Position of the cross (in world space)</param>
        /// <param name="rotation">Rotation of the cross (in world space)</param>
        /// <param name="lineLength">Length of each line</param>
        /// <param name="color">Color of the cross</param>
        /// <param name="lifetime">Length of time to draw the cross (in seconds)</param>
        public static void DrawCross( Vector3 position, Quaternion rotation, float lineLength, Color color )
        {
            if ( IsEnabled )
            {
                Instance.m_drawers.Add( new CrossDebugDrawer( lineLength, color ).Transformed( position, rotation ) );
            }
        }

        /// <summary>
        /// Draws a debug cross (X) for the given amount of time
        /// </summary>
        /// <param name="position">Position of the cross (in world space)</param>
        /// <param name="rotation">Rotation of the cross (in world space)</param>
        /// <param name="lineLength">Length of each line</param>
        /// <param name="color">Color of the cross</param>
        /// <param name="lifetime">Length of time to draw the cross (in seconds)</param>
        public static void DrawCross( Vector3 position, Quaternion rotation, float lineLength, Color color, float lifetime )
        {
            if ( IsEnabled )
            {
                Instance.m_drawers.Add( new CrossDebugDrawer( lineLength, color ).Transformed( position, rotation ).Timed( lifetime ) );
            }
        }

        /// <summary>
        /// Draws a debug circle, billboarded to the current camera
        /// </summary>
        /// <param name="position">Position of the circle (in world space)</param>
        /// <param name="radius">Radius of the circle</param>
        /// <param name="color">Color of the circle</param>
        /// <param name="numSegments">Number of segments to construct the circle with, e.g. 3 segments would form a triangle</param>
        public static void DrawCircle( Vector3 position, float radius, Color color, int numSegments = 16 )
        {
            if ( IsEnabled )
            {
                Instance.m_drawers.Add( new CircleDebugDrawer( radius, color, numSegments ).Billboarded( position ) );
            }
        }

        /// <summary>
        /// Draws a debug circle for the given amount of time, billboarded to the current camera
        /// </summary>
        /// <param name="position">Position of the circle (in world space)</param>
        /// <param name="radius">Radius of the circle</param>
        /// <param name="color">Color of the circle</param>
        /// <param name="lifetime">Length of time to draw the cross (in seconds)</param>
        /// <param name="numSegments">Number of segments to construct the circle with, e.g. 3 segments would form a triangle</param>
        public static void DrawCircle( Vector3 position, float radius, Color color, float lifetime, int numSegments = 16 )
        {
            if ( IsEnabled )
            {
                Instance.m_drawers.Add( new CircleDebugDrawer( radius, color, numSegments ).Billboarded( position ).Timed( lifetime ) );
            }
        }

        /// <summary>
        /// Draws a debug circle
        /// </summary>
        /// <param name="position">Position of the circle (in world space)</param>
        /// <param name="rotation">Rotation of the circle (in world space)</param>
        /// <param name="radius">Radius of the circle</param>
        /// <param name="color">Color of the circle</param>
        /// <param name="numSegments">Number of segments to construct the circle with, e.g. 3 segments would form a triangle</param>
        public static void DrawCircle( Vector3 position, Quaternion rotation, float radius, Color color, int numSegments = 16 )
        {
            if ( IsEnabled )
            {
                Instance.m_drawers.Add( new CircleDebugDrawer( radius, color, numSegments ).Transformed( position, rotation ) );
            }
        }

        /// <summary>
        /// Draws a debug circle for the given amount of time
        /// </summary>
        /// <param name="position">Position of the circle (in world space)</param>
        /// <param name="rotation">Rotation of the circle (in world space)</param>
        /// <param name="radius">Radius of the circle</param>
        /// <param name="color">Color of the circle</param>
        /// <param name="lifetime">Length of time to draw the circle (in seconds)</param>
        /// <param name="numSegments">Number of segments to construct the circle with, e.g. 3 segments would form a triangle</param>
        public static void DrawCircle( Vector3 position, Quaternion rotation, float radius, Color color, float lifetime, int numSegments = 16 )
        {
            if ( IsEnabled )
            {
                Instance.m_drawers.Add( new CircleDebugDrawer( radius, color, numSegments ).Transformed( position, rotation ).Timed( lifetime ) );
            }
        }

        /// <summary>
        /// Draws a rectangle, billboarded to the current camera
        /// </summary>
        /// <param name="position">Position of the rectangle (in world space)</param>
        /// <param name="width">Width of the rectangle</param>
        /// <param name="height">Height of the rectangle</param>
        /// <param name="color">Color of the rectangle</param>
        public static void DrawRectangle( Vector3 position, float width, float height, Color color )
        {
            if ( IsEnabled )
            {
                Instance.m_drawers.Add( new RectangleDebugDrawer( width, height, color ).Billboarded( position ) );
            }
        }

        /// <summary>
        /// Draws a rectangle for the given amount of time, billboarded to the current camera
        /// </summary>
        /// <param name="position">Position of the rectangle (in world space)</param>
        /// <param name="width">Width of the rectangle</param>
        /// <param name="height">Height of the rectangle</param>
        /// <param name="color">Color of the rectangle</param>
        /// <param name="lifetime">Length of time to draw the rectangle (in seconds)</param>
        public static void DrawRectangle( Vector3 position, float width, float height, Color color, float lifetime )
        {
            if ( IsEnabled )
            {
                Instance.m_drawers.Add( new RectangleDebugDrawer( width, height, color ).Billboarded( position ).Timed( lifetime ) );
            }
        }

        /// <summary>
        /// Draws a rectangle
        /// </summary>
        /// <param name="position">Position of the rectangle (in world space)</param>
        /// <param name="rotation">Rotation of the rectangle (in world space)</param>
        /// <param name="width">Width of the rectangle</param>
        /// <param name="height">Height of the rectangle</param>
        /// <param name="color">Color of the rectangle</param>
        public static void DrawRectangle( Vector3 position, Quaternion rotation, float width, float height, Color color )
        {
            if ( IsEnabled )
            {
                Instance.m_drawers.Add( new RectangleDebugDrawer( width, height, color ).Transformed( position, rotation ) );
            }
        }

        /// <summary>
        /// Draws a rectangle for the given amount of time
        /// </summary>
        /// <param name="position">Position of the rectangle (in world space)</param>
        /// <param name="rotation">Rotation of the rectangle (in world space)</param>
        /// <param name="width">Width of the rectangle</param>
        /// <param name="height">Height of the rectangle</param>
        /// <param name="color">Color of the rectangle</param>
        /// <param name="lifetime">Length of time to draw the rectangle (in seconds)</param>
        public static void DrawRectangle( Vector3 position, Quaternion rotation, float width, float height, Color color, float lifetime )
        {
            if ( IsEnabled )
            {
                Instance.m_drawers.Add( new RectangleDebugDrawer( width, height, color ).Transformed( position, rotation ).Timed( lifetime ) );
            }
        }

        /// <summary>
        /// Draws a string of text, billboarded to the current camera
        /// </summary>
        /// <param name="position">Position of the text's anchor (in world space)</param>
        /// <param name="text">Text to display</param>
        /// <param name="color">Color of the text</param>
        /// <param name="fontSize">Size of the text's characters</param>
        /// <param name="anchor">Position of the text's anchor. The text will be positioned relative to this position</param>
        public static void DrawText( Vector3 position, string text, Color color, float fontSize, AnchorPosition anchor = AnchorPosition.TopLeft )
        {
            if ( IsEnabled )
            {
                Instance.m_drawers.Add( new TextDebugDrawer( text, color, fontSize, anchor ).Billboarded( position ) );
            }
        }

        /// <summary>
        /// Draws a string of text for the given amount of time, billboarded to the current camera
        /// </summary>
        /// <param name="position">Position of the text's anchor (in world space)</param>
        /// <param name="text">Text to display</param>
        /// <param name="color">Color of the text</param>
        /// <param name="fontSize">Size of the text's characters</param>
        /// <param name="lifetime">Length of time to draw the text (in seconds)</param>
        /// <param name="anchor">Position of the text's anchor. The text will be positioned relative to this position</param>
        public static void DrawText( Vector3 position, string text, Color color, float fontSize, float lifetime, AnchorPosition anchor = AnchorPosition.TopLeft )
        {
            if ( IsEnabled )
            {
                Instance.m_drawers.Add( new TextDebugDrawer( text, color, fontSize, anchor ).Billboarded( position ).Timed( lifetime ) );
            }
        }

        /// <summary>
        /// Draws a string of text
        /// </summary>
        /// <param name="position">Position of the text's anchor (in world space)</param>
        /// <param name="rotation">Rotation of the text (in world space)</param>
        /// <param name="text">Text to display</param>
        /// <param name="color">Color of the text</param>
        /// <param name="fontSize">Size of the text's characters</param>
        /// <param name="anchor">Position of the text's anchor. The text will be positioned relative to this position</param>
        public static void DrawText( Vector3 position, Quaternion rotation, string text, Color color, float fontSize, AnchorPosition anchor = AnchorPosition.TopLeft )
        {
            if ( IsEnabled )
            {
                Instance.m_drawers.Add( new TextDebugDrawer( text, color, fontSize, anchor ).Transformed( position, rotation ) );
            }
        }

        /// <summary>
        /// Draws a string of text for the given amount of time
        /// </summary>
        /// <param name="position">Position of the text's anchor (in world space)</param>
        /// <param name="rotation">Rotation of the text (in world space)</param>
        /// <param name="text">Text to display</param>
        /// <param name="color">Color of the text</param>
        /// <param name="fontSize">Size of the text's characters</param>
        /// <param name="lifetime">Length of time to draw the text (in seconds)</param>
        /// <param name="anchor">Position of the text's anchor. The text will be positioned relative to this position</param>
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
        private WaitForEndOfFrame m_endOfFrameYield = new WaitForEndOfFrame();

        private void OnEnable()
        {
            StartCoroutine( FlushFinishedDrawersRoutine() );
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

        private void OnRenderObject()
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
                        }
                    }

                    GL.PopMatrix();
                }
            }
        }

        private IEnumerator FlushFinishedDrawersRoutine()
        {
            while ( true )
            {
                for ( int i = m_drawers.Count - 1; i >= 0; --i )
                {
                    IDebugDrawer drawable = m_drawers[i];
                    if ( drawable == null || 
                         drawable.IsFinished )
                    {
                        m_drawers.RemoveAt( i );
                    }
                }

                yield return m_endOfFrameYield;
            }
        }
#endif
        #endregion // private
    }
}
