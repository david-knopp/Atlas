using UnityEngine;

namespace Atlas.Examples
{
    public sealed class Example_Ease : MonoBehaviour
    {
        [SerializeField] private Vector3 m_initialRotation;
        [SerializeField] private Vector3 m_finalRotation;
        [SerializeField] private Ease m_ease;

        private void Update()
        {
            // get normalized time on [0, 1], wrapping every 2 seconds
            float t = ( Time.time % 2f ) / 2f;

            // ease between rotations
            transform.rotation = m_ease.Interpolate( Quaternion.Euler( m_initialRotation ),
                                                     Quaternion.Euler( m_finalRotation ),
                                                     t );
        }
    }
}
