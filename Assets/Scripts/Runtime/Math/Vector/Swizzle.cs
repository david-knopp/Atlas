using UnityEngine;

namespace VVS
{
    public static class Swizzle
    {
        #region Vector3.XXX
        public static Vector3 XXX( this Vector3 v )
        {
            return new Vector3( v.x, v.x, v.x );
        }

        public static Vector3 XYX( this Vector3 v )
        {
            return new Vector3( v.x, v.y, v.x );
        }

        public static Vector3 XZX( this Vector3 v )
        {
            return new Vector3( v.x, v.z, v.x );
        }

        public static Vector3 XXY( this Vector3 v )
        {
            return new Vector3( v.x, v.x, v.y );
        }

        public static Vector3 XYY( this Vector3 v )
        {
            return new Vector3( v.x, v.y, v.y );
        }

        public static Vector3 XZY( this Vector3 v )
        {
            return new Vector3( v.x, v.z, v.y );
        }

        public static Vector3 XXZ( this Vector3 v )
        {
            return new Vector3( v.x, v.x, v.z );
        }

        public static Vector3 XZZ( this Vector3 v )
        {
            return new Vector3( v.x, v.z, v.z );
        }

        public static Vector3 YXX( this Vector3 v )
        {
            return new Vector3( v.y, v.x, v.x );
        }

        public static Vector3 YYX( this Vector3 v )
        {
            return new Vector3( v.y, v.y, v.x );
        }

        public static Vector3 YZX( this Vector3 v )
        {
            return new Vector3( v.y, v.z, v.x );
        }

        public static Vector3 YXY( this Vector3 v )
        {
            return new Vector3( v.y, v.x, v.y );
        }

        public static Vector3 YYY( this Vector3 v )
        {
            return new Vector3( v.y, v.y, v.y );
        }

        public static Vector3 YZY( this Vector3 v )
        {
            return new Vector3( v.y, v.z, v.y );
        }

        public static Vector3 YXZ( this Vector3 v )
        {
            return new Vector3( v.y, v.x, v.z );
        }

        public static Vector3 YYZ( this Vector3 v )
        {
            return new Vector3( v.y, v.y, v.z );
        }

        public static Vector3 YZZ( this Vector3 v )
        {
            return new Vector3( v.y, v.z, v.z );
        }

        public static Vector3 ZXX( this Vector3 v )
        {
            return new Vector3( v.z, v.x, v.x );
        }

        public static Vector3 ZYX( this Vector3 v )
        {
            return new Vector3( v.z, v.y, v.x );
        }

        public static Vector3 ZZX( this Vector3 v )
        {
            return new Vector3( v.z, v.z, v.x );
        }

        public static Vector3 ZXY( this Vector3 v )
        {
            return new Vector3( v.z, v.x, v.y );
        }

        public static Vector3 ZYY( this Vector3 v )
        {
            return new Vector3( v.z, v.y, v.y );
        }

        public static Vector3 ZZY( this Vector3 v )
        {
            return new Vector3( v.z, v.z, v.y );
        }

        public static Vector3 ZXZ( this Vector3 v )
        {
            return new Vector3( v.z, v.x, v.z );
        }

        public static Vector3 ZYZ( this Vector3 v )
        {
            return new Vector3( v.z, v.y, v.z );
        }

        public static Vector3 ZZZ( this Vector3 v )
        {
            return new Vector3( v.z, v.z, v.z );
        }
        #endregion Vector3.XXX

        #region Vector3.XX
        public static Vector2 XX( this Vector3 v )
        {
            return new Vector2( v.x, v.x );
        }

        public static Vector2 XZ( this Vector3 v )
        {
            return new Vector2( v.x, v.z );
        }

        public static Vector2 YX( this Vector3 v )
        {
            return new Vector2( v.y, v.x );
        }

        public static Vector2 YY( this Vector3 v )
        {
            return new Vector2( v.y, v.y );
        }

        public static Vector2 YZ( this Vector3 v )
        {
            return new Vector2( v.y, v.z );
        }

        public static Vector2 ZX( this Vector3 v )
        {
            return new Vector2( v.z, v.x );
        }

        public static Vector2 ZY( this Vector3 v )
        {
            return new Vector2( v.z, v.y );
        }

        public static Vector2 ZZ( this Vector3 v )
        {
            return new Vector2( v.z, v.z );
        }
        #endregion Vector3.XX

        #region Vector2.XXX
        public static Vector3 XXX( this Vector2 v )
        {
            return new Vector3( v.x, v.x, v.x );
        }

        public static Vector3 XYX( this Vector2 v )
        {
            return new Vector3( v.x, v.y, v.x );
        }

        public static Vector3 XXY( this Vector2 v )
        {
            return new Vector3( v.x, v.x, v.y );
        }

        public static Vector3 XYY( this Vector2 v )
        {
            return new Vector3( v.x, v.y, v.y );
        }

        public static Vector3 YXX( this Vector2 v )
        {
            return new Vector3( v.y, v.x, v.x );
        }

        public static Vector3 YYX( this Vector2 v )
        {
            return new Vector3( v.y, v.y, v.x );
        }

        public static Vector3 YXY( this Vector2 v )
        {
            return new Vector3( v.y, v.x, v.y );
        }

        public static Vector3 YYY( this Vector2 v )
        {
            return new Vector3( v.y, v.y, v.y );
        }
        #endregion Vector2.XXX

        #region Vector2.XX
        public static Vector2 XX( this Vector2 v )
        {
            return new Vector2( v.x, v.x );
        }

        public static Vector2 YX( this Vector2 v )
        {
            return new Vector2( v.y, v.x );
        }

        public static Vector2 YY( this Vector2 v )
        {
            return new Vector2( v.y, v.y );
        }
        #endregion Vector2.XX
    }
}
