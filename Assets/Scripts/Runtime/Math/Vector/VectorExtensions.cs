using UnityEngine;

namespace VVS
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
        #endregion Set
    }
}
