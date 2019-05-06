using NUnit.Framework;
using System;
using UnityEngine;

using RangeAttribute = NUnit.Framework.RangeAttribute;

namespace Atlas.Test
{
    public sealed class PrefabPoolTests
    {
        [Test]
        public void Instantiate( [Range( 1, 10 )] int iterationCount )
        {
            PrefabPool pool = new PrefabPool( null );
            var prefab = GetMockPrefab();

            var testInstance = pool.Instantiate( prefab );

            for ( int i = 1; i < iterationCount; i++ )
            {
                pool.Destroy( testInstance );
                testInstance = pool.Instantiate( prefab ); 
            }

            Assert.That( testInstance.OnPoolInstantiateCallCount == iterationCount );
        }

        [Test]
        public void Destroy()
        {
            PrefabPool pool = new PrefabPool( null );

            var testInstance = pool.Instantiate( GetMockPrefab() );
            pool.Destroy( testInstance );

            Assert.That( testInstance.OnPooDestroyCallCount == 1 );
        }

        [Test]
        public void DestroyInvalid()
        {
            PrefabPool pool = new PrefabPool( null );

            var testInstance = GetMockPrefab();

            Assert.That( () => pool.Destroy( testInstance ), Throws.InvalidOperationException );
        }

        [Test]
        public void Pool( [Range( 10, 100, 10 )] int numIterations )
        {
            PrefabPool pool = new PrefabPool( null );
            var prefab = GetMockPrefab();
            MockBehavior.ObjectCount = 0;

            for ( int i = 0; i < numIterations; i++ )
            {
                var instance = pool.Instantiate( prefab );
                pool.Destroy( instance );
            }

            Assert.That( MockBehavior.ObjectCount == 1 );
        }

        [Test]
        public void PreloadObjects( [Range( 10, 100, 10 )] int preloadCount )
        {

            PrefabPool pool = new PrefabPool( null );
            var prefab = GetMockPrefab();
            MockBehavior.ObjectCount = 0;
            MockBehavior.GlobalOnPoolInstantiateCallCount = 0;

            pool.PreloadObjects( prefab, preloadCount );

            Assert.That( MockBehavior.ObjectCount == preloadCount );
            Assert.That( MockBehavior.GlobalOnPoolInstantiateCallCount == 0 );

            for ( int i = 0; i < preloadCount; i++ )
            {
                pool.Instantiate( prefab );
            }

            Assert.That( MockBehavior.ObjectCount == preloadCount );
            Assert.That( MockBehavior.GlobalOnPoolInstantiateCallCount == preloadCount );
        }

        private sealed class MockBehavior : MonoBehaviour, IPoolable
        {
            public static int ObjectCount
            {
                get;
                set;
            }

            public static int GlobalOnPoolInstantiateCallCount
            {
                get;
                set;
            }

            public MockBehavior()
            {
                ObjectCount++;
            }

            public int OnPoolInstantiateCallCount
            {
                get;
                private set;
            }

            public int OnPooDestroyCallCount
            {
                get;
                private set;
            }

            public void OnPoolInstantiate()
            {
                OnPoolInstantiateCallCount++;
                GlobalOnPoolInstantiateCallCount++;
            }

            public void OnPoolDestroy()
            {
                OnPooDestroyCallCount++;
            }
        }

        private MockBehavior GetMockPrefab()
        {
            GameObject prefabObj = new GameObject();
            return prefabObj.AddComponent<MockBehavior>();
        }
    }
}