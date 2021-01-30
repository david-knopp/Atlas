using System;
using System.Collections.Generic;

namespace VVS
{
    // use a fibonnaci heap?
    // https://github.com/BlueRaja/High-Speed-Priority-Queue-for-C-Sharp/wiki/Using-the-SimplePriorityQueue
    public sealed class PriorityQueue<TItem, TPriority> //: IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>, ICollection
        where TPriority : IComparable<TItem>
    {
        public PriorityQueue() { }
        public PriorityQueue( IEnumerable<TItem> collection )
        {
        }

        public PriorityQueue( int capacity )
        {

        }

        public int Count { get; private set; }

        public void Enqueue()
        {
            
        }

        public TItem Dequeue()
        {
            return default;
        }

        public TItem Peek()
        {
            return default;
        }

        public void Clear()
        {

        }

        public bool Contains( TItem item )
        {
            return true;
        }

        public void Remove( TItem item )
        {

        }
    }
}
