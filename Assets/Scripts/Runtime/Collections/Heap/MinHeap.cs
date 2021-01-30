using System;
using System.Collections.Generic;

namespace Atlas
{
    public sealed class MinHeap<T> : BinaryHeap<T>
        where T : IComparable<T>
    {
        public MinHeap()
            : this( capacity: 0 )
        {
        }

        public MinHeap( int capacity )
            : base( new Comparer(), capacity )
        {
        }

        private sealed class Comparer : IComparer<T>
        {
            public int Compare( T x, T y )
            {
                return x.CompareTo( y );
            }
        }
    }
}
