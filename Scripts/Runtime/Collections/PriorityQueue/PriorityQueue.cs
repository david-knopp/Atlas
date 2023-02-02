using System;
using System.Collections.Generic;

namespace Atlas
{
    /// <summary>
    /// A queue data structure that arranges elements based on their priority values
    /// </summary>
    /// <typeparam name="TItem">Type of contained elements</typeparam>
    /// <typeparam name="TPriority">Type of each element's priority</typeparam>
    public sealed class PriorityQueue<TItem, TPriority>
        where TPriority : IComparable<TPriority>
    {
        #region public
        /// <summary>
        /// Constructor
        /// </summary>
        public PriorityQueue()
           : this( capacity: 0 )
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="capacity">The number of elements the queue can hold before resizing</param>
        public PriorityQueue( int capacity )
            : this( Comparer<TPriority>.Default, capacity )
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="priorityComparer">Comparer object to use when comparing element priorities</param>
        /// <param name="capacity">The number of elements the queue can hold before resizing</param>
        public PriorityQueue( IComparer<TPriority> priorityComparer, int capacity )
        {
            m_heap = new BinaryHeap<Node>( new NodeComparer( priorityComparer ), capacity );
        }

        /// <summary>
        /// Number of elements in the queue
        /// </summary>
        public int Count => m_heap.Count;

        /// <summary>
        /// Adds the given item to the queue
        /// </summary>
        /// <param name="item">The item to add</param>
        /// <param name="priority">The priority of the added item</param>
        public void Enqueue( TItem item, TPriority priority )
        {
            m_heap.Add( new Node( item, priority ) );
        }

        /// <summary>
        /// Gets the next item from the queue with the best priority, and removes it
        /// </summary>
        /// <returns>The item with the highest priority</returns>
        /// <exception cref="InvalidOperationException">Thrown when the queue is empty</exception>
        public TItem Dequeue()
        {
            if ( m_heap.Count == 0 )
            {
                throw new InvalidOperationException( "Failed Dequeueing item from the PriorityQueue: queue is empty" );
            }

            return m_heap.Pop().Item;
        }

        /// <summary>
        /// Fetches the next item from the queue with the best priority without removing it
        /// </summary>
        /// <returns>The item with the highest priority</returns>
        /// <exception cref="InvalidOperationException">Thrown when the queue is empty</exception>
        public TItem Peek()
        {
            if ( m_heap.Count == 0 )
            {
                throw new InvalidOperationException( "Failed Peeking item from the PriorityQueue: queue is empty" );
            }

            return m_heap.Peek().Item;
        }

        /// <summary>
        /// Removes all elements from the queue
        /// </summary>
        public void Clear()
        {
            m_heap.Clear();
        } 
        #endregion public

        #region private
        private readonly struct Node
        {
            public Node( TItem item, TPriority priority )
            {
                Item = item;
                Priority = priority;
            }

            public readonly TItem Item;
            public readonly TPriority Priority;
        }

        private sealed class NodeComparer : IComparer<Node>
        {
            public NodeComparer( IComparer<TPriority> priorityComparer )
            {
                m_priorityComparer = priorityComparer;
            }

            public int Compare( Node x, Node y )
            {
                return m_priorityComparer.Compare( x.Priority, y.Priority );
            }

            private IComparer<TPriority> m_priorityComparer;
        }

        private BinaryHeap<Node> m_heap; 
        #endregion private
    }
}
