using UnityEngine;

namespace Atlas
{
    public static class Swizzle
    {
        #region Vector3.XXX
        public static Vector3 XXX( this Vector3 v )
        {
            return new Vector3( v.x, v.x, v.x );
        }

        public static Vector3 XXY( this Vector3 v )
        {
            return new Vector3( v.x, v.x, v.y );
        }

        public static Vector3 XXZ( this Vector3 v )
        {
            return new Vector3( v.x, v.x, v.z );
        }

        public static Vector3 XX_( this Vector3 v )
        {
            return new Vector3( v.x, v.x, 0f );
        }

        public static Vector3 XYX( this Vector3 v )
        {
            return new Vector3( v.x, v.y, v.x );
        }

        public static Vector3 XYY( this Vector3 v )
        {
            return new Vector3( v.x, v.y, v.y );
        }

        public static Vector3 XYZ( this Vector3 v )
        {
            return new Vector3( v.x, v.y, v.z );
        }

        public static Vector3 XY_( this Vector3 v )
        {
            return new Vector3( v.x, v.y, 0f );
        }

        public static Vector3 XZX( this Vector3 v )
        {
            return new Vector3( v.x, v.z, v.x );
        }

        public static Vector3 XZY( this Vector3 v )
        {
            return new Vector3( v.x, v.z, v.y );
        }

        public static Vector3 XZZ( this Vector3 v )
        {
            return new Vector3( v.x, v.z, v.z );
        }

        public static Vector3 XZ_( this Vector3 v )
        {
            return new Vector3( v.x, v.z, 0f );
        }

        public static Vector3 X_X( this Vector3 v )
        {
            return new Vector3( v.x, 0f, v.x );
        }

        public static Vector3 X_Y( this Vector3 v )
        {
            return new Vector3( v.x, 0f, v.y );
        }

        public static Vector3 X_Z( this Vector3 v )
        {
            return new Vector3( v.x, 0f, v.z );
        }

        public static Vector3 X__( this Vector3 v )
        {
            return new Vector3( v.x, 0f, 0f );
        }

        public static Vector3 YXX( this Vector3 v )
        {
            return new Vector3( v.y, v.x, v.x );
        }

        public static Vector3 YXY( this Vector3 v )
        {
            return new Vector3( v.y, v.x, v.y );
        }

        public static Vector3 YXZ( this Vector3 v )
        {
            return new Vector3( v.y, v.x, v.z );
        }

        public static Vector3 YX_( this Vector3 v )
        {
            return new Vector3( v.y, v.x, 0f );
        }

        public static Vector3 YYX( this Vector3 v )
        {
            return new Vector3( v.y, v.y, v.x );
        }

        public static Vector3 YYY( this Vector3 v )
        {
            return new Vector3( v.y, v.y, v.y );
        }

        public static Vector3 YYZ( this Vector3 v )
        {
            return new Vector3( v.y, v.y, v.z );
        }

        public static Vector3 YY_( this Vector3 v )
        {
            return new Vector3( v.y, v.y, 0f );
        }

        public static Vector3 YZX( this Vector3 v )
        {
            return new Vector3( v.y, v.z, v.x );
        }

        public static Vector3 YZY( this Vector3 v )
        {
            return new Vector3( v.y, v.z, v.y );
        }

        public static Vector3 YZZ( this Vector3 v )
        {
            return new Vector3( v.y, v.z, v.z );
        }

        public static Vector3 YZ_( this Vector3 v )
        {
            return new Vector3( v.y, v.z, 0f );
        }

        public static Vector3 Y_X( this Vector3 v )
        {
            return new Vector3( v.y, 0f, v.x );
        }

        public static Vector3 Y_Y( this Vector3 v )
        {
            return new Vector3( v.y, 0f, v.y );
        }

        public static Vector3 Y_Z( this Vector3 v )
        {
            return new Vector3( v.y, 0f, v.z );
        }

        public static Vector3 Y__( this Vector3 v )
        {
            return new Vector3( v.y, 0f, 0f );
        }

        public static Vector3 ZXX( this Vector3 v )
        {
            return new Vector3( v.z, v.x, v.x );
        }

        public static Vector3 ZXY( this Vector3 v )
        {
            return new Vector3( v.z, v.x, v.y );
        }

        public static Vector3 ZXZ( this Vector3 v )
        {
            return new Vector3( v.z, v.x, v.z );
        }

