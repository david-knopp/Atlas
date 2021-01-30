using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Atlas.Test
{
    public sealed class BinaryHeapTests
    {
        public sealed class LessIntComparer : IComparer<int>
        {
            public int Compare( int x, int y )
            {
                return x.CompareTo( y );
            }
        }

        public sealed class GreaterIntComparer : IComparer<int>
        {
            public int Compare( int x, int y )
            {
                return y.CompareTo( x );
            }
        }

        [Test]
        [TestCase( 1 )]
        [TestCase( 10 )]
        [TestCase( 1000 )]
        public void Add( int insertCount )
        {
            BinaryHeap<int> heap = new BinaryHeap<int>();

            for ( int i = 0; i < insertCount; i++ )
            {
                heap.Add( i );
            }

            Assert.That( heap.Count == insertCount );
        }

        [Test]
        [TestCase( 1 )]
        [TestCase( 10 )]
        public void PeekMin( int insertCount )
        {
            BinaryHeap<int> heap = new BinaryHeap<int>( new LessIntComparer() );

            for ( int i = 0; i < insertCount; i++ )
            {
                heap.Add( i );
            }

            Assert.That( heap.Peek() == 0 );
        }

        [Test]
        [TestCase( 1 )]
        [TestCase( 10 )]
        public void PeekMax( int insertCount )
        {
            BinaryHeap<int> heap = new BinaryHeap<int>( new GreaterIntComparer() );

            for ( int i = 0; i < insertCount; i++ )
            {
                heap.Add( i );
            }

            Assert.That( heap.Peek() == insertCount - 1 );
        }

        [Test]
        [TestCase( new int[] { 0, 1, 2 } )]
        [TestCase( new int[] { 5, 1, -2, 18, 3, 9 } )]
        [TestCase( new int[] { 14, 8, 1, 3, 1, 16, 45 } )]
        public void PopValue( int[] values )
        {
            BinaryHeap<int> heap = new BinaryHeap<int>();

            foreach ( int value in values )
            {
                heap.Add( value );
            }

            Array.Sort( values );

            for ( int i = 0; i < values.Length; i++ )
            {
                int value = heap.Pop();
                Assert.That( value == values[i] );
            }
        }

        [Test]
        [TestCase( 1 )]
        [TestCase( 10 )]
        public void PopSize( int insertCount )
        {
            BinaryHeap<int> heap = new BinaryHeap<int>();

            for ( int i = 0; i < insertCount; i++ )
            {
                heap.Add( i );
            }

            heap.Pop();

            Assert.That( heap.Count == insertCount - 1 );
        }

        [Test]
        [TestCase( 0 )]
        [TestCase( 10 )]
        public void Clear( int insertCount )
        {
            BinaryHeap<int> heap = new BinaryHeap<int>();

            for ( int i = 0; i < insertCount; i++ )
            {
                heap.Add( i );
            }

            heap.Clear();

            Assert.That( heap.Count == 0 );
        }
    }
}
