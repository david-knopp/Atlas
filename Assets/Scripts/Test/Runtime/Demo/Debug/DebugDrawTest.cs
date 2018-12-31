using UnityEngine;

namespace Atlas.Test
{
    public sealed class DebugDrawTest : MonoBehaviour
    {
        [SerializeField] private Color m_color;
        [SerializeField, MinValue( 0.0f )] private float m_drawLifetime;

        private Vector3 m_startPoint;
        private Vector3 m_endPoint;

        private void Update()
        {
            if ( Input.GetMouseButtonDown( 0 ) )
            {
                if ( Camera.main )
                {
                    Vector3 pos = Input.mousePosition;
                    pos.z = 10.0f;
                    m_startPoint = Camera.main.ScreenToWorldPoint( pos );
                }
            }
            else if ( Input.GetMouseButton( 0 ) )
            {
                if ( Camera.main )
                {
                    Vector3 pos = Input.mousePosition;
                    pos.z = 10.0f;
                    m_endPoint = Camera.main.ScreenToWorldPoint( pos );

                    DebugDraw.DrawCircle( m_startPoint, 0.5f, m_color );
                    DebugDraw.DrawLine( m_startPoint, m_endPoint, Color.white );
                    DebugDraw.DrawCross( m_endPoint, 0.25f, m_color );
                }
            }
            else if ( Input.GetMouseButtonUp( 0 ) )
            {
                DebugDraw.DrawLine( m_startPoint, m_endPoint, m_color, m_drawLifetime );
            }

            if ( Input.GetMouseButtonDown( 1 ) )
            {
                if ( Camera.main )
                {
                    Vector3 pos = Input.mousePosition;
                    pos.z = 10.0f;
                    DebugDraw.DrawCross( Camera.main.ScreenToWorldPoint( pos ), 0.5f, m_color, m_drawLifetime );
                }
            }
        }
    }
}