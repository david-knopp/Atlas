using System;
using System.Collections.Generic;

namespace Atlas
{
    public class BinaryHeap<T>
    {
        public BinaryHeap()
            : this( Comparer<T>.Default )
        {
        }

        public BinaryHeap( IComparer<T> comparer )
            : this( comparer, 0 )
        {
        }

        public BinaryHeap( IComparer<T> comparer, int capacity )
        {
            m_comparer = comparer;
            m_heap = new List<T>( capacity );
        }

        public int Count { get; private set; }
        public int Capacity => m_heap.Capacity;

        public void Add( T item )
        {
            m_heap.Add( item );
            BubbleUp( Count++ );
        }

        public T Peek()
        {
            if ( Count == 0 )
            {
                throw new InvalidOperationException();
            }

            return m_heap[0];
        }

        public T Pop()
        {
            if ( Count == 0 )
            {
                throw new InvalidOperationException();
            }

            T top = m_heap[0];

            Swap( 0, --Count );
            m_heap.RemoveAt( Count );
            BubbleDown( 0 );

            return top;
        }

        public void Clear()
        {
            Count = 0;
            m_heap.Clear();
        }

        private IComparer<T> m_comparer;
        private readonly List<T> m_heap;

        private int GetParentIndex( int index )
        {
            return ( index - 1 ) / 2;
        }

        private int GetLeftChildIndex( int index )
        {
            return ( 2 * index ) + 1;
        }

        private int GetRightChildIndex( int index )
        {
            return ( 2 * index ) + 2;
        }

        private void BubbleUp( int index )
        {
            while ( index > 0 )
            {
                int parentIndex = GetParentIndex( index );

                if ( m_comparer.Compare( m_heap[index], m_heap[parentIndex] ) >= 0 )
                {
                    break;
                }

                Swap( index, parentIndex );
                index = parentIndex;
            }
        }

        private void BubbleDown( int index )
        {
            while ( index < m_heap.Count )
            {
                int leftChildIndex = GetLeftChildIndex( index );
                int rightChildIndex = GetRightChildIndex( index );

                if ( leftChildIndex >= m_heap.Count )
                {
                    return;
                }
                if ( rightChildIndex >= m_heap.Count ||
                     m_comparer.Compare( m_heap[leftChildIndex], m_heap[rightChildIndex] ) <= 0 )
                {
                    if ( m_comparer.Compare( m_heap[leftChildIndex], m_heap[index] ) >= 0 )
                    {
                        return;
                    }

                    Swap( leftChildIndex, index );
                    index = leftChildIndex;
                }
                else
                {
                    if ( m_comparer.Compare( m_heap[rightChildIndex], m_heap[index] ) >= 0 )
                    {
                        return;
                    }

                    Swap( rightChildIndex, index );
                    index = rightChildIndex;
                }
            }
        }

        private void Swap( int leftIndex, int rightIndex )
        {
            T temp = m_heap[leftIndex];
            m_heap[leftIndex] = m_heap[rightIndex];
            m_heap[rightIndex] = temp;
        }
    }
}