        public static Vector3 ZX_( this Vector3 v )
        {
            return new Vector3( v.z, v.x, 0f );
        }

        public static Vector3 ZYX( this Vector3 v )
        {
            return new Vector3( v.z, v.y, v.x );
        }

        public static Vector3 ZYY( this Vector3 v )
        {
            return new Vector3( v.z, v.y, v.y );
        }

        public static Vector3 ZYZ( this Vector3 v )
        {
            return new Vector3( v.z, v.y, v.z );
        }

        public static Vector3 ZY_( this Vector3 v )
        {
            return new Vector3( v.z, v.y, 0f );
        }

        public static Vector3 ZZX( this Vector3 v )
        {
            return new Vector3( v.z, v.z, v.x );
        }

        public static Vector3 ZZY( this Vector3 v )
        {
            return new Vector3( v.z, v.z, v.y );
        }

        public static Vector3 ZZZ( this Vector3 v )
        {
            return new Vector3( v.z, v.z, v.z );
        }

        public static Vector3 ZZ_( this Vector3 v )
        {
            return new Vector3( v.z, v.z, 0f );
        }

        public static Vector3 Z_X( this Vector3 v )
        {
            return new Vector3( v.z, 0f, v.x );
        }

        public static Vector3 Z_Y( this Vector3 v )
        {
            return new Vector3( v.z, 0f, v.y );
        }

        public static Vector3 Z_Z( this Vector3 v )
        {
            return new Vector3( v.z, 0f, v.z );
        }

        public static Vector3 Z__( this Vector3 v )
        {
            return new Vector3( v.z, 0f, 0f );
        }

        public static Vector3 _XX( this Vector3 v )
        {
            return new Vector3( 0f, v.x, v.x );
        }

        public static Vector3 _XY( this Vector3 v )
        {
            return new Vector3( 0f, v.x, v.y );
        }

        public static Vector3 _XZ( this Vector3 v )
        {
            return new Vector3( 0f, v.x, v.z );
        }

        public static Vector3 _X_( this Vector3 v )
        {
            return new Vector3( 0f, v.x, 0f );
        }

        public static Vector3 _YX( this Vector3 v )
        {
            return new Vector3( 0f, v.y, v.x );
        }

        public static Vector3 _YY( this Vector3 v )
        {
            return new Vector3( 0f, v.y, v.y );
        }

        public static Vector3 _YZ( this Vector3 v )
        {
            return new Vector3( 0f, v.y, v.z );
        }

        public static Vector3 _Y_( this Vector3 v )
        {
            return new Vector3( 0f, v.y, 0f );
        }

        public static Vector3 _ZX( this Vector3 v )
        {
            return new Vector3( 0f, v.z, v.x );
        }

        public static Vector3 _ZY( this Vector3 v )
        {
            return new Vector3( 0f, v.z, v.y );
        }

        public static Vector3 _ZZ( this Vector3 v )
        {
            return new Vector3( 0f, v.z, v.z );
        }

        public static Vector3 _Z_( this Vector3 v )
        {
            return new Vector3( 0f, v.z, 0f );
        }

        public static Vector3 __X( this Vector3 v )
        {
            return new Vector3( 0f, 0f, v.x );
        }

        public static Vector3 __Y( this Vector3 v )
        {
            return new Vector3( 0f, 0f, v.y );
        }

        public static Vector3 __Z( this Vector3 v )
        {
            return new Vector3( 0f, 0f, v.z );
        }
        #endregion Vector3.XXX

        #region Vector2.XXX
        public static Vector3 XXX( this Vector2 v )
        {
            return new Vector3( v.x, v.x, v.x );
        }

        public static Vector3 XXY( this Vector2 v )
        {
            return new Vector3( v.x, v.x, v.y );
        }

        public static Vector3 XX_( this Vector2 v )
        {
            return new Vector3( v.x, v.x, 0f );
        }

        public static Vector3 XYX( this Vector2 v )
        {
            return new Vector3( v.x, v.y, v.x );
        }

        public static Vector3 XYY( this Vector2 v )
        {
            return new Vector3( v.x, v.y, v.y );
        }

        public static Vector3 XY_( this Vector2 v )
        {
            return new Vector3( v.x, v.y, 0f );
        }

        public static Vector3 X_X( this Vector2 v )
        {
            return new Vector3( v.x, 0f, v.x );
        }

