using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Atlas.Examples
{
    public class Example_PrefabPool : MonoBehaviour
    {
        [SerializeField] private Example_Poolable m_prefab;
        [SerializeField] private Transform m_activeObjectsRoot;
        [SerializeField, Range( 0f, 10f )] private float m_spawnPeriod = 1f;
        [SerializeField, Range( 0f, 10f )] private float m_objectLifetime = 0.5f;

        private PrefabPool m_pool;

        private void Start()
        {
            m_pool = new PrefabPool( transform );

            StartCoroutine( SpawnRoutine() );
        }

        private IEnumerator SpawnRoutine()
        {
            while ( true )
            {
                yield return new WaitForSeconds( m_spawnPeriod );
                var obj = m_pool.Instantiate( m_prefab, m_activeObjectsRoot, true );
                StartCoroutine( DestroyRoutine( obj ) );
            }
        }

        private IEnumerator DestroyRoutine( Example_Poolable obj )
        {
            yield return new WaitForSeconds( m_objectLifetime );
            m_pool.Destroy( obj );
        }

        private void OnGUI()
        {
            GUILayout.Label( string.Format( "Object Count: {0}", m_pool.ObjectCount ) );
        }
    }
}
