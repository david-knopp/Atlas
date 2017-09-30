using System.Collections;
using UnityEngine;

namespace Atlas.Test
{
    public class EasingTests : MonoBehaviour
    {
        [SerializeField] private Ease m_ease;
        [SerializeField] private float m_duration;
        [SerializeField] private Transform m_target;
        [SerializeField] private Vector3 m_goalPos;

        private bool m_atGoal;
        private Vector3 m_initialPos;

        private void Awake()
        {
            m_initialPos = m_target.position;
        }

        private void OnGUI()
        {
            if ( GUILayout.Button( "Run Ease" ) )
            {
                StopAllCoroutines();
                StartCoroutine( EaseCoroutine( m_atGoal ? m_initialPos : m_goalPos) );
                m_atGoal = !m_atGoal;
            }
        }

        private IEnumerator EaseCoroutine( Vector3 goalPos )
        {
            Vector3 startPos = m_target.position;
            Vector3 deltaPos = goalPos - startPos;

            Timer timer = new Timer();
            timer.Start();
            float t = 0.0f;

            while ( t < m_duration )
            {
                m_target.position = startPos + m_ease.Evaluate( t, m_duration ) * deltaPos;
                yield return null;

                t = timer.Elapsed;
            }

            m_target.position = goalPos;
        }
    }
}