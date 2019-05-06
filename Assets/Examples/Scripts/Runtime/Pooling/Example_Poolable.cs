using UnityEngine;

namespace Atlas.Examples
{
    [RequireComponent( typeof( Rigidbody ) )]
    public sealed class Example_Poolable : MonoBehaviour, IPoolable
    {
        public void OnPoolInstantiate()
        {
            m_rigidbody.AddForce( m_spawnForce, ForceMode.Impulse );
        }

        public void OnPoolDestroy()
        {
            m_rigidbody.velocity = Vector3.zero;
            m_rigidbody.angularVelocity = Vector3.zero;
        }

        [SerializeField] private Vector3 m_spawnForce = Vector3.up * 10f;

        private Rigidbody m_rigidbody;

        private void Awake()
        {
            m_rigidbody = GetComponent<Rigidbody>();
        }
    }
}
