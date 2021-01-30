using System;
using System.Collections.Generic;

namespace Atlas
{
    public sealed class MaxHeap<T> : BinaryHeap<T>
        where T : IComparable<T>
    {
        public MaxHeap()
            : this( capacity: 0 )
        {
        }

        public MaxHeap( int capacity )
            : base( new Comparer(), capacity )
        {
        }

        private sealed class Comparer : IComparer<T>
        {
            public int Compare( T x, T y )
            {
                return y.CompareTo( x );
            }
        }
    }
}
