using UnityEngine;

namespace Atlas
{
    public static class VectorExtensions
    {
        #region Set
        public static Vector3 SetX( this Vector3 v, float x )
        {
            return new Vector3( x, v.y, v.z );
        }

        public static Vector3 SetY( this Vector3 v, float y )
        {
            return new Vector3( v.x, y, v.z );
        }

        public static Vector3 SetZ( this Vector3 v, float z )
        {
            return new Vector3( v.x, v.y, z );
        }

        public static Vector2 SetX( this Vector2 v, float x )
        {
            return new Vector2( x, v.y );
        }

        public static Vector2 SetY( this Vector2 v, float y )
        {
            return new Vector2( v.x, y );
        }

        public static Vector3Int SetX( this Vector3Int v, int x )
        {
            return new Vector3Int( x, v.y, v.z );
        }

        public static Vector3Int SetY( this Vector3Int v, int y )
        {
            return new Vector3Int( v.x, y, v.z );
        }

        public static Vector3Int SetZ( this Vector3Int v, int z )
        {
            return new Vector3Int( v.x, v.y, z );
        }

        public static Vector2Int SetX( this Vector2Int v, int x )
        {
            return new Vector2Int( x, v.y );
        }

        public static Vector2Int SetY( this Vector2Int v, int y )
        {
            return new Vector2Int( v.x, y );
        }

        #endregion Set

        #region Distance
        public static int ManhattanDistance( this Vector3Int a, Vector3Int b )
        {
            return Mathf.Abs( a.x - b.x ) +
                   Mathf.Abs( a.y - b.y ) +
                   Mathf.Abs( a.z - b.z );
        }

        public static int ManhattanDistance( this Vector2Int a, Vector2Int b )
        {
            return Mathf.Abs( a.x - b.x ) +
                   Mathf.Abs( a.y - b.y );
        }
        #endregion Distance
    }
}
