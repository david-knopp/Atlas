using UnityEngine;

namespace Atlas.Test
{
    public sealed class SimpleOrbit : MonoBehaviour
    {
        [SerializeField] private float m_orbitSpeed;
        [SerializeField] private Vector3 m_pivotPoint;

        private float m_radius;

        private void Start()
        {
            m_radius = Mathf.Max( Vector3.Distance( transform.position, m_pivotPoint ), 0.1f );
        }

        private void Update()
        {
            transform.RotateAround( m_pivotPoint, Vector3.up, m_orbitSpeed * Time.deltaTime );
            transform.LookAt( m_pivotPoint );
        }
    }
}