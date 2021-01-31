using System;
using System.Collections.Generic;

namespace Atlas
{
    public sealed class PriorityQueue<TItem, TPriority>
        where TPriority : IComparable<TPriority>
    {
        #region public
        public PriorityQueue()
           : this( capacity: 0 )
        {
        }

        public PriorityQueue( int capacity )
            : this( Comparer<TPriority>.Default, capacity )
        {
        }

        public PriorityQueue( IComparer<TPriority> priorityComparer, int capacity )
        {
            m_heap = new BinaryHeap<Node>( new NodeComparer( priorityComparer ), capacity );
        }

        public int Count => m_heap.Count;

        public void Enqueue( TItem item, TPriority priority )
        {
            m_heap.Add( new Node( item, priority ) );
        }

        public TItem Dequeue()
        {
            if ( m_heap.Count == 0 )
            {
                throw new InvalidOperationException( "Failed Dequeueing item from the PriorityQueue: queue is empty" );
            }

            return m_heap.Pop().Item;
        }

        public TItem Peek()
        {
            if ( m_heap.Count == 0 )
            {
                throw new InvalidOperationException( "Failed Peeking item from the PriorityQueue: queue is empty" );
            }

            return m_heap.Peek().Item;
        }

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
