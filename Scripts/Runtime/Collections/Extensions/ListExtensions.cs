using System;
using System.Collections.Generic;

using Random = UnityEngine.Random;

namespace Atlas
{
    public static class ListExtensions
    {
        /// <summary>
        /// Randomizes the order of the given list
        /// </summary>
        /// <typeparam name="T">Generic element type contained within the List</typeparam>
        /// <param name="list">List to randomize</param>
        /// <exception cref="ArgumentNullException">Thrown if the given list is null</exception>
        public static void Shuffle<T>( this IList<T> list )
        {
            if ( list == null )
            {
                throw new ArgumentNullException( "Failed to shuffle list: the provided list is null" );
            }

            for ( int i = list.Count - 1; i >= 0; i-- )
            {
                int swapIndex = Random.Range( 0, i + 1 );
                T temp = list[swapIndex];
                list[swapIndex] = list[i];
                list[i] = temp;
            }
        }

        /// <summary>
        /// Returns a random element of the given list
        /// </summary>
        /// <typeparam name="T">Generic element type contained within the List</typeparam>
        /// <param name="list">List to return a random element of</param>
        /// <returns>A random element of the given list</returns>
        /// <exception cref="ArgumentNullException">Thrown when the provided list is null</exception>
        /// <exception cref="InvalidOperationException">Thrown when the provided list is empty</exception>
        public static T GetRandom<T>( this IList<T> list )
        {
            if ( list == null )
            {
                throw new ArgumentNullException( "Failed to get a random list element: the provided list is null" );
            }

            if ( list.Count == 0 )
            {
                throw new InvalidOperationException( "Failed to get a random list element: the source list is empty" );
            }

            return list[Random.Range( 0, list.Count )];
        }

        /// <summary>
        /// Checks if the given index is valid for the given list
        /// </summary>
        /// <typeparam name="T">Generic element type contained within the List</typeparam>
        /// <param name="list">List to validate index for</param>
        /// <param name="index">The index to validate</param>
        /// <returns>true if the index is within the bounds of the given list, false otherwise</returns>
        public static bool IsIndexValid<T>( this IList<T> list, int index )
        {
            if ( list == null )
            {
                throw new ArgumentNullException( "Failed validating List index: the provided list is null" );
            }

            return index >= 0 &&
                   index < list.Count;
        }
    }
}
