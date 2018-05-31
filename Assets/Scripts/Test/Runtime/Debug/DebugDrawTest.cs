using UnityEngine;

namespace Atlas.Test
{
    public class DebugDrawTest : MonoBehaviour
    {
        [SerializeField] private Color m_color;
        [SerializeField] private Vector3 m_startPoint;
        [SerializeField] private Vector3 m_endPoint;
        [SerializeField, MinValue( 0.0f )] private float m_mouseClickLifetime;

        private void Update()
        {
            DebugDraw.DrawLine( m_startPoint, m_endPoint, m_color );

            if ( Input.GetMouseButtonDown( 0 ) )
            {
                if ( Camera.main )
                {
                    Vector3 pos = Input.mousePosition;
                    pos.z = 10.0f;
                    DebugDraw.DrawCircle( Camera.main.ScreenToWorldPoint( pos ), 0.5f, m_color, m_mouseClickLifetime );
                }
            }

            if ( Input.GetMouseButtonDown( 1 ) )
            {
                if ( Camera.main )
                {
                    Vector3 pos = Input.mousePosition;
                    pos.z = 10.0f;
                    DebugDraw.DrawCross( Camera.main.ScreenToWorldPoint( pos ), 0.5f, m_color, m_mouseClickLifetime );
                }
            }
        }
    }
}