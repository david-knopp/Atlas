using System;
using System.Collections.Generic;
using UnityEngine;

using Object = UnityEngine.Object;

namespace Atlas
{
    public sealed class PrefabPool
    {
        #region public
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="pooledObjectsParent">Transform to use for parenting objects currently in the pool's reserve</param>
        public PrefabPool( Transform pooledObjectsParent )
        {
            m_objectPool = new Dictionary<Object, Queue<Object>>();
            m_poolTypeLookup = new Dictionary<Object, Object>();
            m_pooledObjectsParent = pooledObjectsParent;
        }

        /// <summary>
        /// Instantiates a specified number of objects for the given prefab. This can help eliminate runtime performance hits by
        /// front-loading object creation (on level load, for instance).
        /// </summary>
        /// <typeparam name="T">Type of prefab</typeparam>
        /// <param name="prefab">Object prefab to make copies of</param>
        /// <param name="count">Number of objects to instantiate</param>
        public void PreloadObjects<T>( T prefab, int count ) where T : Component
        {
            Queue<Object> pooledObjects = GetOrCreatePoolForPrefab( prefab );

            for ( int i = 0; i < count; i++ )
            {
                T instance = Object.Instantiate( prefab, m_pooledObjectsParent );
                instance.gameObject.SetActive( false );
                pooledObjects.Enqueue( instance );
            }
        }

        /// <summary>
        /// Returns an instanced copy of the given prefab object. If the pool is empty, a new object will be instantiated, otherwise
        /// a recycled object will be re-used.
        /// </summary>
        /// <remarks>
        /// Awake/Start will not get called on recycled objects. Instead, use <see cref="IPoolable.OnPoolInstantiate"/> for per-object startup code
        /// </remarks>
        /// <typeparam name="T">The object's prefab type</typeparam>
        /// <param name="prefab">Object prefab to make a copy of</param>
        /// <param name="position">Position of the new object</param>
        /// <param name="rotation">Orientation of the new object</param>
        /// <param name="parent">Parent that will be assigned to the new object</param>
        /// <returns>The instantiated/recycled clone</returns>
        public T Instantiate<T>( T prefab, Vector3 position, Quaternion rotation, Transform parent ) where T : Component, IPoolable
        {
            Queue<Object> pooledObjects = GetOrCreatePoolForPrefab( prefab );
            T instance;

            // pull from pool
            if ( pooledObjects.Count > 0 )
            {
                instance = pooledObjects.Dequeue() as T;
                Transform objTrans = instance.transform;
                objTrans.SetPositionAndRotation( position, rotation );

                instance.transform.SetParent( parent );
                instance.gameObject.SetActive( true );
            }
            // create new instance
            else
            {
                instance = Object.Instantiate( prefab, position, rotation, parent );
            }

            IPoolable poolable = instance as IPoolable;
            poolable.OnPoolInstantiate();

            m_poolTypeLookup[instance] = prefab;

            return instance;
        }

        /// <summary>
        /// Returns the given object instance to the pool for recycling
        /// </summary>
        /// <remarks>
        /// OnDestroy will not get called when returning objects to the pool. Instead, use <see cref="IPoolable.OnPoolDestroy"/> for per-object cleanup code
        /// </remarks>
        /// <typeparam name="T">The object's prefab type</typeparam>
        /// <param name="instance">The instance to return to the pool</param>
        public void Destroy<T>( T instance ) where T : Component, IPoolable
        {
            Object prefabKey;
            if ( m_poolTypeLookup.TryGetValue( instance, out prefabKey ) )
            {
                IPoolable poolable = instance as IPoolable;
                poolable.OnPoolDestroy();

                instance.gameObject.SetActive( false );
                instance.transform.SetParent( m_pooledObjectsParent );

                Queue<Object> pooledObjects = GetOrCreatePoolForPrefab( prefabKey );
                pooledObjects.Enqueue( instance );
            }
            else
            {
                throw new InvalidOperationException( string.Format( "The given object ({0}) cannot be destroyed by this pool, since it was instantiated externally.", instance.name ) );
            }
        }
        #endregion public

        #region private        
        private Dictionary<Object, Queue<Object>> m_objectPool;
        private Dictionary<Object, Object> m_poolTypeLookup;
        private Transform m_pooledObjectsParent;

        private Queue<Object> GetOrCreatePoolForPrefab( Object prefab )
        {
            Queue<Object> pooledObjects;

            if ( !m_objectPool.TryGetValue( prefab, out pooledObjects ) )
            {
                pooledObjects = new Queue<Object>();
                m_objectPool.Add( prefab, pooledObjects );
            }

            return pooledObjects;
        }
        #endregion private
    }
}