        public static Vector3 X_Y( this Vector2 v )
        {
            return new Vector3( v.x, 0f, v.y );
        }

        public static Vector3 X__( this Vector2 v )
        {
            return new Vector3( v.x, 0f, 0f );
        }

        public static Vector3 YXX( this Vector2 v )
        {
            return new Vector3( v.y, v.x, v.x );
        }

        public static Vector3 YXY( this Vector2 v )
        {
            return new Vector3( v.y, v.x, v.y );
        }

        public static Vector3 YX_( this Vector2 v )
        {
            return new Vector3( v.y, v.x, 0f );
        }

        public static Vector3 YYX( this Vector2 v )
        {
            return new Vector3( v.y, v.y, v.x );
        }

        public static Vector3 YYY( this Vector2 v )
        {
            return new Vector3( v.y, v.y, v.y );
        }

        public static Vector3 YY_( this Vector2 v )
        {
            return new Vector3( v.y, v.y, 0f );
        }

        public static Vector3 Y_X( this Vector2 v )
        {
            return new Vector3( v.y, 0f, v.x );
        }

        public static Vector3 Y_Y( this Vector2 v )
        {
            return new Vector3( v.y, 0f, v.y );
        }

        public static Vector3 Y__( this Vector2 v )
        {
            return new Vector3( v.y, 0f, 0f );
        }

        public static Vector3 _XX( this Vector2 v )
        {
            return new Vector3( 0f, v.x, v.x );
        }

        public static Vector3 _XY( this Vector2 v )
        {
            return new Vector3( 0f, v.x, v.y );
        }

        public static Vector3 _X_( this Vector2 v )
        {
            return new Vector3( 0f, v.x, 0f );
        }

        public static Vector3 _YX( this Vector2 v )
        {
            return new Vector3( 0f, v.y, v.x );
        }

        public static Vector3 _YY( this Vector2 v )
        {
            return new Vector3( 0f, v.y, v.y );
        }

        public static Vector3 _Y_( this Vector2 v )
        {
            return new Vector3( 0f, v.y, 0f );
        }

        public static Vector3 __X( this Vector2 v )
        {
            return new Vector3( 0f, 0f, v.x );
        }

        public static Vector3 __Y( this Vector2 v )
        {
            return new Vector3( 0f, 0f, v.y );
        }
        #endregion Vector2.XXX

        #region Vector3.XX
        public static Vector2 XX( this Vector3 v )
        {
            return new Vector2( v.x, v.x );
        }

        public static Vector2 XY( this Vector3 v )
        {
            return new Vector2( v.x, v.y );
        }

        public static Vector2 XZ( this Vector3 v )
        {
            return new Vector2( v.x, v.z );
        }

        public static Vector2 X_( this Vector3 v )
        {
            return new Vector2( v.x, 0f );
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

        public static Vector2 Y_( this Vector3 v )
        {
            return new Vector2( v.y, 0f );
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

        public static Vector2 Z_( this Vector3 v )
        {
            return new Vector2( v.z, 0f );
        }

        public static Vector2 _X( this Vector3 v )
        {
            return new Vector2( 0f, v.x );
        }

        public static Vector2 _Y( this Vector3 v )
        {
            return new Vector2( 0f, v.y );
        }

        public static Vector2 _Z( this Vector3 v )
        {
            return new Vector2( 0f, v.z );
        }
        #endregion Vector3.XX

        #region Vector2.XX
        public static Vector2 XX( this Vector2 v )
        {
            return new Vector2( v.x, v.x );
        }

        public static Vector2 XY( this Vector2 v )
        {
            return new Vector2( v.x, v.y );
        }

        public static Vector2 X_( this Vector2 v )
        {
            return new Vector2( v.x, 0f );
        }

        public static Vector2 YX( this Vector2 v )
        {
            return new Vector2( v.y, v.x );
        }

        public static Vector2 YY( this Vector2 v )
        {
            return new Vector2( v.y, v.y );
        }

        public static Vector2 Y_( this Vector2 v )
        {
            return new Vector2( v.y, 0f );
        }

        public static Vector2 _X( this Vector2 v )
        {
            return new Vector2( 0f, v.x );
        }

        public static Vector2 _Y( this Vector2 v )
        {
            return new Vector2( 0f, v.y );
        }
        #endregion Vector2.XX
    }
}