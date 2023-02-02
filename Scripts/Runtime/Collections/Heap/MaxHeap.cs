using System;
using System.Collections.Generic;

namespace Atlas
{
    /// <summary>
    /// A heap data structure, where root nodes are greater than or equal to their children
    /// </summary>
    /// <typeparam name="T">Type of the heap's elements</typeparam>
    public sealed class MaxHeap<T> : BinaryHeap<T>
        where T : IComparable<T>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public MaxHeap()
            : this( capacity: 0 )
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="capacity">The number of elements the heap can hold before resizing</param>
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
