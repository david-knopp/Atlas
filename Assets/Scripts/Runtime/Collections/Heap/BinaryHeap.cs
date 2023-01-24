using System;
using System.Collections.Generic;

namespace Atlas
{
    /// <summary>
    /// A heap data structure utilizing a binary tree, ensuring that root nodes are >= or <= its children,
    /// determined by the provided <see cref="IComparer<typeparamref name="T"/>"/> object
    /// </summary>
    /// <typeparam name="T">Type of the heap's elements</typeparam>
    public class BinaryHeap<T>
    {
        #region public
        /// <summary>
        /// Constructor
        /// </summary>
        public BinaryHeap()
            : this( Comparer<T>.Default )
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="capacity">The number of elements the heap can hold before resizing</param>
        public BinaryHeap( int capacity )
            : this( Comparer<T>.Default, capacity )
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="comparer">Comparer object to use when comparing elements</param>
        public BinaryHeap( IComparer<T> comparer )
            : this( comparer, 0 )
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="comparer">Comparer object to use when comparing elements</param>
        /// <param name="capacity">The number of elements the heap can hold before resizing</param>
        public BinaryHeap( IComparer<T> comparer, int capacity )
        {
            m_comparer = comparer;
            m_heap = new List<T>( capacity );
        }

        /// <summary>
        /// Number of elements in the heap
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// The total number of elements the internal data structure can hold without resizing
        /// </summary>
        public int Capacity => m_heap.Capacity;

        /// <summary>
        /// Adds the given item to the heap
        /// </summary>
        /// <param name="item">The item to add</param>
        public void Add( T item )
        {
            m_heap.Add( item );
            BubbleUp( Count++ );
        }

        /// <summary>
        /// Gets the item at the root of the heap
        /// </summary>
        /// <returns>The root item</returns>
        /// <exception cref="InvalidOperationException">Thrown if the heap is empty</exception>
        public T Peek()
        {
            if ( Count == 0 )
            {
                throw new InvalidOperationException( "Failed Peeking item in the BinaryHeap: the heap is empty" );
            }

            return m_heap[0];
        }

        /// <summary>
        /// Removes the item at the root of the heap, and returns it
        /// </summary>
        /// <returns>The root item</returns>
        /// <exception cref="InvalidOperationException">Thrown if the heap is emptyu</exception>
        public T Pop()
        {
            if ( Count == 0 )
            {
                throw new InvalidOperationException( "Failed Popping item from the BinaryHeap: the heap is empty" );
            }

            T top = m_heap[0];

            Swap( 0, --Count );
            m_heap.RemoveAt( Count );
            BubbleDown( 0 );

            return top;
        }

        /// <summary>
        /// Removes all items from the heap
        /// </summary>
        public void Clear()
        {
            Count = 0;
            m_heap.Clear();
        } 
        #endregion public

        #region private
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
        #endregion private
    }
}
