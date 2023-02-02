using System.Collections.Generic;
using System.Collections;
using System;

namespace Atlas
{
    /// <summary>
    /// Represents a queue data structure of fixed length. When the buffer is full, subsequent writes overwrite the "oldest" 
    /// values in an FIFO fashion
    /// </summary>
    /// <typeparam name="T">The type of elements to store in the queue</typeparam>
    public sealed class CircularQueue<T> : IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>, ICollection
    {
        /// <summary>
        /// The maximum number of elements this queue can hold
        /// </summary>
        public int FixedSize { get; }

        /// <summary>
        /// The current number of elements contained in the queue
        /// </summary>
        public int Count => m_internalQueue.Count;

        /// <summary>
        /// Indicates whether access is synchronized (thread safe)
        /// </summary>
        bool ICollection.IsSynchronized
        {
            get
            {
                ICollection collection = m_internalQueue;
                return collection.IsSynchronized;
            }
        }

        /// <summary>
        /// Gets an object that can be used to synchronize access
        /// </summary>
        object ICollection.SyncRoot
        {
            get
            {
                ICollection collection = m_internalQueue;
                return collection.SyncRoot;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="size">The maximum number of elements this queue can hold</param>
        public CircularQueue( int size )
        {
            if ( size < 0 )
            {
                throw new ArgumentOutOfRangeException( $"Cannot create a FixedSizeQueue with a size of '{size}', size must be > 0" );
            }

            FixedSize = size;
            m_internalQueue = new Queue<T>( size );
        }

        /// <summary>
        /// Pushes the given item into the queue. If adding the item will cause the queue's <see cref="Count"/> to
        /// exceed the <see cref="FixedSize"/>, the item at the beginning of the queue will be dequeued
        /// </summary>
        /// <param name="item">The item to add to the queue, can be null for reference types</param>
        public void Enqueue( T item )
        {
            if ( m_internalQueue.Count > 0 &&
                 m_internalQueue.Count == FixedSize )
            {
                m_internalQueue.Dequeue();
            }

            m_internalQueue.Enqueue( item );
        }

        /// <summary>
        /// Removes the item at the beginning of the queue and returns it
        /// </summary>
        /// <returns>The object that is removed from the beginning of the <see cref="CircularQueue{T}"/></returns>
        public T Dequeue()
        {
            return m_internalQueue.Dequeue();
        }

        /// <summary>
        /// Removes all objects from the queue
        /// </summary>
        public void Clear()
        {
            m_internalQueue.Clear();
        }

        /// <summary>
        /// Returns the item at the beginning of the queue without removing it
        /// </summary>
        /// <returns>The item at the beginning of the queue</returns>
        public T Peek()
        {
            return m_internalQueue.Peek();
        }

        /// <summary>
        /// Determines whether an element is in the queue
        /// </summary>
        /// <param name="item">The item to locate in the queue, can be null for reference types</param>
        /// <returns>true if item is found in the queue, false otherwise</returns>
        public bool Contains( T item )
        {
            return m_internalQueue.Contains( item );
        }

        /// <summary>
        /// Copies the <see cref="CircularQueue{T}"/> elements to an existing array, starting at the specified array index
        /// </summary>
        /// <param name="array">The destination array for the elements copied from the <see cref="CircularQueue{T}"/></param>
        /// <param name="index">The zero-based index in array at which copying begins</param>
        public void CopyTo( T[] array, int index )
        {
            m_internalQueue.CopyTo( array, index );
        }

        /// <summary>
        /// Returns an enumerator that iterates through the <see cref="CircularQueue{T}"/>
        /// </summary>
        /// <returns>An enumerator for the <see cref="CircularQueue{T}"/></returns>
        public IEnumerator<T> GetEnumerator()
        {
            return m_internalQueue.GetEnumerator();
        }

        /// <summary>
        /// Returns an enumerator that iterates through the <see cref="CircularQueue{T}"/>
        /// </summary>
        /// <returns>An enumerator for the <see cref="CircularQueue{T}"/></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Copies the <see cref="CircularQueue{T}"/> elements to an existing one-dimensional Array, starting at the specified array index
        /// </summary>
        /// <param name="array">The one-dimensional destination Array for the elements copied from the <see cref="CircularQueue{T}"/>. The Array must have zero-based indexing.</param>
        /// <param name="index">The zero-based index in array at which copying begins</param>
        void ICollection.CopyTo( Array array, int index )
        {
            CopyTo( array as T[], index );
        }

        private Queue<T> m_internalQueue;
    }
}
