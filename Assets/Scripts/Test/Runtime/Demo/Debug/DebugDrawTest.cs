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
            StartCoroutine( RandomizedTextRoutine() );
        }

        private void Update()
        {
            DebugDraw.DrawText( Vector3.up + Vector3.left * 6f, m_text, m_color, m_fontSize );

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

        private IEnumerator RandomizedTextRoutine()
        {
            while ( true )
            {
                yield return new WaitForSeconds( Random.Range( 0f, 1f ) );

                if ( m_randomizedText.Count > 0 )
                {
                    Vector3 offset = Random.insideUnitCircle.normalized;
                    Vector3 spawnPos = new Vector3( m_maxTextSpawnOffset.x * offset.x,
                                                    m_maxTextSpawnOffset.y * offset.y,
                                                    0f );

                    int textIndex = Random.Range( 0, m_randomizedText.Count );

                    DebugDraw.DrawText( spawnPos, m_randomizedText[textIndex], Color.white * 0.7f, m_fontSize * 0.5f, m_drawLifetime ); 
                }
            }
        }
    }
}