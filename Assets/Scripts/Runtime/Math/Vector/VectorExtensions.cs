using System.Collections.Generic;
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

        #region Bresenham
        public static IEnumerable<Vector2Int> GetPointsOnLine( Vector2Int startPoint, Vector2Int endPoint )
        {
            // Bresenham's line algorithm
            int deltaX = Mathf.Abs( endPoint.x - startPoint.x );
            int deltaY = Mathf.Abs( endPoint.y - startPoint.y );

            bool hasSteepSlope = deltaY > deltaX;
            if ( hasSteepSlope )
            {
                // swap x and y values
                startPoint = startPoint.YX();
                endPoint = endPoint.YX();
            }

            if ( startPoint.x > endPoint.x )
            {
                // swap start and end points
                Utility.Swap( ref startPoint, ref endPoint );
            }

            deltaX = endPoint.x - startPoint.x;
            deltaY = Mathf.Abs( endPoint.y - startPoint.y );
            int error = deltaX / 2;
            int yStep = ( startPoint.y < endPoint.y ) ? 1 : -1;
            int y = startPoint.y;

            for ( int x = startPoint.x; x <= endPoint.x; x++ )
            {
                Vector2Int point;

                if ( hasSteepSlope )
                {
                    point = new Vector2Int( y, x );
                }
                else
                {
                    point = new Vector2Int( x, y );
                }

                yield return point;

                error = error - deltaY;
                if ( error < 0 )
                {
                    y += yStep;
                    error += deltaX;
                }
            }
        }

        public static IEnumerable<Vector3Int> GetPointsOnLine( Vector3Int startPoint, Vector3Int endPoint )
        {
            /// 3D Bresenham's http://members.chello.at/easyfilter/bresenham.html

            int deltaX = Mathf.Abs( endPoint.x - startPoint.x );
            int deltaY = Mathf.Abs( endPoint.y - startPoint.y );
            int deltaZ = Mathf.Abs( endPoint.z - startPoint.z );

            int xStep = startPoint.x < endPoint.x ? 1 : -1;
            int yStep = startPoint.y < endPoint.y ? 1 : -1;
            int zStep = startPoint.z < endPoint.z ? 1 : -1;

            int maxDelta = Mathf.Max( deltaX, deltaY, deltaZ );
            Vector3Int error = Vector3Int.one * ( maxDelta / 2 );
            Vector3Int point = startPoint;

            for ( int i = maxDelta; i >= 0; --i )
            {
                yield return point;

                error.x -= deltaX;
                error.y -= deltaY;
                error.z -= deltaZ;

                if ( error.x < 0 )
                {
                    error.x += maxDelta;
                    point.x += xStep;
                }

                if ( error.y < 0 )
                {
                    error.y += maxDelta;
                    point.y += yStep;
                }

                if ( error.z < 0 )
                {
                    error.z += maxDelta;
                    point.z += zStep;
                }
            }
        }
        #endregion Bresenham
    }
}
