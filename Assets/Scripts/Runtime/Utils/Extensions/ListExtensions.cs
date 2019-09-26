using System.Collections.Generic;
using UnityEngine;

namespace Atlas
{
    public static class ListExtensions
    {

        public static void Shuffle<T>( this IList<T> list )
        {
            for ( int i = list.Count - 1; i >= 0; i-- )
            {
                int swapIndex = Random.Range( 0, i + 1 );
                T temp = list[swapIndex];
                list[swapIndex] = list[i];
                list[i] = temp;
            }
        }
    }
}
