using UnityEngine;
using System.Collections.Generic;
using System.Collections;

namespace Atlas.Test
{
    public sealed class DebugDrawTest : MonoBehaviour
    {
        [SerializeField] private Color m_color;
        [SerializeField, MinValue( 0.0f )] private float m_drawLifetime;
        [Header( "Text" )]
        [SerializeField, TextArea] private string m_text;
        [SerializeField] private float m_fontSize = 1f;
        [SerializeField] private List<string> m_randomizedText;
        [SerializeField] private Vector3 m_maxTextSpawnOffset = Vector3.one * 5f;

        private Vector3 m_startPoint;
        private Vector3 m_endPoint;

        private void Start()
        {
            StartCoroutine( SpawnRandomTextRoutine() );
            StartCoroutine( SpawnRandomPrimitiveRoutine() );
        }

        private void Update()
        {
            DebugDraw.DrawText( Vector3.zero, Quaternion.identity, m_text, m_color, m_fontSize, AnchorPosition.Center );

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
                    DebugDraw.DrawRectangle( Camera.main.ScreenToWorldPoint( pos ), 0.5f, 0.5f, m_color, m_drawLifetime );
                }
            }
        }

        private static Color GetRandomColor()
        {
            return Random.ColorHSV( .0f, 1f, 0.4f, .8f, 0.7f, 1f );
        }

        private IEnumerator SpawnRandomTextRoutine()
        {
            while ( true )
            {
                yield return new WaitForSeconds( Random.Range( 0f, .5f ) );

                if ( m_randomizedText.Count > 0 )
                {
                    Vector3 offset = Random.insideUnitSphere * 2f;
                    Vector3 spawnPos = new Vector3( m_maxTextSpawnOffset.x * offset.x,
                                                    m_maxTextSpawnOffset.y * offset.y,
                                                    m_maxTextSpawnOffset.z * offset.z );

                    int textIndex = Random.Range( 0, m_randomizedText.Count );

                    DebugDraw.DrawText( spawnPos, 
                                        m_randomizedText[textIndex],
                                        GetRandomColor(), 
                                        Random.Range( m_fontSize * 0.2f, m_fontSize * 0.7f ), 
                                        m_drawLifetime,
                                        AnchorPosition.Center ); 
                }
            }
        }

        private IEnumerator SpawnRandomPrimitiveRoutine()
        {
            while ( true )
            {
                yield return new WaitForSeconds( Random.Range( 0f, .2f ) );
                
                Vector3 offset = Random.insideUnitSphere * 2f;
                Vector3 spawnPos = new Vector3( m_maxTextSpawnOffset.x * offset.x,
                                                m_maxTextSpawnOffset.y * offset.y,
                                                m_maxTextSpawnOffset.z * offset.z );

                float scale = Random.Range( 0.1f, 0.5f );
                
                switch ( Random.Range( 0, 3 ) )
                {
                default:
                case 0:
                    DebugDraw.DrawRectangle( spawnPos, Random.rotation, scale, scale, GetRandomColor(), m_drawLifetime );
                    break;

                case 1:
                    DebugDraw.DrawCircle( spawnPos, Random.rotation, scale, GetRandomColor(), m_drawLifetime );
                    break;

                case 2:
                    DebugDraw.DrawCross( spawnPos, Random.rotation, scale, GetRandomColor(), m_drawLifetime );
                    break;
                }
            }
        }
    }
}
