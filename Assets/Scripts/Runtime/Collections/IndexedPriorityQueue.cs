using System;
using UnityEngine.Assertions;

namespace Atlas
{
    /// <summary>
    /// Generic priority queue data structure, providing random access to its elements
    /// </summary>
    /// <typeparam name="T">Type of contained elements</typeparam>
    public sealed class IndexedPriorityQueue<T> where T : IComparable<T>
    {
        #region public
        /// <summary>
        /// Current number of elements in the queue
        /// </summary>
        public int Count
        {
            get;
            private set;
        }

        /// <summary>
        /// Accesses the element at the given index
        /// </summary>
        /// <param name="index">Index of the element to access</param>
        /// <returns>The value at the given index</returns>
        public T this[int index]
        {
            get
            {
                Assert.IsTrue( index < m_objects.Length && index >= 0, 
                               string.Format( "IndexedPriorityQueue.[]: Index '{0}' out of range", index ) );
                return m_objects[index];
            }

            set
            {
                Assert.IsTrue( index < m_objects.Length && index >= 0, 
                               string.Format( "IndexedPriorityQueue.[]: Index '{0}' out of range", index ) );
                Set( index, value );
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public IndexedPriorityQueue()
        {
            Resize( 1 );
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="maxSize">Max number of elements the queue can contain</param>
        public IndexedPriorityQueue( int maxSize )
        {
            Resize( maxSize );
        }

        /// <summary>
        /// Inserts a new value with the given index
        /// </summary>
        /// <param name="index">index to insert at</param>
        /// <param name="value">value to insert</param>
        public void Insert( int index, T value )
        {
            Assert.IsTrue( index < m_objects.Length && index >= 0, 
                           string.Format( "IndexedPriorityQueue.Insert: Index '{0}' out of range", index ) );

            ++Count;

            // add object
            m_objects[index] = value;

            // add to heap
            m_heapInverse[index] = Count;
            m_heap[Count] = index;

            // update heap
            SortHeapUpward( Count );
        }

        /// <summary>
        /// Gets the top element of the queue
        /// </summary>
        /// <returns>The top element</returns>
        public T Top()
        {
            // top of heap [first element is 1, not 0]
            return m_objects[m_heap[1]];
        }

        /// <summary>
        /// Removes the top element from the queue
        /// </summary>
        /// <returns>The removed element</returns>
        public T Pop()
        {
            Assert.IsTrue( Count > 0, "IndexedPriorityQueue.Pop: Queue is empty" );

            if ( Count == 0 )
            {
                return default( T );
            }

            // swap front to back for removal
            Swap( 1, Count-- );

            // re-sort heap
            SortHeapDownward( 1 );

            // return popped object
            return m_objects[m_heap[Count + 1]];
        }

        /// <summary>
        /// Updates the value at the given index. Note that this function is not
        /// as efficient as the DecreaseIndex/IncreaseIndex methods, but is
        /// best when the value at the index is not known
        /// </summary>
        /// <param name="index">Index of the value to set</param>
        /// <param name="newValue">New value</param>
        /// <remarks>This will cause either an upward or downard sort of the internal heap</remarks>
        public void Set( int index, T newValue )
        {
            if ( newValue.CompareTo( m_objects[index] ) <= 0 )
            {
                DecreaseValueAtIndex( index, newValue );
            }
            else
            {
                IncreaseValueAtIndex( index, newValue );
            }
        }

        /// <summary>
        /// Decreases the value at the current index to the given value
        /// </summary>
        /// <param name="index">Index to decrease value of</param>
        /// <param name="decreasedValue">New value</param>
        /// <remarks>This will cause an upward sort of the internal heap</remarks>
        public void DecreaseValueAtIndex( int index, T decreasedValue )
        {
            Assert.IsTrue( index < m_objects.Length && index >= 0, 
                           string.Format( "IndexedPriorityQueue.DecreaseIndex: Index '{0}' out of range", 
                           index ) );
            Assert.IsTrue( decreasedValue.CompareTo( m_objects[index] ) <= 0, 
                           string.Format( "IndexedPriorityQueue.DecreaseIndex: object '{0}' isn't less than current value '{1}'", 
                           decreasedValue, m_objects[index] ) );

            m_objects[index] = decreasedValue;
            SortUpward( index );
        }

        /// <summary>
        /// Increases the value at the current index to the given value
        /// </summary>
        /// <param name="index">Index to increase value of</param>
        /// <param name="increasedValue">New value</param>
        /// <remarks>This will cause a downward sort of the internal heap</remarks>
        public void IncreaseValueAtIndex( int index, T increasedValue )
        {
            Assert.IsTrue( index < m_objects.Length && index >= 0, 
                          string.Format( "IndexedPriorityQueue.DecreaseIndex: Index '{0}' out of range", 
                          index ) );
            Assert.IsTrue( increasedValue.CompareTo( m_objects[index] ) >= 0, 
                           string.Format( "IndexedPriorityQueue.DecreaseIndex: object '{0}' isn't greater than current value '{1}'", 
                           increasedValue, m_objects[index] ) );

            m_objects[index] = increasedValue;
            SortDownward( index );
        }

        /// <summary>
        /// Removes all elements from the queue
        /// </summary>
        public void Clear()
        {
            Count = 0;
        }

        /// <summary>
        /// Set the maximum capacity of the queue
        /// </summary>
        /// <param name="maxSize">The desired maximum capacity</param>
        public void Resize( int maxSize )
        {
            Assert.IsTrue( maxSize >= 0, 
                           string.Format( "IndexedPriorityQueue.Resize: Invalid size '{0}'", maxSize ) );

            m_objects = new T[maxSize];
            m_heap = new int[maxSize + 1];
            m_heapInverse = new int[maxSize];
            Count = 0;
        }
        #endregion // public

        #region private
        private T[] m_objects;
        private int[] m_heap;
        private int[] m_heapInverse;

        private void SortUpward( int index )
        {
            SortHeapUpward( m_heapInverse[index] );
        }

        private void SortDownward( int index )
        {
            SortHeapDownward( m_heapInverse[index] );
        }

        private void SortHeapUpward( int heapIndex )
        {
            // move toward top if better than parent
            while ( heapIndex > 1 && 
                    m_objects[m_heap[heapIndex]].CompareTo( m_objects[m_heap[Parent( heapIndex )]] ) < 0 )
            {
                // swap this node with its parent
                Swap( heapIndex, Parent( heapIndex ) );

                // reset iterator to be at parents old position
                // (child's new position)
                heapIndex = Parent( heapIndex );
            }
        }

        private void SortHeapDownward( int heapIndex )
        {
            // move node downward if less than children
            while ( FirstChild( heapIndex ) <= Count )
            {
                int child = FirstChild( heapIndex );

                // find smallest of two children (if 2 exist)
                if ( child < Count && 
                     m_objects[m_heap[child + 1]].CompareTo( m_objects[m_heap[child]] ) < 0 )
                {
                    ++child;
                }

                // swap with child if less
                if ( m_objects[m_heap[child]].CompareTo( m_objects[m_heap[heapIndex]] ) < 0 )
                {
                    Swap( child, heapIndex );
                    heapIndex = child;
                }
                // no swap necessary
                else
                {
                    break;
                }
            }
        }

        private void Swap( int i, int j )
        {
            // swap elements in heap
            int temp = m_heap[i];
            m_heap[i] = m_heap[j];
            m_heap[j] = temp;

            // reset inverses
            m_heapInverse[m_heap[i]] = i;
            m_heapInverse[m_heap[j]] = j;
        }

        private int Parent( int heapIndex )
        {
            return ( heapIndex / 2 );
        }

        private int FirstChild( int heapIndex )
        {
            return ( heapIndex * 2 );
        }

        private int SecondChild( int heapIndex )
        {
            return ( heapIndex * 2 + 1 );
        }
        #endregion // private
    }
}