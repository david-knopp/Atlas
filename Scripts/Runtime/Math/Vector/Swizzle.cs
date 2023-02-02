using UnityEngine;

namespace Atlas
{
    public static class Swizzle
    {
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

        #region Vector2.XXXX
        public static Vector4 XXXX( this Vector2 v )
        {
            return new Vector4( v.x, v.x, v.x, v.x );
        }

        public static Vector4 XXXY( this Vector2 v )
        {
            return new Vector4( v.x, v.x, v.x, v.y );
        }

        public static Vector4 XXX_( this Vector2 v )
        {
            return new Vector4( v.x, v.x, v.x, 0f );
        }

        public static Vector4 XXYX( this Vector2 v )
        {
            return new Vector4( v.x, v.x, v.y, v.x );
        }

        public static Vector4 XXYY( this Vector2 v )
        {
            return new Vector4( v.x, v.x, v.y, v.y );
        }

        public static Vector4 XXY_( this Vector2 v )
        {
            return new Vector4( v.x, v.x, v.y, 0f );
        }

        public static Vector4 XX_X( this Vector2 v )
        {
            return new Vector4( v.x, v.x, 0f, v.x );
        }

        public static Vector4 XX_Y( this Vector2 v )
        {
            return new Vector4( v.x, v.x, 0f, v.y );
        }

        public static Vector4 XX__( this Vector2 v )
        {
            return new Vector4( v.x, v.x, 0f, 0f );
        }

        public static Vector4 XYXX( this Vector2 v )
        {
            return new Vector4( v.x, v.y, v.x, v.x );
        }

        public static Vector4 XYXY( this Vector2 v )
        {
            return new Vector4( v.x, v.y, v.x, v.y );
        }

        public static Vector4 XYX_( this Vector2 v )
        {
            return new Vector4( v.x, v.y, v.x, 0f );
        }

        public static Vector4 XYYX( this Vector2 v )
        {
            return new Vector4( v.x, v.y, v.y, v.x );
        }

        public static Vector4 XYYY( this Vector2 v )
        {
            return new Vector4( v.x, v.y, v.y, v.y );
        }

        public static Vector4 XYY_( this Vector2 v )
        {
            return new Vector4( v.x, v.y, v.y, 0f );
        }

        public static Vector4 XY_X( this Vector2 v )
        {
            return new Vector4( v.x, v.y, 0f, v.x );
        }

        public static Vector4 XY_Y( this Vector2 v )
        {
            return new Vector4( v.x, v.y, 0f, v.y );
        }

        public static Vector4 XY__( this Vector2 v )
        {
            return new Vector4( v.x, v.y, 0f, 0f );
        }

        public static Vector4 X_XX( this Vector2 v )
        {
            return new Vector4( v.x, 0f, v.x, v.x );
        }

        public static Vector4 X_XY( this Vector2 v )
        {
            return new Vector4( v.x, 0f, v.x, v.y );
        }

        public static Vector4 X_X_( this Vector2 v )
        {
            return new Vector4( v.x, 0f, v.x, 0f );
        }

        public static Vector4 X_YX( this Vector2 v )
        {
            return new Vector4( v.x, 0f, v.y, v.x );
        }

        public static Vector4 X_YY( this Vector2 v )
        {
            return new Vector4( v.x, 0f, v.y, v.y );
        }

        public static Vector4 X_Y_( this Vector2 v )
        {
            return new Vector4( v.x, 0f, v.y, 0f );
        }

        public static Vector4 X__X( this Vector2 v )
        {
            return new Vector4( v.x, 0f, 0f, v.x );
        }

        public static Vector4 X__Y( this Vector2 v )
        {
            return new Vector4( v.x, 0f, 0f, v.y );
        }

        public static Vector4 X___( this Vector2 v )
        {
            return new Vector4( v.x, 0f, 0f, 0f );
        }

        public static Vector4 YXXX( this Vector2 v )
        {
            return new Vector4( v.y, v.x, v.x, v.x );
        }

        public static Vector4 YXXY( this Vector2 v )
        {
            return new Vector4( v.y, v.x, v.x, v.y );
        }

        public static Vector4 YXX_( this Vector2 v )
        {
            return new Vector4( v.y, v.x, v.x, 0f );
        }

        public static Vector4 YXYX( this Vector2 v )
        {
            return new Vector4( v.y, v.x, v.y, v.x );
        }

        public static Vector4 YXYY( this Vector2 v )
        {
            return new Vector4( v.y, v.x, v.y, v.y );
        }

        public static Vector4 YXY_( this Vector2 v )
        {
            return new Vector4( v.y, v.x, v.y, 0f );
        }

        public static Vector4 YX_X( this Vector2 v )
        {
            return new Vector4( v.y, v.x, 0f, v.x );
        }

        public static Vector4 YX_Y( this Vector2 v )
        {
            return new Vector4( v.y, v.x, 0f, v.y );
        }

        public static Vector4 YX__( this Vector2 v )
        {
            return new Vector4( v.y, v.x, 0f, 0f );
        }

        public static Vector4 YYXX( this Vector2 v )
        {
            return new Vector4( v.y, v.y, v.x, v.x );
        }

        public static Vector4 YYXY( this Vector2 v )
        {
            return new Vector4( v.y, v.y, v.x, v.y );
        }

        public static Vector4 YYX_( this Vector2 v )
        {
            return new Vector4( v.y, v.y, v.x, 0f );
        }

        public static Vector4 YYYX( this Vector2 v )
        {
            return new Vector4( v.y, v.y, v.y, v.x );
        }

        public static Vector4 YYYY( this Vector2 v )
        {
            return new Vector4( v.y, v.y, v.y, v.y );
        }

        public static Vector4 YYY_( this Vector2 v )
        {
            return new Vector4( v.y, v.y, v.y, 0f );
        }

        public static Vector4 YY_X( this Vector2 v )
        {
            return new Vector4( v.y, v.y, 0f, v.x );
        }

        public static Vector4 YY_Y( this Vector2 v )
        {
            return new Vector4( v.y, v.y, 0f, v.y );
        }

        public static Vector4 YY__( this Vector2 v )
        {
            return new Vector4( v.y, v.y, 0f, 0f );
        }

        public static Vector4 Y_XX( this Vector2 v )
        {
            return new Vector4( v.y, 0f, v.x, v.x );
        }

        public static Vector4 Y_XY( this Vector2 v )
        {
            return new Vector4( v.y, 0f, v.x, v.y );
        }

        public static Vector4 Y_X_( this Vector2 v )
        {
            return new Vector4( v.y, 0f, v.x, 0f );
        }

        public static Vector4 Y_YX( this Vector2 v )
        {
            return new Vector4( v.y, 0f, v.y, v.x );
        }

        public static Vector4 Y_YY( this Vector2 v )
        {
            return new Vector4( v.y, 0f, v.y, v.y );
        }

        public static Vector4 Y_Y_( this Vector2 v )
        {
            return new Vector4( v.y, 0f, v.y, 0f );
        }

        public static Vector4 Y__X( this Vector2 v )
        {
            return new Vector4( v.y, 0f, 0f, v.x );
        }

        public static Vector4 Y__Y( this Vector2 v )
        {
            return new Vector4( v.y, 0f, 0f, v.y );
        }

        public static Vector4 Y___( this Vector2 v )
        {
            return new Vector4( v.y, 0f, 0f, 0f );
        }

        public static Vector4 _XXX( this Vector2 v )
        {
            return new Vector4( 0f, v.x, v.x, v.x );
        }

        public static Vector4 _XXY( this Vector2 v )
        {
            return new Vector4( 0f, v.x, v.x, v.y );
        }

        public static Vector4 _XX_( this Vector2 v )
        {
            return new Vector4( 0f, v.x, v.x, 0f );
        }

        public static Vector4 _XYX( this Vector2 v )
        {
            return new Vector4( 0f, v.x, v.y, v.x );
        }

        public static Vector4 _XYY( this Vector2 v )
        {
            return new Vector4( 0f, v.x, v.y, v.y );
        }

        public static Vector4 _XY_( this Vector2 v )
        {
            return new Vector4( 0f, v.x, v.y, 0f );
        }

        public static Vector4 _X_X( this Vector2 v )
        {
            return new Vector4( 0f, v.x, 0f, v.x );
        }

        public static Vector4 _X_Y( this Vector2 v )
        {
            return new Vector4( 0f, v.x, 0f, v.y );
        }

        public static Vector4 _X__( this Vector2 v )
        {
            return new Vector4( 0f, v.x, 0f, 0f );
        }

        public static Vector4 _YXX( this Vector2 v )
        {
            return new Vector4( 0f, v.y, v.x, v.x );
        }

        public static Vector4 _YXY( this Vector2 v )
        {
            return new Vector4( 0f, v.y, v.x, v.y );
        }

        public static Vector4 _YX_( this Vector2 v )
        {
            return new Vector4( 0f, v.y, v.x, 0f );
        }

        public static Vector4 _YYX( this Vector2 v )
        {
            return new Vector4( 0f, v.y, v.y, v.x );
        }

        public static Vector4 _YYY( this Vector2 v )
        {
            return new Vector4( 0f, v.y, v.y, v.y );
        }

        public static Vector4 _YY_( this Vector2 v )
        {
            return new Vector4( 0f, v.y, v.y, 0f );
        }

        public static Vector4 _Y_X( this Vector2 v )
        {
            return new Vector4( 0f, v.y, 0f, v.x );
        }

        public static Vector4 _Y_Y( this Vector2 v )
        {
            return new Vector4( 0f, v.y, 0f, v.y );
        }

        public static Vector4 _Y__( this Vector2 v )
        {
            return new Vector4( 0f, v.y, 0f, 0f );
        }

        public static Vector4 __XX( this Vector2 v )
        {
            return new Vector4( 0f, 0f, v.x, v.x );
        }

        public static Vector4 __XY( this Vector2 v )
        {
            return new Vector4( 0f, 0f, v.x, v.y );
        }

        public static Vector4 __X_( this Vector2 v )
        {
            return new Vector4( 0f, 0f, v.x, 0f );
        }

        public static Vector4 __YX( this Vector2 v )
        {
            return new Vector4( 0f, 0f, v.y, v.x );
        }

        public static Vector4 __YY( this Vector2 v )
        {
            return new Vector4( 0f, 0f, v.y, v.y );
        }

        public static Vector4 __Y_( this Vector2 v )
        {
            return new Vector4( 0f, 0f, v.y, 0f );
        }

        public static Vector4 ___X( this Vector2 v )
        {
            return new Vector4( 0f, 0f, 0f, v.x );
        }

        public static Vector4 ___Y( this Vector2 v )
        {
            return new Vector4( 0f, 0f, 0f, v.y );
        }
        #endregion Vector2.XXXX

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

        #region Vector3.XXXX
        public static Vector4 XXXX( this Vector3 v )
        {
            return new Vector4( v.x, v.x, v.x, v.x );
        }

        public static Vector4 XXXY( this Vector3 v )
        {
            return new Vector4( v.x, v.x, v.x, v.y );
        }

        public static Vector4 XXXZ( this Vector3 v )
        {
            return new Vector4( v.x, v.x, v.x, v.z );
        }

        public static Vector4 XXX_( this Vector3 v )
        {
            return new Vector4( v.x, v.x, v.x, 0f );
        }

        public static Vector4 XXYX( this Vector3 v )
        {
            return new Vector4( v.x, v.x, v.y, v.x );
        }

        public static Vector4 XXYY( this Vector3 v )
        {
            return new Vector4( v.x, v.x, v.y, v.y );
        }

        public static Vector4 XXYZ( this Vector3 v )
        {
            return new Vector4( v.x, v.x, v.y, v.z );
        }

        public static Vector4 XXY_( this Vector3 v )
        {
            return new Vector4( v.x, v.x, v.y, 0f );
        }

        public static Vector4 XXZX( this Vector3 v )
        {
            return new Vector4( v.x, v.x, v.z, v.x );
        }

        public static Vector4 XXZY( this Vector3 v )
        {
            return new Vector4( v.x, v.x, v.z, v.y );
        }

        public static Vector4 XXZZ( this Vector3 v )
        {
            return new Vector4( v.x, v.x, v.z, v.z );
        }

        public static Vector4 XXZ_( this Vector3 v )
        {
            return new Vector4( v.x, v.x, v.z, 0f );
        }

        public static Vector4 XX_X( this Vector3 v )
        {
            return new Vector4( v.x, v.x, 0f, v.x );
        }

        public static Vector4 XX_Y( this Vector3 v )
        {
            return new Vector4( v.x, v.x, 0f, v.y );
        }

        public static Vector4 XX_Z( this Vector3 v )
        {
            return new Vector4( v.x, v.x, 0f, v.z );
        }

        public static Vector4 XX__( this Vector3 v )
        {
            return new Vector4( v.x, v.x, 0f, 0f );
        }

        public static Vector4 XYXX( this Vector3 v )
        {
            return new Vector4( v.x, v.y, v.x, v.x );
        }

        public static Vector4 XYXY( this Vector3 v )
        {
            return new Vector4( v.x, v.y, v.x, v.y );
        }

        public static Vector4 XYXZ( this Vector3 v )
        {
            return new Vector4( v.x, v.y, v.x, v.z );
        }

        public static Vector4 XYX_( this Vector3 v )
        {
            return new Vector4( v.x, v.y, v.x, 0f );
        }

        public static Vector4 XYYX( this Vector3 v )
        {
            return new Vector4( v.x, v.y, v.y, v.x );
        }

        public static Vector4 XYYY( this Vector3 v )
        {
            return new Vector4( v.x, v.y, v.y, v.y );
        }

        public static Vector4 XYYZ( this Vector3 v )
        {
            return new Vector4( v.x, v.y, v.y, v.z );
        }

        public static Vector4 XYY_( this Vector3 v )
        {
            return new Vector4( v.x, v.y, v.y, 0f );
        }

        public static Vector4 XYZX( this Vector3 v )
        {
            return new Vector4( v.x, v.y, v.z, v.x );
        }

        public static Vector4 XYZY( this Vector3 v )
        {
            return new Vector4( v.x, v.y, v.z, v.y );
        }

        public static Vector4 XYZZ( this Vector3 v )
        {
            return new Vector4( v.x, v.y, v.z, v.z );
        }

        public static Vector4 XYZ_( this Vector3 v )
        {
            return new Vector4( v.x, v.y, v.z, 0f );
        }

        public static Vector4 XY_X( this Vector3 v )
        {
            return new Vector4( v.x, v.y, 0f, v.x );
        }

        public static Vector4 XY_Y( this Vector3 v )
        {
            return new Vector4( v.x, v.y, 0f, v.y );
        }

        public static Vector4 XY_Z( this Vector3 v )
        {
            return new Vector4( v.x, v.y, 0f, v.z );
        }

        public static Vector4 XY__( this Vector3 v )
        {
            return new Vector4( v.x, v.y, 0f, 0f );
        }

        public static Vector4 XZXX( this Vector3 v )
        {
            return new Vector4( v.x, v.z, v.x, v.x );
        }

        public static Vector4 XZXY( this Vector3 v )
        {
            return new Vector4( v.x, v.z, v.x, v.y );
        }

        public static Vector4 XZXZ( this Vector3 v )
        {
            return new Vector4( v.x, v.z, v.x, v.z );
        }

        public static Vector4 XZX_( this Vector3 v )
        {
            return new Vector4( v.x, v.z, v.x, 0f );
        }

        public static Vector4 XZYX( this Vector3 v )
        {
            return new Vector4( v.x, v.z, v.y, v.x );
        }

        public static Vector4 XZYY( this Vector3 v )
        {
            return new Vector4( v.x, v.z, v.y, v.y );
        }

        public static Vector4 XZYZ( this Vector3 v )
        {
            return new Vector4( v.x, v.z, v.y, v.z );
        }

        public static Vector4 XZY_( this Vector3 v )
        {
            return new Vector4( v.x, v.z, v.y, 0f );
        }

        public static Vector4 XZZX( this Vector3 v )
        {
            return new Vector4( v.x, v.z, v.z, v.x );
        }

        public static Vector4 XZZY( this Vector3 v )
        {
            return new Vector4( v.x, v.z, v.z, v.y );
        }

        public static Vector4 XZZZ( this Vector3 v )
        {
            return new Vector4( v.x, v.z, v.z, v.z );
        }

        public static Vector4 XZZ_( this Vector3 v )
        {
            return new Vector4( v.x, v.z, v.z, 0f );
        }

        public static Vector4 XZ_X( this Vector3 v )
        {
            return new Vector4( v.x, v.z, 0f, v.x );
        }

        public static Vector4 XZ_Y( this Vector3 v )
        {
            return new Vector4( v.x, v.z, 0f, v.y );
        }

        public static Vector4 XZ_Z( this Vector3 v )
        {
            return new Vector4( v.x, v.z, 0f, v.z );
        }

        public static Vector4 XZ__( this Vector3 v )
        {
            return new Vector4( v.x, v.z, 0f, 0f );
        }

        public static Vector4 X_XX( this Vector3 v )
        {
            return new Vector4( v.x, 0f, v.x, v.x );
        }

        public static Vector4 X_XY( this Vector3 v )
        {
            return new Vector4( v.x, 0f, v.x, v.y );
        }

        public static Vector4 X_XZ( this Vector3 v )
        {
            return new Vector4( v.x, 0f, v.x, v.z );
        }

        public static Vector4 X_X_( this Vector3 v )
        {
            return new Vector4( v.x, 0f, v.x, 0f );
        }

        public static Vector4 X_YX( this Vector3 v )
        {
            return new Vector4( v.x, 0f, v.y, v.x );
        }

        public static Vector4 X_YY( this Vector3 v )
        {
            return new Vector4( v.x, 0f, v.y, v.y );
        }

        public static Vector4 X_YZ( this Vector3 v )
        {
            return new Vector4( v.x, 0f, v.y, v.z );
        }

        public static Vector4 X_Y_( this Vector3 v )
        {
            return new Vector4( v.x, 0f, v.y, 0f );
        }

        public static Vector4 X_ZX( this Vector3 v )
        {
            return new Vector4( v.x, 0f, v.z, v.x );
        }

        public static Vector4 X_ZY( this Vector3 v )
        {
            return new Vector4( v.x, 0f, v.z, v.y );
        }

        public static Vector4 X_ZZ( this Vector3 v )
        {
            return new Vector4( v.x, 0f, v.z, v.z );
        }

        public static Vector4 X_Z_( this Vector3 v )
        {
            return new Vector4( v.x, 0f, v.z, 0f );
        }

        public static Vector4 X__X( this Vector3 v )
        {
            return new Vector4( v.x, 0f, 0f, v.x );
        }

        public static Vector4 X__Y( this Vector3 v )
        {
            return new Vector4( v.x, 0f, 0f, v.y );
        }

        public static Vector4 X__Z( this Vector3 v )
        {
            return new Vector4( v.x, 0f, 0f, v.z );
        }

        public static Vector4 X___( this Vector3 v )
        {
            return new Vector4( v.x, 0f, 0f, 0f );
        }

        public static Vector4 YXXX( this Vector3 v )
        {
            return new Vector4( v.y, v.x, v.x, v.x );
        }

        public static Vector4 YXXY( this Vector3 v )
        {
            return new Vector4( v.y, v.x, v.x, v.y );
        }

        public static Vector4 YXXZ( this Vector3 v )
        {
            return new Vector4( v.y, v.x, v.x, v.z );
        }

        public static Vector4 YXX_( this Vector3 v )
        {
            return new Vector4( v.y, v.x, v.x, 0f );
        }

        public static Vector4 YXYX( this Vector3 v )
        {
            return new Vector4( v.y, v.x, v.y, v.x );
        }

        public static Vector4 YXYY( this Vector3 v )
        {
            return new Vector4( v.y, v.x, v.y, v.y );
        }

        public static Vector4 YXYZ( this Vector3 v )
        {
            return new Vector4( v.y, v.x, v.y, v.z );
        }

        public static Vector4 YXY_( this Vector3 v )
        {
            return new Vector4( v.y, v.x, v.y, 0f );
        }

        public static Vector4 YXZX( this Vector3 v )
        {
            return new Vector4( v.y, v.x, v.z, v.x );
        }

        public static Vector4 YXZY( this Vector3 v )
        {
            return new Vector4( v.y, v.x, v.z, v.y );
        }

        public static Vector4 YXZZ( this Vector3 v )
        {
            return new Vector4( v.y, v.x, v.z, v.z );
        }

        public static Vector4 YXZ_( this Vector3 v )
        {
            return new Vector4( v.y, v.x, v.z, 0f );
        }

        public static Vector4 YX_X( this Vector3 v )
        {
            return new Vector4( v.y, v.x, 0f, v.x );
        }

        public static Vector4 YX_Y( this Vector3 v )
        {
            return new Vector4( v.y, v.x, 0f, v.y );
        }

        public static Vector4 YX_Z( this Vector3 v )
        {
            return new Vector4( v.y, v.x, 0f, v.z );
        }

        public static Vector4 YX__( this Vector3 v )
        {
            return new Vector4( v.y, v.x, 0f, 0f );
        }

        public static Vector4 YYXX( this Vector3 v )
        {
            return new Vector4( v.y, v.y, v.x, v.x );
        }

        public static Vector4 YYXY( this Vector3 v )
        {
            return new Vector4( v.y, v.y, v.x, v.y );
        }

        public static Vector4 YYXZ( this Vector3 v )
        {
            return new Vector4( v.y, v.y, v.x, v.z );
        }

        public static Vector4 YYX_( this Vector3 v )
        {
            return new Vector4( v.y, v.y, v.x, 0f );
        }

        public static Vector4 YYYX( this Vector3 v )
        {
            return new Vector4( v.y, v.y, v.y, v.x );
        }

        public static Vector4 YYYY( this Vector3 v )
        {
            return new Vector4( v.y, v.y, v.y, v.y );
        }

        public static Vector4 YYYZ( this Vector3 v )
        {
            return new Vector4( v.y, v.y, v.y, v.z );
        }

        public static Vector4 YYY_( this Vector3 v )
        {
            return new Vector4( v.y, v.y, v.y, 0f );
        }

        public static Vector4 YYZX( this Vector3 v )
        {
            return new Vector4( v.y, v.y, v.z, v.x );
        }

        public static Vector4 YYZY( this Vector3 v )
        {
            return new Vector4( v.y, v.y, v.z, v.y );
        }

        public static Vector4 YYZZ( this Vector3 v )
        {
            return new Vector4( v.y, v.y, v.z, v.z );
        }

        public static Vector4 YYZ_( this Vector3 v )
        {
            return new Vector4( v.y, v.y, v.z, 0f );
        }

        public static Vector4 YY_X( this Vector3 v )
        {
            return new Vector4( v.y, v.y, 0f, v.x );
        }

        public static Vector4 YY_Y( this Vector3 v )
        {
            return new Vector4( v.y, v.y, 0f, v.y );
        }

        public static Vector4 YY_Z( this Vector3 v )
        {
            return new Vector4( v.y, v.y, 0f, v.z );
        }

        public static Vector4 YY__( this Vector3 v )
        {
            return new Vector4( v.y, v.y, 0f, 0f );
        }

        public static Vector4 YZXX( this Vector3 v )
        {
            return new Vector4( v.y, v.z, v.x, v.x );
        }

        public static Vector4 YZXY( this Vector3 v )
        {
            return new Vector4( v.y, v.z, v.x, v.y );
        }

        public static Vector4 YZXZ( this Vector3 v )
        {
            return new Vector4( v.y, v.z, v.x, v.z );
        }

        public static Vector4 YZX_( this Vector3 v )
        {
            return new Vector4( v.y, v.z, v.x, 0f );
        }

        public static Vector4 YZYX( this Vector3 v )
        {
            return new Vector4( v.y, v.z, v.y, v.x );
        }

        public static Vector4 YZYY( this Vector3 v )
        {
            return new Vector4( v.y, v.z, v.y, v.y );
        }

        public static Vector4 YZYZ( this Vector3 v )
        {
            return new Vector4( v.y, v.z, v.y, v.z );
        }

        public static Vector4 YZY_( this Vector3 v )
        {
            return new Vector4( v.y, v.z, v.y, 0f );
        }

        public static Vector4 YZZX( this Vector3 v )
        {
            return new Vector4( v.y, v.z, v.z, v.x );
        }

        public static Vector4 YZZY( this Vector3 v )
        {
            return new Vector4( v.y, v.z, v.z, v.y );
        }

        public static Vector4 YZZZ( this Vector3 v )
        {
            return new Vector4( v.y, v.z, v.z, v.z );
        }

        public static Vector4 YZZ_( this Vector3 v )
        {
            return new Vector4( v.y, v.z, v.z, 0f );
        }

        public static Vector4 YZ_X( this Vector3 v )
        {
            return new Vector4( v.y, v.z, 0f, v.x );
        }

        public static Vector4 YZ_Y( this Vector3 v )
        {
            return new Vector4( v.y, v.z, 0f, v.y );
        }

        public static Vector4 YZ_Z( this Vector3 v )
        {
            return new Vector4( v.y, v.z, 0f, v.z );
        }

        public static Vector4 YZ__( this Vector3 v )
        {
            return new Vector4( v.y, v.z, 0f, 0f );
        }

        public static Vector4 Y_XX( this Vector3 v )
        {
            return new Vector4( v.y, 0f, v.x, v.x );
        }

        public static Vector4 Y_XY( this Vector3 v )
        {
            return new Vector4( v.y, 0f, v.x, v.y );
        }

        public static Vector4 Y_XZ( this Vector3 v )
        {
            return new Vector4( v.y, 0f, v.x, v.z );
        }

        public static Vector4 Y_X_( this Vector3 v )
        {
            return new Vector4( v.y, 0f, v.x, 0f );
        }

        public static Vector4 Y_YX( this Vector3 v )
        {
            return new Vector4( v.y, 0f, v.y, v.x );
        }

        public static Vector4 Y_YY( this Vector3 v )
        {
            return new Vector4( v.y, 0f, v.y, v.y );
        }

        public static Vector4 Y_YZ( this Vector3 v )
        {
            return new Vector4( v.y, 0f, v.y, v.z );
        }

        public static Vector4 Y_Y_( this Vector3 v )
        {
            return new Vector4( v.y, 0f, v.y, 0f );
        }

        public static Vector4 Y_ZX( this Vector3 v )
        {
            return new Vector4( v.y, 0f, v.z, v.x );
        }

        public static Vector4 Y_ZY( this Vector3 v )
        {
            return new Vector4( v.y, 0f, v.z, v.y );
        }

        public static Vector4 Y_ZZ( this Vector3 v )
        {
            return new Vector4( v.y, 0f, v.z, v.z );
        }

        public static Vector4 Y_Z_( this Vector3 v )
        {
            return new Vector4( v.y, 0f, v.z, 0f );
        }

        public static Vector4 Y__X( this Vector3 v )
        {
            return new Vector4( v.y, 0f, 0f, v.x );
        }

        public static Vector4 Y__Y( this Vector3 v )
        {
            return new Vector4( v.y, 0f, 0f, v.y );
        }

        public static Vector4 Y__Z( this Vector3 v )
        {
            return new Vector4( v.y, 0f, 0f, v.z );
        }

        public static Vector4 Y___( this Vector3 v )
        {
            return new Vector4( v.y, 0f, 0f, 0f );
        }

        public static Vector4 ZXXX( this Vector3 v )
        {
            return new Vector4( v.z, v.x, v.x, v.x );
        }

        public static Vector4 ZXXY( this Vector3 v )
        {
            return new Vector4( v.z, v.x, v.x, v.y );
        }

        public static Vector4 ZXXZ( this Vector3 v )
        {
            return new Vector4( v.z, v.x, v.x, v.z );
        }

        public static Vector4 ZXX_( this Vector3 v )
        {
            return new Vector4( v.z, v.x, v.x, 0f );
        }

        public static Vector4 ZXYX( this Vector3 v )
        {
            return new Vector4( v.z, v.x, v.y, v.x );
        }

        public static Vector4 ZXYY( this Vector3 v )
        {
            return new Vector4( v.z, v.x, v.y, v.y );
        }

        public static Vector4 ZXYZ( this Vector3 v )
        {
            return new Vector4( v.z, v.x, v.y, v.z );
        }

        public static Vector4 ZXY_( this Vector3 v )
        {
            return new Vector4( v.z, v.x, v.y, 0f );
        }

        public static Vector4 ZXZX( this Vector3 v )
        {
            return new Vector4( v.z, v.x, v.z, v.x );
        }

        public static Vector4 ZXZY( this Vector3 v )
        {
            return new Vector4( v.z, v.x, v.z, v.y );
        }

        public static Vector4 ZXZZ( this Vector3 v )
        {
            return new Vector4( v.z, v.x, v.z, v.z );
        }

        public static Vector4 ZXZ_( this Vector3 v )
        {
            return new Vector4( v.z, v.x, v.z, 0f );
        }

        public static Vector4 ZX_X( this Vector3 v )
        {
            return new Vector4( v.z, v.x, 0f, v.x );
        }

        public static Vector4 ZX_Y( this Vector3 v )
        {
            return new Vector4( v.z, v.x, 0f, v.y );
        }

        public static Vector4 ZX_Z( this Vector3 v )
        {
            return new Vector4( v.z, v.x, 0f, v.z );
        }

        public static Vector4 ZX__( this Vector3 v )
        {
            return new Vector4( v.z, v.x, 0f, 0f );
        }

        public static Vector4 ZYXX( this Vector3 v )
        {
            return new Vector4( v.z, v.y, v.x, v.x );
        }

        public static Vector4 ZYXY( this Vector3 v )
        {
            return new Vector4( v.z, v.y, v.x, v.y );
        }

        public static Vector4 ZYXZ( this Vector3 v )
        {
            return new Vector4( v.z, v.y, v.x, v.z );
        }

        public static Vector4 ZYX_( this Vector3 v )
        {
            return new Vector4( v.z, v.y, v.x, 0f );
        }

        public static Vector4 ZYYX( this Vector3 v )
        {
            return new Vector4( v.z, v.y, v.y, v.x );
        }

        public static Vector4 ZYYY( this Vector3 v )
        {
            return new Vector4( v.z, v.y, v.y, v.y );
        }

        public static Vector4 ZYYZ( this Vector3 v )
        {
            return new Vector4( v.z, v.y, v.y, v.z );
        }

        public static Vector4 ZYY_( this Vector3 v )
        {
            return new Vector4( v.z, v.y, v.y, 0f );
        }

        public static Vector4 ZYZX( this Vector3 v )
        {
            return new Vector4( v.z, v.y, v.z, v.x );
        }

        public static Vector4 ZYZY( this Vector3 v )
        {
            return new Vector4( v.z, v.y, v.z, v.y );
        }

        public static Vector4 ZYZZ( this Vector3 v )
        {
            return new Vector4( v.z, v.y, v.z, v.z );
        }

        public static Vector4 ZYZ_( this Vector3 v )
        {
            return new Vector4( v.z, v.y, v.z, 0f );
        }

        public static Vector4 ZY_X( this Vector3 v )
        {
            return new Vector4( v.z, v.y, 0f, v.x );
        }

        public static Vector4 ZY_Y( this Vector3 v )
        {
            return new Vector4( v.z, v.y, 0f, v.y );
        }

        public static Vector4 ZY_Z( this Vector3 v )
        {
            return new Vector4( v.z, v.y, 0f, v.z );
        }

        public static Vector4 ZY__( this Vector3 v )
        {
            return new Vector4( v.z, v.y, 0f, 0f );
        }

        public static Vector4 ZZXX( this Vector3 v )
        {
            return new Vector4( v.z, v.z, v.x, v.x );
        }

        public static Vector4 ZZXY( this Vector3 v )
        {
            return new Vector4( v.z, v.z, v.x, v.y );
        }

        public static Vector4 ZZXZ( this Vector3 v )
        {
            return new Vector4( v.z, v.z, v.x, v.z );
        }

        public static Vector4 ZZX_( this Vector3 v )
        {
            return new Vector4( v.z, v.z, v.x, 0f );
        }

        public static Vector4 ZZYX( this Vector3 v )
        {
            return new Vector4( v.z, v.z, v.y, v.x );
        }

        public static Vector4 ZZYY( this Vector3 v )
        {
            return new Vector4( v.z, v.z, v.y, v.y );
        }

        public static Vector4 ZZYZ( this Vector3 v )
        {
            return new Vector4( v.z, v.z, v.y, v.z );
        }

        public static Vector4 ZZY_( this Vector3 v )
        {
            return new Vector4( v.z, v.z, v.y, 0f );
        }

        public static Vector4 ZZZX( this Vector3 v )
        {
            return new Vector4( v.z, v.z, v.z, v.x );
        }

        public static Vector4 ZZZY( this Vector3 v )
        {
            return new Vector4( v.z, v.z, v.z, v.y );
        }

        public static Vector4 ZZZZ( this Vector3 v )
        {
            return new Vector4( v.z, v.z, v.z, v.z );
        }

        public static Vector4 ZZZ_( this Vector3 v )
        {
            return new Vector4( v.z, v.z, v.z, 0f );
        }

        public static Vector4 ZZ_X( this Vector3 v )
        {
            return new Vector4( v.z, v.z, 0f, v.x );
        }

        public static Vector4 ZZ_Y( this Vector3 v )
        {
            return new Vector4( v.z, v.z, 0f, v.y );
        }

        public static Vector4 ZZ_Z( this Vector3 v )
        {
            return new Vector4( v.z, v.z, 0f, v.z );
        }

        public static Vector4 ZZ__( this Vector3 v )
        {
            return new Vector4( v.z, v.z, 0f, 0f );
        }

        public static Vector4 Z_XX( this Vector3 v )
        {
            return new Vector4( v.z, 0f, v.x, v.x );
        }

        public static Vector4 Z_XY( this Vector3 v )
        {
            return new Vector4( v.z, 0f, v.x, v.y );
        }

        public static Vector4 Z_XZ( this Vector3 v )
        {
            return new Vector4( v.z, 0f, v.x, v.z );
        }

        public static Vector4 Z_X_( this Vector3 v )
        {
            return new Vector4( v.z, 0f, v.x, 0f );
        }

        public static Vector4 Z_YX( this Vector3 v )
        {
            return new Vector4( v.z, 0f, v.y, v.x );
        }

        public static Vector4 Z_YY( this Vector3 v )
        {
            return new Vector4( v.z, 0f, v.y, v.y );
        }

        public static Vector4 Z_YZ( this Vector3 v )
        {
            return new Vector4( v.z, 0f, v.y, v.z );
        }

        public static Vector4 Z_Y_( this Vector3 v )
        {
            return new Vector4( v.z, 0f, v.y, 0f );
        }

        public static Vector4 Z_ZX( this Vector3 v )
        {
            return new Vector4( v.z, 0f, v.z, v.x );
        }

        public static Vector4 Z_ZY( this Vector3 v )
        {
            return new Vector4( v.z, 0f, v.z, v.y );
        }

        public static Vector4 Z_ZZ( this Vector3 v )
        {
            return new Vector4( v.z, 0f, v.z, v.z );
        }

        public static Vector4 Z_Z_( this Vector3 v )
        {
            return new Vector4( v.z, 0f, v.z, 0f );
        }

        public static Vector4 Z__X( this Vector3 v )
        {
            return new Vector4( v.z, 0f, 0f, v.x );
        }

        public static Vector4 Z__Y( this Vector3 v )
        {
            return new Vector4( v.z, 0f, 0f, v.y );
        }

        public static Vector4 Z__Z( this Vector3 v )
        {
            return new Vector4( v.z, 0f, 0f, v.z );
        }

        public static Vector4 Z___( this Vector3 v )
        {
            return new Vector4( v.z, 0f, 0f, 0f );
        }

        public static Vector4 _XXX( this Vector3 v )
        {
            return new Vector4( 0f, v.x, v.x, v.x );
        }

        public static Vector4 _XXY( this Vector3 v )
        {
            return new Vector4( 0f, v.x, v.x, v.y );
        }

        public static Vector4 _XXZ( this Vector3 v )
        {
            return new Vector4( 0f, v.x, v.x, v.z );
        }

        public static Vector4 _XX_( this Vector3 v )
        {
            return new Vector4( 0f, v.x, v.x, 0f );
        }

        public static Vector4 _XYX( this Vector3 v )
        {
            return new Vector4( 0f, v.x, v.y, v.x );
        }

        public static Vector4 _XYY( this Vector3 v )
        {
            return new Vector4( 0f, v.x, v.y, v.y );
        }

        public static Vector4 _XYZ( this Vector3 v )
        {
            return new Vector4( 0f, v.x, v.y, v.z );
        }

        public static Vector4 _XY_( this Vector3 v )
        {
            return new Vector4( 0f, v.x, v.y, 0f );
        }

        public static Vector4 _XZX( this Vector3 v )
        {
            return new Vector4( 0f, v.x, v.z, v.x );
        }

        public static Vector4 _XZY( this Vector3 v )
        {
            return new Vector4( 0f, v.x, v.z, v.y );
        }

        public static Vector4 _XZZ( this Vector3 v )
        {
            return new Vector4( 0f, v.x, v.z, v.z );
        }

        public static Vector4 _XZ_( this Vector3 v )
        {
            return new Vector4( 0f, v.x, v.z, 0f );
        }

        public static Vector4 _X_X( this Vector3 v )
        {
            return new Vector4( 0f, v.x, 0f, v.x );
        }

        public static Vector4 _X_Y( this Vector3 v )
        {
            return new Vector4( 0f, v.x, 0f, v.y );
        }

        public static Vector4 _X_Z( this Vector3 v )
        {
            return new Vector4( 0f, v.x, 0f, v.z );
        }

        public static Vector4 _X__( this Vector3 v )
        {
            return new Vector4( 0f, v.x, 0f, 0f );
        }

        public static Vector4 _YXX( this Vector3 v )
        {
            return new Vector4( 0f, v.y, v.x, v.x );
        }

        public static Vector4 _YXY( this Vector3 v )
        {
            return new Vector4( 0f, v.y, v.x, v.y );
        }

        public static Vector4 _YXZ( this Vector3 v )
        {
            return new Vector4( 0f, v.y, v.x, v.z );
        }

        public static Vector4 _YX_( this Vector3 v )
        {
            return new Vector4( 0f, v.y, v.x, 0f );
        }

        public static Vector4 _YYX( this Vector3 v )
        {
            return new Vector4( 0f, v.y, v.y, v.x );
        }

        public static Vector4 _YYY( this Vector3 v )
        {
            return new Vector4( 0f, v.y, v.y, v.y );
        }

        public static Vector4 _YYZ( this Vector3 v )
        {
            return new Vector4( 0f, v.y, v.y, v.z );
        }

        public static Vector4 _YY_( this Vector3 v )
        {
            return new Vector4( 0f, v.y, v.y, 0f );
        }

        public static Vector4 _YZX( this Vector3 v )
        {
            return new Vector4( 0f, v.y, v.z, v.x );
        }

        public static Vector4 _YZY( this Vector3 v )
        {
            return new Vector4( 0f, v.y, v.z, v.y );
        }

        public static Vector4 _YZZ( this Vector3 v )
        {
            return new Vector4( 0f, v.y, v.z, v.z );
        }

        public static Vector4 _YZ_( this Vector3 v )
        {
            return new Vector4( 0f, v.y, v.z, 0f );
        }

        public static Vector4 _Y_X( this Vector3 v )
        {
            return new Vector4( 0f, v.y, 0f, v.x );
        }

        public static Vector4 _Y_Y( this Vector3 v )
        {
            return new Vector4( 0f, v.y, 0f, v.y );
        }

        public static Vector4 _Y_Z( this Vector3 v )
        {
            return new Vector4( 0f, v.y, 0f, v.z );
        }

        public static Vector4 _Y__( this Vector3 v )
        {
            return new Vector4( 0f, v.y, 0f, 0f );
        }

        public static Vector4 _ZXX( this Vector3 v )
        {
            return new Vector4( 0f, v.z, v.x, v.x );
        }

        public static Vector4 _ZXY( this Vector3 v )
        {
            return new Vector4( 0f, v.z, v.x, v.y );
        }

        public static Vector4 _ZXZ( this Vector3 v )
        {
            return new Vector4( 0f, v.z, v.x, v.z );
        }

        public static Vector4 _ZX_( this Vector3 v )
        {
            return new Vector4( 0f, v.z, v.x, 0f );
        }

        public static Vector4 _ZYX( this Vector3 v )
        {
            return new Vector4( 0f, v.z, v.y, v.x );
        }

        public static Vector4 _ZYY( this Vector3 v )
        {
            return new Vector4( 0f, v.z, v.y, v.y );
        }

        public static Vector4 _ZYZ( this Vector3 v )
        {
            return new Vector4( 0f, v.z, v.y, v.z );
        }

        public static Vector4 _ZY_( this Vector3 v )
        {
            return new Vector4( 0f, v.z, v.y, 0f );
        }

        public static Vector4 _ZZX( this Vector3 v )
        {
            return new Vector4( 0f, v.z, v.z, v.x );
        }

        public static Vector4 _ZZY( this Vector3 v )
        {
            return new Vector4( 0f, v.z, v.z, v.y );
        }

        public static Vector4 _ZZZ( this Vector3 v )
        {
            return new Vector4( 0f, v.z, v.z, v.z );
        }

        public static Vector4 _ZZ_( this Vector3 v )
        {
            return new Vector4( 0f, v.z, v.z, 0f );
        }

        public static Vector4 _Z_X( this Vector3 v )
        {
            return new Vector4( 0f, v.z, 0f, v.x );
        }

        public static Vector4 _Z_Y( this Vector3 v )
        {
            return new Vector4( 0f, v.z, 0f, v.y );
        }

        public static Vector4 _Z_Z( this Vector3 v )
        {
            return new Vector4( 0f, v.z, 0f, v.z );
        }

        public static Vector4 _Z__( this Vector3 v )
        {
            return new Vector4( 0f, v.z, 0f, 0f );
        }

        public static Vector4 __XX( this Vector3 v )
        {
            return new Vector4( 0f, 0f, v.x, v.x );
        }

        public static Vector4 __XY( this Vector3 v )
        {
            return new Vector4( 0f, 0f, v.x, v.y );
        }

        public static Vector4 __XZ( this Vector3 v )
        {
            return new Vector4( 0f, 0f, v.x, v.z );
        }

        public static Vector4 __X_( this Vector3 v )
        {
            return new Vector4( 0f, 0f, v.x, 0f );
        }

        public static Vector4 __YX( this Vector3 v )
        {
            return new Vector4( 0f, 0f, v.y, v.x );
        }

        public static Vector4 __YY( this Vector3 v )
        {
            return new Vector4( 0f, 0f, v.y, v.y );
        }

        public static Vector4 __YZ( this Vector3 v )
        {
            return new Vector4( 0f, 0f, v.y, v.z );
        }

        public static Vector4 __Y_( this Vector3 v )
        {
            return new Vector4( 0f, 0f, v.y, 0f );
        }

        public static Vector4 __ZX( this Vector3 v )
        {
            return new Vector4( 0f, 0f, v.z, v.x );
        }

        public static Vector4 __ZY( this Vector3 v )
        {
            return new Vector4( 0f, 0f, v.z, v.y );
        }

        public static Vector4 __ZZ( this Vector3 v )
        {
            return new Vector4( 0f, 0f, v.z, v.z );
        }

        public static Vector4 __Z_( this Vector3 v )
        {
            return new Vector4( 0f, 0f, v.z, 0f );
        }

        public static Vector4 ___X( this Vector3 v )
        {
            return new Vector4( 0f, 0f, 0f, v.x );
        }

        public static Vector4 ___Y( this Vector3 v )
        {
            return new Vector4( 0f, 0f, 0f, v.y );
        }

        public static Vector4 ___Z( this Vector3 v )
        {
            return new Vector4( 0f, 0f, 0f, v.z );
        }
        #endregion Vector3.XXXX

        #region Vector4.XX
        public static Vector2 XX( this Vector4 v )
        {
            return new Vector2( v.x, v.x );
        }

        public static Vector2 XY( this Vector4 v )
        {
            return new Vector2( v.x, v.y );
        }

        public static Vector2 XZ( this Vector4 v )
        {
            return new Vector2( v.x, v.z );
        }

        public static Vector2 XW( this Vector4 v )
        {
            return new Vector2( v.x, v.w );
        }

        public static Vector2 X_( this Vector4 v )
        {
            return new Vector2( v.x, 0f );
        }

        public static Vector2 YX( this Vector4 v )
        {
            return new Vector2( v.y, v.x );
        }

        public static Vector2 YY( this Vector4 v )
        {
            return new Vector2( v.y, v.y );
        }

        public static Vector2 YZ( this Vector4 v )
        {
            return new Vector2( v.y, v.z );
        }

        public static Vector2 YW( this Vector4 v )
        {
            return new Vector2( v.y, v.w );
        }

        public static Vector2 Y_( this Vector4 v )
        {
            return new Vector2( v.y, 0f );
        }

        public static Vector2 ZX( this Vector4 v )
        {
            return new Vector2( v.z, v.x );
        }

        public static Vector2 ZY( this Vector4 v )
        {
            return new Vector2( v.z, v.y );
        }

        public static Vector2 ZZ( this Vector4 v )
        {
            return new Vector2( v.z, v.z );
        }

        public static Vector2 ZW( this Vector4 v )
        {
            return new Vector2( v.z, v.w );
        }

        public static Vector2 Z_( this Vector4 v )
        {
            return new Vector2( v.z, 0f );
        }

        public static Vector2 WX( this Vector4 v )
        {
            return new Vector2( v.w, v.x );
        }

        public static Vector2 WY( this Vector4 v )
        {
            return new Vector2( v.w, v.y );
        }

        public static Vector2 WZ( this Vector4 v )
        {
            return new Vector2( v.w, v.z );
        }

        public static Vector2 WW( this Vector4 v )
        {
            return new Vector2( v.w, v.w );
        }

        public static Vector2 W_( this Vector4 v )
        {
            return new Vector2( v.w, 0f );
        }

        public static Vector2 _X( this Vector4 v )
        {
            return new Vector2( 0f, v.x );
        }

        public static Vector2 _Y( this Vector4 v )
        {
            return new Vector2( 0f, v.y );
        }

        public static Vector2 _Z( this Vector4 v )
        {
            return new Vector2( 0f, v.z );
        }

        public static Vector2 _W( this Vector4 v )
        {
            return new Vector2( 0f, v.w );
        }
        #endregion Vector4.XX

        #region Vector4.XXX
        public static Vector3 XXX( this Vector4 v )
        {
            return new Vector3( v.x, v.x, v.x );
        }

        public static Vector3 XXY( this Vector4 v )
        {
            return new Vector3( v.x, v.x, v.y );
        }

        public static Vector3 XXZ( this Vector4 v )
        {
            return new Vector3( v.x, v.x, v.z );
        }

        public static Vector3 XXW( this Vector4 v )
        {
            return new Vector3( v.x, v.x, v.w );
        }

        public static Vector3 XX_( this Vector4 v )
        {
            return new Vector3( v.x, v.x, 0f );
        }

        public static Vector3 XYX( this Vector4 v )
        {
            return new Vector3( v.x, v.y, v.x );
        }

        public static Vector3 XYY( this Vector4 v )
        {
            return new Vector3( v.x, v.y, v.y );
        }

        public static Vector3 XYZ( this Vector4 v )
        {
            return new Vector3( v.x, v.y, v.z );
        }

        public static Vector3 XYW( this Vector4 v )
        {
            return new Vector3( v.x, v.y, v.w );
        }

        public static Vector3 XY_( this Vector4 v )
        {
            return new Vector3( v.x, v.y, 0f );
        }

        public static Vector3 XZX( this Vector4 v )
        {
            return new Vector3( v.x, v.z, v.x );
        }

        public static Vector3 XZY( this Vector4 v )
        {
            return new Vector3( v.x, v.z, v.y );
        }

        public static Vector3 XZZ( this Vector4 v )
        {
            return new Vector3( v.x, v.z, v.z );
        }

        public static Vector3 XZW( this Vector4 v )
        {
            return new Vector3( v.x, v.z, v.w );
        }

        public static Vector3 XZ_( this Vector4 v )
        {
            return new Vector3( v.x, v.z, 0f );
        }

        public static Vector3 XWX( this Vector4 v )
        {
            return new Vector3( v.x, v.w, v.x );
        }

        public static Vector3 XWY( this Vector4 v )
        {
            return new Vector3( v.x, v.w, v.y );
        }

        public static Vector3 XWZ( this Vector4 v )
        {
            return new Vector3( v.x, v.w, v.z );
        }

        public static Vector3 XWW( this Vector4 v )
        {
            return new Vector3( v.x, v.w, v.w );
        }

        public static Vector3 XW_( this Vector4 v )
        {
            return new Vector3( v.x, v.w, 0f );
        }

        public static Vector3 X_X( this Vector4 v )
        {
            return new Vector3( v.x, 0f, v.x );
        }

        public static Vector3 X_Y( this Vector4 v )
        {
            return new Vector3( v.x, 0f, v.y );
        }

        public static Vector3 X_Z( this Vector4 v )
        {
            return new Vector3( v.x, 0f, v.z );
        }

        public static Vector3 X_W( this Vector4 v )
        {
            return new Vector3( v.x, 0f, v.w );
        }

        public static Vector3 X__( this Vector4 v )
        {
            return new Vector3( v.x, 0f, 0f );
        }

        public static Vector3 YXX( this Vector4 v )
        {
            return new Vector3( v.y, v.x, v.x );
        }

        public static Vector3 YXY( this Vector4 v )
        {
            return new Vector3( v.y, v.x, v.y );
        }

        public static Vector3 YXZ( this Vector4 v )
        {
            return new Vector3( v.y, v.x, v.z );
        }

        public static Vector3 YXW( this Vector4 v )
        {
            return new Vector3( v.y, v.x, v.w );
        }

        public static Vector3 YX_( this Vector4 v )
        {
            return new Vector3( v.y, v.x, 0f );
        }

        public static Vector3 YYX( this Vector4 v )
        {
            return new Vector3( v.y, v.y, v.x );
        }

        public static Vector3 YYY( this Vector4 v )
        {
            return new Vector3( v.y, v.y, v.y );
        }

        public static Vector3 YYZ( this Vector4 v )
        {
            return new Vector3( v.y, v.y, v.z );
        }

        public static Vector3 YYW( this Vector4 v )
        {
            return new Vector3( v.y, v.y, v.w );
        }

        public static Vector3 YY_( this Vector4 v )
        {
            return new Vector3( v.y, v.y, 0f );
        }

        public static Vector3 YZX( this Vector4 v )
        {
            return new Vector3( v.y, v.z, v.x );
        }

        public static Vector3 YZY( this Vector4 v )
        {
            return new Vector3( v.y, v.z, v.y );
        }

        public static Vector3 YZZ( this Vector4 v )
        {
            return new Vector3( v.y, v.z, v.z );
        }

        public static Vector3 YZW( this Vector4 v )
        {
            return new Vector3( v.y, v.z, v.w );
        }

        public static Vector3 YZ_( this Vector4 v )
        {
            return new Vector3( v.y, v.z, 0f );
        }

        public static Vector3 YWX( this Vector4 v )
        {
            return new Vector3( v.y, v.w, v.x );
        }

        public static Vector3 YWY( this Vector4 v )
        {
            return new Vector3( v.y, v.w, v.y );
        }

        public static Vector3 YWZ( this Vector4 v )
        {
            return new Vector3( v.y, v.w, v.z );
        }

        public static Vector3 YWW( this Vector4 v )
        {
            return new Vector3( v.y, v.w, v.w );
        }

        public static Vector3 YW_( this Vector4 v )
        {
            return new Vector3( v.y, v.w, 0f );
        }

        public static Vector3 Y_X( this Vector4 v )
        {
            return new Vector3( v.y, 0f, v.x );
        }

        public static Vector3 Y_Y( this Vector4 v )
        {
            return new Vector3( v.y, 0f, v.y );
        }

        public static Vector3 Y_Z( this Vector4 v )
        {
            return new Vector3( v.y, 0f, v.z );
        }

        public static Vector3 Y_W( this Vector4 v )
        {
            return new Vector3( v.y, 0f, v.w );
        }

        public static Vector3 Y__( this Vector4 v )
        {
            return new Vector3( v.y, 0f, 0f );
        }

        public static Vector3 ZXX( this Vector4 v )
        {
            return new Vector3( v.z, v.x, v.x );
        }

        public static Vector3 ZXY( this Vector4 v )
        {
            return new Vector3( v.z, v.x, v.y );
        }

        public static Vector3 ZXZ( this Vector4 v )
        {
            return new Vector3( v.z, v.x, v.z );
        }

        public static Vector3 ZXW( this Vector4 v )
        {
            return new Vector3( v.z, v.x, v.w );
        }

        public static Vector3 ZX_( this Vector4 v )
        {
            return new Vector3( v.z, v.x, 0f );
        }

        public static Vector3 ZYX( this Vector4 v )
        {
            return new Vector3( v.z, v.y, v.x );
        }

        public static Vector3 ZYY( this Vector4 v )
        {
            return new Vector3( v.z, v.y, v.y );
        }

        public static Vector3 ZYZ( this Vector4 v )
        {
            return new Vector3( v.z, v.y, v.z );
        }

        public static Vector3 ZYW( this Vector4 v )
        {
            return new Vector3( v.z, v.y, v.w );
        }

        public static Vector3 ZY_( this Vector4 v )
        {
            return new Vector3( v.z, v.y, 0f );
        }

        public static Vector3 ZZX( this Vector4 v )
        {
            return new Vector3( v.z, v.z, v.x );
        }

        public static Vector3 ZZY( this Vector4 v )
        {
            return new Vector3( v.z, v.z, v.y );
        }

        public static Vector3 ZZZ( this Vector4 v )
        {
            return new Vector3( v.z, v.z, v.z );
        }

        public static Vector3 ZZW( this Vector4 v )
        {
            return new Vector3( v.z, v.z, v.w );
        }

        public static Vector3 ZZ_( this Vector4 v )
        {
            return new Vector3( v.z, v.z, 0f );
        }

        public static Vector3 ZWX( this Vector4 v )
        {
            return new Vector3( v.z, v.w, v.x );
        }

        public static Vector3 ZWY( this Vector4 v )
        {
            return new Vector3( v.z, v.w, v.y );
        }

        public static Vector3 ZWZ( this Vector4 v )
        {
            return new Vector3( v.z, v.w, v.z );
        }

        public static Vector3 ZWW( this Vector4 v )
        {
            return new Vector3( v.z, v.w, v.w );
        }

        public static Vector3 ZW_( this Vector4 v )
        {
            return new Vector3( v.z, v.w, 0f );
        }

        public static Vector3 Z_X( this Vector4 v )
        {
            return new Vector3( v.z, 0f, v.x );
        }

        public static Vector3 Z_Y( this Vector4 v )
        {
            return new Vector3( v.z, 0f, v.y );
        }

        public static Vector3 Z_Z( this Vector4 v )
        {
            return new Vector3( v.z, 0f, v.z );
        }

        public static Vector3 Z_W( this Vector4 v )
        {
            return new Vector3( v.z, 0f, v.w );
        }

        public static Vector3 Z__( this Vector4 v )
        {
            return new Vector3( v.z, 0f, 0f );
        }

        public static Vector3 WXX( this Vector4 v )
        {
            return new Vector3( v.w, v.x, v.x );
        }

        public static Vector3 WXY( this Vector4 v )
        {
            return new Vector3( v.w, v.x, v.y );
        }

        public static Vector3 WXZ( this Vector4 v )
        {
            return new Vector3( v.w, v.x, v.z );
        }

        public static Vector3 WXW( this Vector4 v )
        {
            return new Vector3( v.w, v.x, v.w );
        }

        public static Vector3 WX_( this Vector4 v )
        {
            return new Vector3( v.w, v.x, 0f );
        }

        public static Vector3 WYX( this Vector4 v )
        {
            return new Vector3( v.w, v.y, v.x );
        }

        public static Vector3 WYY( this Vector4 v )
        {
            return new Vector3( v.w, v.y, v.y );
        }

        public static Vector3 WYZ( this Vector4 v )
        {
            return new Vector3( v.w, v.y, v.z );
        }

        public static Vector3 WYW( this Vector4 v )
        {
            return new Vector3( v.w, v.y, v.w );
        }

        public static Vector3 WY_( this Vector4 v )
        {
            return new Vector3( v.w, v.y, 0f );
        }

        public static Vector3 WZX( this Vector4 v )
        {
            return new Vector3( v.w, v.z, v.x );
        }

        public static Vector3 WZY( this Vector4 v )
        {
            return new Vector3( v.w, v.z, v.y );
        }

        public static Vector3 WZZ( this Vector4 v )
        {
            return new Vector3( v.w, v.z, v.z );
        }

        public static Vector3 WZW( this Vector4 v )
        {
            return new Vector3( v.w, v.z, v.w );
        }

        public static Vector3 WZ_( this Vector4 v )
        {
            return new Vector3( v.w, v.z, 0f );
        }

        public static Vector3 WWX( this Vector4 v )
        {
            return new Vector3( v.w, v.w, v.x );
        }

        public static Vector3 WWY( this Vector4 v )
        {
            return new Vector3( v.w, v.w, v.y );
        }

        public static Vector3 WWZ( this Vector4 v )
        {
            return new Vector3( v.w, v.w, v.z );
        }

        public static Vector3 WWW( this Vector4 v )
        {
            return new Vector3( v.w, v.w, v.w );
        }

        public static Vector3 WW_( this Vector4 v )
        {
            return new Vector3( v.w, v.w, 0f );
        }

        public static Vector3 W_X( this Vector4 v )
        {
            return new Vector3( v.w, 0f, v.x );
        }

        public static Vector3 W_Y( this Vector4 v )
        {
            return new Vector3( v.w, 0f, v.y );
        }

        public static Vector3 W_Z( this Vector4 v )
        {
            return new Vector3( v.w, 0f, v.z );
        }

        public static Vector3 W_W( this Vector4 v )
        {
            return new Vector3( v.w, 0f, v.w );
        }

        public static Vector3 W__( this Vector4 v )
        {
            return new Vector3( v.w, 0f, 0f );
        }

        public static Vector3 _XX( this Vector4 v )
        {
            return new Vector3( 0f, v.x, v.x );
        }

        public static Vector3 _XY( this Vector4 v )
        {
            return new Vector3( 0f, v.x, v.y );
        }

        public static Vector3 _XZ( this Vector4 v )
        {
            return new Vector3( 0f, v.x, v.z );
        }

        public static Vector3 _XW( this Vector4 v )
        {
            return new Vector3( 0f, v.x, v.w );
        }

        public static Vector3 _X_( this Vector4 v )
        {
            return new Vector3( 0f, v.x, 0f );
        }

        public static Vector3 _YX( this Vector4 v )
        {
            return new Vector3( 0f, v.y, v.x );
        }

        public static Vector3 _YY( this Vector4 v )
        {
            return new Vector3( 0f, v.y, v.y );
        }

        public static Vector3 _YZ( this Vector4 v )
        {
            return new Vector3( 0f, v.y, v.z );
        }

        public static Vector3 _YW( this Vector4 v )
        {
            return new Vector3( 0f, v.y, v.w );
        }

        public static Vector3 _Y_( this Vector4 v )
        {
            return new Vector3( 0f, v.y, 0f );
        }

        public static Vector3 _ZX( this Vector4 v )
        {
            return new Vector3( 0f, v.z, v.x );
        }

        public static Vector3 _ZY( this Vector4 v )
        {
            return new Vector3( 0f, v.z, v.y );
        }

        public static Vector3 _ZZ( this Vector4 v )
        {
            return new Vector3( 0f, v.z, v.z );
        }

        public static Vector3 _ZW( this Vector4 v )
        {
            return new Vector3( 0f, v.z, v.w );
        }

        public static Vector3 _Z_( this Vector4 v )
        {
            return new Vector3( 0f, v.z, 0f );
        }

        public static Vector3 _WX( this Vector4 v )
        {
            return new Vector3( 0f, v.w, v.x );
        }

        public static Vector3 _WY( this Vector4 v )
        {
            return new Vector3( 0f, v.w, v.y );
        }

        public static Vector3 _WZ( this Vector4 v )
        {
            return new Vector3( 0f, v.w, v.z );
        }

        public static Vector3 _WW( this Vector4 v )
        {
            return new Vector3( 0f, v.w, v.w );
        }

        public static Vector3 _W_( this Vector4 v )
        {
            return new Vector3( 0f, v.w, 0f );
        }

        public static Vector3 __X( this Vector4 v )
        {
            return new Vector3( 0f, 0f, v.x );
        }

        public static Vector3 __Y( this Vector4 v )
        {
            return new Vector3( 0f, 0f, v.y );
        }

        public static Vector3 __Z( this Vector4 v )
        {
            return new Vector3( 0f, 0f, v.z );
        }

        public static Vector3 __W( this Vector4 v )
        {
            return new Vector3( 0f, 0f, v.w );
        }
        #endregion Vector4.XXX

        #region Vector4.XXXX
        public static Vector4 XXXX( this Vector4 v )
        {
            return new Vector4( v.x, v.x, v.x, v.x );
        }

        public static Vector4 XXXY( this Vector4 v )
        {
            return new Vector4( v.x, v.x, v.x, v.y );
        }

        public static Vector4 XXXZ( this Vector4 v )
        {
            return new Vector4( v.x, v.x, v.x, v.z );
        }

        public static Vector4 XXXW( this Vector4 v )
        {
            return new Vector4( v.x, v.x, v.x, v.w );
        }

        public static Vector4 XXX_( this Vector4 v )
        {
            return new Vector4( v.x, v.x, v.x, 0f );
        }

        public static Vector4 XXYX( this Vector4 v )
        {
            return new Vector4( v.x, v.x, v.y, v.x );
        }

        public static Vector4 XXYY( this Vector4 v )
        {
            return new Vector4( v.x, v.x, v.y, v.y );
        }

        public static Vector4 XXYZ( this Vector4 v )
        {
            return new Vector4( v.x, v.x, v.y, v.z );
        }

        public static Vector4 XXYW( this Vector4 v )
        {
            return new Vector4( v.x, v.x, v.y, v.w );
        }

        public static Vector4 XXY_( this Vector4 v )
        {
            return new Vector4( v.x, v.x, v.y, 0f );
        }

        public static Vector4 XXZX( this Vector4 v )
        {
            return new Vector4( v.x, v.x, v.z, v.x );
        }

        public static Vector4 XXZY( this Vector4 v )
        {
            return new Vector4( v.x, v.x, v.z, v.y );
        }

        public static Vector4 XXZZ( this Vector4 v )
        {
            return new Vector4( v.x, v.x, v.z, v.z );
        }

        public static Vector4 XXZW( this Vector4 v )
        {
            return new Vector4( v.x, v.x, v.z, v.w );
        }

        public static Vector4 XXZ_( this Vector4 v )
        {
            return new Vector4( v.x, v.x, v.z, 0f );
        }

        public static Vector4 XXWX( this Vector4 v )
        {
            return new Vector4( v.x, v.x, v.w, v.x );
        }

        public static Vector4 XXWY( this Vector4 v )
        {
            return new Vector4( v.x, v.x, v.w, v.y );
        }

        public static Vector4 XXWZ( this Vector4 v )
        {
            return new Vector4( v.x, v.x, v.w, v.z );
        }

        public static Vector4 XXWW( this Vector4 v )
        {
            return new Vector4( v.x, v.x, v.w, v.w );
        }

        public static Vector4 XXW_( this Vector4 v )
        {
            return new Vector4( v.x, v.x, v.w, 0f );
        }

        public static Vector4 XX_X( this Vector4 v )
        {
            return new Vector4( v.x, v.x, 0f, v.x );
        }

        public static Vector4 XX_Y( this Vector4 v )
        {
            return new Vector4( v.x, v.x, 0f, v.y );
        }

        public static Vector4 XX_Z( this Vector4 v )
        {
            return new Vector4( v.x, v.x, 0f, v.z );
        }

        public static Vector4 XX_W( this Vector4 v )
        {
            return new Vector4( v.x, v.x, 0f, v.w );
        }

        public static Vector4 XX__( this Vector4 v )
        {
            return new Vector4( v.x, v.x, 0f, 0f );
        }

        public static Vector4 XYXX( this Vector4 v )
        {
            return new Vector4( v.x, v.y, v.x, v.x );
        }

        public static Vector4 XYXY( this Vector4 v )
        {
            return new Vector4( v.x, v.y, v.x, v.y );
        }

        public static Vector4 XYXZ( this Vector4 v )
        {
            return new Vector4( v.x, v.y, v.x, v.z );
        }

        public static Vector4 XYXW( this Vector4 v )
        {
            return new Vector4( v.x, v.y, v.x, v.w );
        }

        public static Vector4 XYX_( this Vector4 v )
        {
            return new Vector4( v.x, v.y, v.x, 0f );
        }

        public static Vector4 XYYX( this Vector4 v )
        {
            return new Vector4( v.x, v.y, v.y, v.x );
        }

        public static Vector4 XYYY( this Vector4 v )
        {
            return new Vector4( v.x, v.y, v.y, v.y );
        }

        public static Vector4 XYYZ( this Vector4 v )
        {
            return new Vector4( v.x, v.y, v.y, v.z );
        }

        public static Vector4 XYYW( this Vector4 v )
        {
            return new Vector4( v.x, v.y, v.y, v.w );
        }

        public static Vector4 XYY_( this Vector4 v )
        {
            return new Vector4( v.x, v.y, v.y, 0f );
        }

        public static Vector4 XYZX( this Vector4 v )
        {
            return new Vector4( v.x, v.y, v.z, v.x );
        }

        public static Vector4 XYZY( this Vector4 v )
        {
            return new Vector4( v.x, v.y, v.z, v.y );
        }

        public static Vector4 XYZZ( this Vector4 v )
        {
            return new Vector4( v.x, v.y, v.z, v.z );
        }

        public static Vector4 XYZW( this Vector4 v )
        {
            return new Vector4( v.x, v.y, v.z, v.w );
        }

        public static Vector4 XYZ_( this Vector4 v )
        {
            return new Vector4( v.x, v.y, v.z, 0f );
        }

        public static Vector4 XYWX( this Vector4 v )
        {
            return new Vector4( v.x, v.y, v.w, v.x );
        }

        public static Vector4 XYWY( this Vector4 v )
        {
            return new Vector4( v.x, v.y, v.w, v.y );
        }

        public static Vector4 XYWZ( this Vector4 v )
        {
            return new Vector4( v.x, v.y, v.w, v.z );
        }

        public static Vector4 XYWW( this Vector4 v )
        {
            return new Vector4( v.x, v.y, v.w, v.w );
        }

        public static Vector4 XYW_( this Vector4 v )
        {
            return new Vector4( v.x, v.y, v.w, 0f );
        }

        public static Vector4 XY_X( this Vector4 v )
        {
            return new Vector4( v.x, v.y, 0f, v.x );
        }

        public static Vector4 XY_Y( this Vector4 v )
        {
            return new Vector4( v.x, v.y, 0f, v.y );
        }

        public static Vector4 XY_Z( this Vector4 v )
        {
            return new Vector4( v.x, v.y, 0f, v.z );
        }

        public static Vector4 XY_W( this Vector4 v )
        {
            return new Vector4( v.x, v.y, 0f, v.w );
        }

        public static Vector4 XY__( this Vector4 v )
        {
            return new Vector4( v.x, v.y, 0f, 0f );
        }

        public static Vector4 XZXX( this Vector4 v )
        {
            return new Vector4( v.x, v.z, v.x, v.x );
        }

        public static Vector4 XZXY( this Vector4 v )
        {
            return new Vector4( v.x, v.z, v.x, v.y );
        }

        public static Vector4 XZXZ( this Vector4 v )
        {
            return new Vector4( v.x, v.z, v.x, v.z );
        }

        public static Vector4 XZXW( this Vector4 v )
        {
            return new Vector4( v.x, v.z, v.x, v.w );
        }

        public static Vector4 XZX_( this Vector4 v )
        {
            return new Vector4( v.x, v.z, v.x, 0f );
        }

        public static Vector4 XZYX( this Vector4 v )
        {
            return new Vector4( v.x, v.z, v.y, v.x );
        }

        public static Vector4 XZYY( this Vector4 v )
        {
            return new Vector4( v.x, v.z, v.y, v.y );
        }

        public static Vector4 XZYZ( this Vector4 v )
        {
            return new Vector4( v.x, v.z, v.y, v.z );
        }

        public static Vector4 XZYW( this Vector4 v )
        {
            return new Vector4( v.x, v.z, v.y, v.w );
        }

        public static Vector4 XZY_( this Vector4 v )
        {
            return new Vector4( v.x, v.z, v.y, 0f );
        }

        public static Vector4 XZZX( this Vector4 v )
        {
            return new Vector4( v.x, v.z, v.z, v.x );
        }

        public static Vector4 XZZY( this Vector4 v )
        {
            return new Vector4( v.x, v.z, v.z, v.y );
        }

        public static Vector4 XZZZ( this Vector4 v )
        {
            return new Vector4( v.x, v.z, v.z, v.z );
        }

        public static Vector4 XZZW( this Vector4 v )
        {
            return new Vector4( v.x, v.z, v.z, v.w );
        }

        public static Vector4 XZZ_( this Vector4 v )
        {
            return new Vector4( v.x, v.z, v.z, 0f );
        }

        public static Vector4 XZWX( this Vector4 v )
        {
            return new Vector4( v.x, v.z, v.w, v.x );
        }

        public static Vector4 XZWY( this Vector4 v )
        {
            return new Vector4( v.x, v.z, v.w, v.y );
        }

        public static Vector4 XZWZ( this Vector4 v )
        {
            return new Vector4( v.x, v.z, v.w, v.z );
        }

        public static Vector4 XZWW( this Vector4 v )
        {
            return new Vector4( v.x, v.z, v.w, v.w );
        }

        public static Vector4 XZW_( this Vector4 v )
        {
            return new Vector4( v.x, v.z, v.w, 0f );
        }

        public static Vector4 XZ_X( this Vector4 v )
        {
            return new Vector4( v.x, v.z, 0f, v.x );
        }

        public static Vector4 XZ_Y( this Vector4 v )
        {
            return new Vector4( v.x, v.z, 0f, v.y );
        }

        public static Vector4 XZ_Z( this Vector4 v )
        {
            return new Vector4( v.x, v.z, 0f, v.z );
        }

        public static Vector4 XZ_W( this Vector4 v )
        {
            return new Vector4( v.x, v.z, 0f, v.w );
        }

        public static Vector4 XZ__( this Vector4 v )
        {
            return new Vector4( v.x, v.z, 0f, 0f );
        }

        public static Vector4 XWXX( this Vector4 v )
        {
            return new Vector4( v.x, v.w, v.x, v.x );
        }

        public static Vector4 XWXY( this Vector4 v )
        {
            return new Vector4( v.x, v.w, v.x, v.y );
        }

        public static Vector4 XWXZ( this Vector4 v )
        {
            return new Vector4( v.x, v.w, v.x, v.z );
        }

        public static Vector4 XWXW( this Vector4 v )
        {
            return new Vector4( v.x, v.w, v.x, v.w );
        }

        public static Vector4 XWX_( this Vector4 v )
        {
            return new Vector4( v.x, v.w, v.x, 0f );
        }

        public static Vector4 XWYX( this Vector4 v )
        {
            return new Vector4( v.x, v.w, v.y, v.x );
        }

        public static Vector4 XWYY( this Vector4 v )
        {
            return new Vector4( v.x, v.w, v.y, v.y );
        }

        public static Vector4 XWYZ( this Vector4 v )
        {
            return new Vector4( v.x, v.w, v.y, v.z );
        }

        public static Vector4 XWYW( this Vector4 v )
        {
            return new Vector4( v.x, v.w, v.y, v.w );
        }

        public static Vector4 XWY_( this Vector4 v )
        {
            return new Vector4( v.x, v.w, v.y, 0f );
        }

        public static Vector4 XWZX( this Vector4 v )
        {
            return new Vector4( v.x, v.w, v.z, v.x );
        }

        public static Vector4 XWZY( this Vector4 v )
        {
            return new Vector4( v.x, v.w, v.z, v.y );
        }

        public static Vector4 XWZZ( this Vector4 v )
        {
            return new Vector4( v.x, v.w, v.z, v.z );
        }

        public static Vector4 XWZW( this Vector4 v )
        {
            return new Vector4( v.x, v.w, v.z, v.w );
        }

        public static Vector4 XWZ_( this Vector4 v )
        {
            return new Vector4( v.x, v.w, v.z, 0f );
        }

        public static Vector4 XWWX( this Vector4 v )
        {
            return new Vector4( v.x, v.w, v.w, v.x );
        }

        public static Vector4 XWWY( this Vector4 v )
        {
            return new Vector4( v.x, v.w, v.w, v.y );
        }

        public static Vector4 XWWZ( this Vector4 v )
        {
            return new Vector4( v.x, v.w, v.w, v.z );
        }

        public static Vector4 XWWW( this Vector4 v )
        {
            return new Vector4( v.x, v.w, v.w, v.w );
        }

        public static Vector4 XWW_( this Vector4 v )
        {
            return new Vector4( v.x, v.w, v.w, 0f );
        }

        public static Vector4 XW_X( this Vector4 v )
        {
            return new Vector4( v.x, v.w, 0f, v.x );
        }

        public static Vector4 XW_Y( this Vector4 v )
        {
            return new Vector4( v.x, v.w, 0f, v.y );
        }

        public static Vector4 XW_Z( this Vector4 v )
        {
            return new Vector4( v.x, v.w, 0f, v.z );
        }

        public static Vector4 XW_W( this Vector4 v )
        {
            return new Vector4( v.x, v.w, 0f, v.w );
        }

        public static Vector4 XW__( this Vector4 v )
        {
            return new Vector4( v.x, v.w, 0f, 0f );
        }

        public static Vector4 X_XX( this Vector4 v )
        {
            return new Vector4( v.x, 0f, v.x, v.x );
        }

        public static Vector4 X_XY( this Vector4 v )
        {
            return new Vector4( v.x, 0f, v.x, v.y );
        }

        public static Vector4 X_XZ( this Vector4 v )
        {
            return new Vector4( v.x, 0f, v.x, v.z );
        }

        public static Vector4 X_XW( this Vector4 v )
        {
            return new Vector4( v.x, 0f, v.x, v.w );
        }

        public static Vector4 X_X_( this Vector4 v )
        {
            return new Vector4( v.x, 0f, v.x, 0f );
        }

        public static Vector4 X_YX( this Vector4 v )
        {
            return new Vector4( v.x, 0f, v.y, v.x );
        }

        public static Vector4 X_YY( this Vector4 v )
        {
            return new Vector4( v.x, 0f, v.y, v.y );
        }

        public static Vector4 X_YZ( this Vector4 v )
        {
            return new Vector4( v.x, 0f, v.y, v.z );
        }

        public static Vector4 X_YW( this Vector4 v )
        {
            return new Vector4( v.x, 0f, v.y, v.w );
        }

        public static Vector4 X_Y_( this Vector4 v )
        {
            return new Vector4( v.x, 0f, v.y, 0f );
        }

        public static Vector4 X_ZX( this Vector4 v )
        {
            return new Vector4( v.x, 0f, v.z, v.x );
        }

        public static Vector4 X_ZY( this Vector4 v )
        {
            return new Vector4( v.x, 0f, v.z, v.y );
        }

        public static Vector4 X_ZZ( this Vector4 v )
        {
            return new Vector4( v.x, 0f, v.z, v.z );
        }

        public static Vector4 X_ZW( this Vector4 v )
        {
            return new Vector4( v.x, 0f, v.z, v.w );
        }

        public static Vector4 X_Z_( this Vector4 v )
        {
            return new Vector4( v.x, 0f, v.z, 0f );
        }

        public static Vector4 X_WX( this Vector4 v )
        {
            return new Vector4( v.x, 0f, v.w, v.x );
        }

        public static Vector4 X_WY( this Vector4 v )
        {
            return new Vector4( v.x, 0f, v.w, v.y );
        }

        public static Vector4 X_WZ( this Vector4 v )
        {
            return new Vector4( v.x, 0f, v.w, v.z );
        }

        public static Vector4 X_WW( this Vector4 v )
        {
            return new Vector4( v.x, 0f, v.w, v.w );
        }

        public static Vector4 X_W_( this Vector4 v )
        {
            return new Vector4( v.x, 0f, v.w, 0f );
        }

        public static Vector4 X__X( this Vector4 v )
        {
            return new Vector4( v.x, 0f, 0f, v.x );
        }

        public static Vector4 X__Y( this Vector4 v )
        {
            return new Vector4( v.x, 0f, 0f, v.y );
        }

        public static Vector4 X__Z( this Vector4 v )
        {
            return new Vector4( v.x, 0f, 0f, v.z );
        }

        public static Vector4 X__W( this Vector4 v )
        {
            return new Vector4( v.x, 0f, 0f, v.w );
        }

        public static Vector4 X___( this Vector4 v )
        {
            return new Vector4( v.x, 0f, 0f, 0f );
        }

        public static Vector4 YXXX( this Vector4 v )
        {
            return new Vector4( v.y, v.x, v.x, v.x );
        }

        public static Vector4 YXXY( this Vector4 v )
        {
            return new Vector4( v.y, v.x, v.x, v.y );
        }

        public static Vector4 YXXZ( this Vector4 v )
        {
            return new Vector4( v.y, v.x, v.x, v.z );
        }

        public static Vector4 YXXW( this Vector4 v )
        {
            return new Vector4( v.y, v.x, v.x, v.w );
        }

        public static Vector4 YXX_( this Vector4 v )
        {
            return new Vector4( v.y, v.x, v.x, 0f );
        }

        public static Vector4 YXYX( this Vector4 v )
        {
            return new Vector4( v.y, v.x, v.y, v.x );
        }

        public static Vector4 YXYY( this Vector4 v )
        {
            return new Vector4( v.y, v.x, v.y, v.y );
        }

        public static Vector4 YXYZ( this Vector4 v )
        {
            return new Vector4( v.y, v.x, v.y, v.z );
        }

        public static Vector4 YXYW( this Vector4 v )
        {
            return new Vector4( v.y, v.x, v.y, v.w );
        }

        public static Vector4 YXY_( this Vector4 v )
        {
            return new Vector4( v.y, v.x, v.y, 0f );
        }

        public static Vector4 YXZX( this Vector4 v )
        {
            return new Vector4( v.y, v.x, v.z, v.x );
        }

        public static Vector4 YXZY( this Vector4 v )
        {
            return new Vector4( v.y, v.x, v.z, v.y );
        }

        public static Vector4 YXZZ( this Vector4 v )
        {
            return new Vector4( v.y, v.x, v.z, v.z );
        }

        public static Vector4 YXZW( this Vector4 v )
        {
            return new Vector4( v.y, v.x, v.z, v.w );
        }

        public static Vector4 YXZ_( this Vector4 v )
        {
            return new Vector4( v.y, v.x, v.z, 0f );
        }

        public static Vector4 YXWX( this Vector4 v )
        {
            return new Vector4( v.y, v.x, v.w, v.x );
        }

        public static Vector4 YXWY( this Vector4 v )
        {
            return new Vector4( v.y, v.x, v.w, v.y );
        }

        public static Vector4 YXWZ( this Vector4 v )
        {
            return new Vector4( v.y, v.x, v.w, v.z );
        }

        public static Vector4 YXWW( this Vector4 v )
        {
            return new Vector4( v.y, v.x, v.w, v.w );
        }

        public static Vector4 YXW_( this Vector4 v )
        {
            return new Vector4( v.y, v.x, v.w, 0f );
        }

        public static Vector4 YX_X( this Vector4 v )
        {
            return new Vector4( v.y, v.x, 0f, v.x );
        }

        public static Vector4 YX_Y( this Vector4 v )
        {
            return new Vector4( v.y, v.x, 0f, v.y );
        }

        public static Vector4 YX_Z( this Vector4 v )
        {
            return new Vector4( v.y, v.x, 0f, v.z );
        }

        public static Vector4 YX_W( this Vector4 v )
        {
            return new Vector4( v.y, v.x, 0f, v.w );
        }

        public static Vector4 YX__( this Vector4 v )
        {
            return new Vector4( v.y, v.x, 0f, 0f );
        }

        public static Vector4 YYXX( this Vector4 v )
        {
            return new Vector4( v.y, v.y, v.x, v.x );
        }

        public static Vector4 YYXY( this Vector4 v )
        {
            return new Vector4( v.y, v.y, v.x, v.y );
        }

        public static Vector4 YYXZ( this Vector4 v )
        {
            return new Vector4( v.y, v.y, v.x, v.z );
        }

        public static Vector4 YYXW( this Vector4 v )
        {
            return new Vector4( v.y, v.y, v.x, v.w );
        }

        public static Vector4 YYX_( this Vector4 v )
        {
            return new Vector4( v.y, v.y, v.x, 0f );
        }

        public static Vector4 YYYX( this Vector4 v )
        {
            return new Vector4( v.y, v.y, v.y, v.x );
        }

        public static Vector4 YYYY( this Vector4 v )
        {
            return new Vector4( v.y, v.y, v.y, v.y );
        }

        public static Vector4 YYYZ( this Vector4 v )
        {
            return new Vector4( v.y, v.y, v.y, v.z );
        }

        public static Vector4 YYYW( this Vector4 v )
        {
            return new Vector4( v.y, v.y, v.y, v.w );
        }

        public static Vector4 YYY_( this Vector4 v )
        {
            return new Vector4( v.y, v.y, v.y, 0f );
        }

        public static Vector4 YYZX( this Vector4 v )
        {
            return new Vector4( v.y, v.y, v.z, v.x );
        }

        public static Vector4 YYZY( this Vector4 v )
        {
            return new Vector4( v.y, v.y, v.z, v.y );
        }

        public static Vector4 YYZZ( this Vector4 v )
        {
            return new Vector4( v.y, v.y, v.z, v.z );
        }

        public static Vector4 YYZW( this Vector4 v )
        {
            return new Vector4( v.y, v.y, v.z, v.w );
        }

        public static Vector4 YYZ_( this Vector4 v )
        {
            return new Vector4( v.y, v.y, v.z, 0f );
        }

        public static Vector4 YYWX( this Vector4 v )
        {
            return new Vector4( v.y, v.y, v.w, v.x );
        }

        public static Vector4 YYWY( this Vector4 v )
        {
            return new Vector4( v.y, v.y, v.w, v.y );
        }

        public static Vector4 YYWZ( this Vector4 v )
        {
            return new Vector4( v.y, v.y, v.w, v.z );
        }

        public static Vector4 YYWW( this Vector4 v )
        {
            return new Vector4( v.y, v.y, v.w, v.w );
        }

        public static Vector4 YYW_( this Vector4 v )
        {
            return new Vector4( v.y, v.y, v.w, 0f );
        }

        public static Vector4 YY_X( this Vector4 v )
        {
            return new Vector4( v.y, v.y, 0f, v.x );
        }

        public static Vector4 YY_Y( this Vector4 v )
        {
            return new Vector4( v.y, v.y, 0f, v.y );
        }

        public static Vector4 YY_Z( this Vector4 v )
        {
            return new Vector4( v.y, v.y, 0f, v.z );
        }

        public static Vector4 YY_W( this Vector4 v )
        {
            return new Vector4( v.y, v.y, 0f, v.w );
        }

        public static Vector4 YY__( this Vector4 v )
        {
            return new Vector4( v.y, v.y, 0f, 0f );
        }

        public static Vector4 YZXX( this Vector4 v )
        {
            return new Vector4( v.y, v.z, v.x, v.x );
        }

        public static Vector4 YZXY( this Vector4 v )
        {
            return new Vector4( v.y, v.z, v.x, v.y );
        }

        public static Vector4 YZXZ( this Vector4 v )
        {
            return new Vector4( v.y, v.z, v.x, v.z );
        }

        public static Vector4 YZXW( this Vector4 v )
        {
            return new Vector4( v.y, v.z, v.x, v.w );
        }

        public static Vector4 YZX_( this Vector4 v )
        {
            return new Vector4( v.y, v.z, v.x, 0f );
        }

        public static Vector4 YZYX( this Vector4 v )
        {
            return new Vector4( v.y, v.z, v.y, v.x );
        }

        public static Vector4 YZYY( this Vector4 v )
        {
            return new Vector4( v.y, v.z, v.y, v.y );
        }

        public static Vector4 YZYZ( this Vector4 v )
        {
            return new Vector4( v.y, v.z, v.y, v.z );
        }

        public static Vector4 YZYW( this Vector4 v )
        {
            return new Vector4( v.y, v.z, v.y, v.w );
        }

        public static Vector4 YZY_( this Vector4 v )
        {
            return new Vector4( v.y, v.z, v.y, 0f );
        }

        public static Vector4 YZZX( this Vector4 v )
        {
            return new Vector4( v.y, v.z, v.z, v.x );
        }

        public static Vector4 YZZY( this Vector4 v )
        {
            return new Vector4( v.y, v.z, v.z, v.y );
        }

        public static Vector4 YZZZ( this Vector4 v )
        {
            return new Vector4( v.y, v.z, v.z, v.z );
        }

        public static Vector4 YZZW( this Vector4 v )
        {
            return new Vector4( v.y, v.z, v.z, v.w );
        }

        public static Vector4 YZZ_( this Vector4 v )
        {
            return new Vector4( v.y, v.z, v.z, 0f );
        }

        public static Vector4 YZWX( this Vector4 v )
        {
            return new Vector4( v.y, v.z, v.w, v.x );
        }

        public static Vector4 YZWY( this Vector4 v )
        {
            return new Vector4( v.y, v.z, v.w, v.y );
        }

        public static Vector4 YZWZ( this Vector4 v )
        {
            return new Vector4( v.y, v.z, v.w, v.z );
        }

        public static Vector4 YZWW( this Vector4 v )
        {
            return new Vector4( v.y, v.z, v.w, v.w );
        }

        public static Vector4 YZW_( this Vector4 v )
        {
            return new Vector4( v.y, v.z, v.w, 0f );
        }

        public static Vector4 YZ_X( this Vector4 v )
        {
            return new Vector4( v.y, v.z, 0f, v.x );
        }

        public static Vector4 YZ_Y( this Vector4 v )
        {
            return new Vector4( v.y, v.z, 0f, v.y );
        }

        public static Vector4 YZ_Z( this Vector4 v )
        {
            return new Vector4( v.y, v.z, 0f, v.z );
        }

        public static Vector4 YZ_W( this Vector4 v )
        {
            return new Vector4( v.y, v.z, 0f, v.w );
        }

        public static Vector4 YZ__( this Vector4 v )
        {
            return new Vector4( v.y, v.z, 0f, 0f );
        }

        public static Vector4 YWXX( this Vector4 v )
        {
            return new Vector4( v.y, v.w, v.x, v.x );
        }

        public static Vector4 YWXY( this Vector4 v )
        {
            return new Vector4( v.y, v.w, v.x, v.y );
        }

        public static Vector4 YWXZ( this Vector4 v )
        {
            return new Vector4( v.y, v.w, v.x, v.z );
        }

        public static Vector4 YWXW( this Vector4 v )
        {
            return new Vector4( v.y, v.w, v.x, v.w );
        }

        public static Vector4 YWX_( this Vector4 v )
        {
            return new Vector4( v.y, v.w, v.x, 0f );
        }

        public static Vector4 YWYX( this Vector4 v )
        {
            return new Vector4( v.y, v.w, v.y, v.x );
        }

        public static Vector4 YWYY( this Vector4 v )
        {
            return new Vector4( v.y, v.w, v.y, v.y );
        }

        public static Vector4 YWYZ( this Vector4 v )
        {
            return new Vector4( v.y, v.w, v.y, v.z );
        }

        public static Vector4 YWYW( this Vector4 v )
        {
            return new Vector4( v.y, v.w, v.y, v.w );
        }

        public static Vector4 YWY_( this Vector4 v )
        {
            return new Vector4( v.y, v.w, v.y, 0f );
        }

        public static Vector4 YWZX( this Vector4 v )
        {
            return new Vector4( v.y, v.w, v.z, v.x );
        }

        public static Vector4 YWZY( this Vector4 v )
        {
            return new Vector4( v.y, v.w, v.z, v.y );
        }

        public static Vector4 YWZZ( this Vector4 v )
        {
            return new Vector4( v.y, v.w, v.z, v.z );
        }

        public static Vector4 YWZW( this Vector4 v )
        {
            return new Vector4( v.y, v.w, v.z, v.w );
        }

        public static Vector4 YWZ_( this Vector4 v )
        {
            return new Vector4( v.y, v.w, v.z, 0f );
        }

        public static Vector4 YWWX( this Vector4 v )
        {
            return new Vector4( v.y, v.w, v.w, v.x );
        }

        public static Vector4 YWWY( this Vector4 v )
        {
            return new Vector4( v.y, v.w, v.w, v.y );
        }

        public static Vector4 YWWZ( this Vector4 v )
        {
            return new Vector4( v.y, v.w, v.w, v.z );
        }

        public static Vector4 YWWW( this Vector4 v )
        {
            return new Vector4( v.y, v.w, v.w, v.w );
        }

        public static Vector4 YWW_( this Vector4 v )
        {
            return new Vector4( v.y, v.w, v.w, 0f );
        }

        public static Vector4 YW_X( this Vector4 v )
        {
            return new Vector4( v.y, v.w, 0f, v.x );
        }

        public static Vector4 YW_Y( this Vector4 v )
        {
            return new Vector4( v.y, v.w, 0f, v.y );
        }

        public static Vector4 YW_Z( this Vector4 v )
        {
            return new Vector4( v.y, v.w, 0f, v.z );
        }

        public static Vector4 YW_W( this Vector4 v )
        {
            return new Vector4( v.y, v.w, 0f, v.w );
        }

        public static Vector4 YW__( this Vector4 v )
        {
            return new Vector4( v.y, v.w, 0f, 0f );
        }

        public static Vector4 Y_XX( this Vector4 v )
        {
            return new Vector4( v.y, 0f, v.x, v.x );
        }

        public static Vector4 Y_XY( this Vector4 v )
        {
            return new Vector4( v.y, 0f, v.x, v.y );
        }

        public static Vector4 Y_XZ( this Vector4 v )
        {
            return new Vector4( v.y, 0f, v.x, v.z );
        }

        public static Vector4 Y_XW( this Vector4 v )
        {
            return new Vector4( v.y, 0f, v.x, v.w );
        }

        public static Vector4 Y_X_( this Vector4 v )
        {
            return new Vector4( v.y, 0f, v.x, 0f );
        }

        public static Vector4 Y_YX( this Vector4 v )
        {
            return new Vector4( v.y, 0f, v.y, v.x );
        }

        public static Vector4 Y_YY( this Vector4 v )
        {
            return new Vector4( v.y, 0f, v.y, v.y );
        }

        public static Vector4 Y_YZ( this Vector4 v )
        {
            return new Vector4( v.y, 0f, v.y, v.z );
        }

        public static Vector4 Y_YW( this Vector4 v )
        {
            return new Vector4( v.y, 0f, v.y, v.w );
        }

        public static Vector4 Y_Y_( this Vector4 v )
        {
            return new Vector4( v.y, 0f, v.y, 0f );
        }

        public static Vector4 Y_ZX( this Vector4 v )
        {
            return new Vector4( v.y, 0f, v.z, v.x );
        }

        public static Vector4 Y_ZY( this Vector4 v )
        {
            return new Vector4( v.y, 0f, v.z, v.y );
        }

        public static Vector4 Y_ZZ( this Vector4 v )
        {
            return new Vector4( v.y, 0f, v.z, v.z );
        }

        public static Vector4 Y_ZW( this Vector4 v )
        {
            return new Vector4( v.y, 0f, v.z, v.w );
        }

        public static Vector4 Y_Z_( this Vector4 v )
        {
            return new Vector4( v.y, 0f, v.z, 0f );
        }

        public static Vector4 Y_WX( this Vector4 v )
        {
            return new Vector4( v.y, 0f, v.w, v.x );
        }

        public static Vector4 Y_WY( this Vector4 v )
        {
            return new Vector4( v.y, 0f, v.w, v.y );
        }

        public static Vector4 Y_WZ( this Vector4 v )
        {
            return new Vector4( v.y, 0f, v.w, v.z );
        }

        public static Vector4 Y_WW( this Vector4 v )
        {
            return new Vector4( v.y, 0f, v.w, v.w );
        }

        public static Vector4 Y_W_( this Vector4 v )
        {
            return new Vector4( v.y, 0f, v.w, 0f );
        }

        public static Vector4 Y__X( this Vector4 v )
        {
            return new Vector4( v.y, 0f, 0f, v.x );
        }

        public static Vector4 Y__Y( this Vector4 v )
        {
            return new Vector4( v.y, 0f, 0f, v.y );
        }

        public static Vector4 Y__Z( this Vector4 v )
        {
            return new Vector4( v.y, 0f, 0f, v.z );
        }

        public static Vector4 Y__W( this Vector4 v )
        {
            return new Vector4( v.y, 0f, 0f, v.w );
        }

        public static Vector4 Y___( this Vector4 v )
        {
            return new Vector4( v.y, 0f, 0f, 0f );
        }

        public static Vector4 ZXXX( this Vector4 v )
        {
            return new Vector4( v.z, v.x, v.x, v.x );
        }

        public static Vector4 ZXXY( this Vector4 v )
        {
            return new Vector4( v.z, v.x, v.x, v.y );
        }

        public static Vector4 ZXXZ( this Vector4 v )
        {
            return new Vector4( v.z, v.x, v.x, v.z );
        }

        public static Vector4 ZXXW( this Vector4 v )
        {
            return new Vector4( v.z, v.x, v.x, v.w );
        }

        public static Vector4 ZXX_( this Vector4 v )
        {
            return new Vector4( v.z, v.x, v.x, 0f );
        }

        public static Vector4 ZXYX( this Vector4 v )
        {
            return new Vector4( v.z, v.x, v.y, v.x );
        }

        public static Vector4 ZXYY( this Vector4 v )
        {
            return new Vector4( v.z, v.x, v.y, v.y );
        }

        public static Vector4 ZXYZ( this Vector4 v )
        {
            return new Vector4( v.z, v.x, v.y, v.z );
        }

        public static Vector4 ZXYW( this Vector4 v )
        {
            return new Vector4( v.z, v.x, v.y, v.w );
        }

        public static Vector4 ZXY_( this Vector4 v )
        {
            return new Vector4( v.z, v.x, v.y, 0f );
        }

        public static Vector4 ZXZX( this Vector4 v )
        {
            return new Vector4( v.z, v.x, v.z, v.x );
        }

        public static Vector4 ZXZY( this Vector4 v )
        {
            return new Vector4( v.z, v.x, v.z, v.y );
        }

        public static Vector4 ZXZZ( this Vector4 v )
        {
            return new Vector4( v.z, v.x, v.z, v.z );
        }

        public static Vector4 ZXZW( this Vector4 v )
        {
            return new Vector4( v.z, v.x, v.z, v.w );
        }

        public static Vector4 ZXZ_( this Vector4 v )
        {
            return new Vector4( v.z, v.x, v.z, 0f );
        }

        public static Vector4 ZXWX( this Vector4 v )
        {
            return new Vector4( v.z, v.x, v.w, v.x );
        }

        public static Vector4 ZXWY( this Vector4 v )
        {
            return new Vector4( v.z, v.x, v.w, v.y );
        }

        public static Vector4 ZXWZ( this Vector4 v )
        {
            return new Vector4( v.z, v.x, v.w, v.z );
        }

        public static Vector4 ZXWW( this Vector4 v )
        {
            return new Vector4( v.z, v.x, v.w, v.w );
        }

        public static Vector4 ZXW_( this Vector4 v )
        {
            return new Vector4( v.z, v.x, v.w, 0f );
        }

        public static Vector4 ZX_X( this Vector4 v )
        {
            return new Vector4( v.z, v.x, 0f, v.x );
        }

        public static Vector4 ZX_Y( this Vector4 v )
        {
            return new Vector4( v.z, v.x, 0f, v.y );
        }

        public static Vector4 ZX_Z( this Vector4 v )
        {
            return new Vector4( v.z, v.x, 0f, v.z );
        }

        public static Vector4 ZX_W( this Vector4 v )
        {
            return new Vector4( v.z, v.x, 0f, v.w );
        }

        public static Vector4 ZX__( this Vector4 v )
        {
            return new Vector4( v.z, v.x, 0f, 0f );
        }

        public static Vector4 ZYXX( this Vector4 v )
        {
            return new Vector4( v.z, v.y, v.x, v.x );
        }

        public static Vector4 ZYXY( this Vector4 v )
        {
            return new Vector4( v.z, v.y, v.x, v.y );
        }

        public static Vector4 ZYXZ( this Vector4 v )
        {
            return new Vector4( v.z, v.y, v.x, v.z );
        }

        public static Vector4 ZYXW( this Vector4 v )
        {
            return new Vector4( v.z, v.y, v.x, v.w );
        }

        public static Vector4 ZYX_( this Vector4 v )
        {
            return new Vector4( v.z, v.y, v.x, 0f );
        }

        public static Vector4 ZYYX( this Vector4 v )
        {
            return new Vector4( v.z, v.y, v.y, v.x );
        }

        public static Vector4 ZYYY( this Vector4 v )
        {
            return new Vector4( v.z, v.y, v.y, v.y );
        }

        public static Vector4 ZYYZ( this Vector4 v )
        {
            return new Vector4( v.z, v.y, v.y, v.z );
        }

        public static Vector4 ZYYW( this Vector4 v )
        {
            return new Vector4( v.z, v.y, v.y, v.w );
        }

        public static Vector4 ZYY_( this Vector4 v )
        {
            return new Vector4( v.z, v.y, v.y, 0f );
        }

        public static Vector4 ZYZX( this Vector4 v )
        {
            return new Vector4( v.z, v.y, v.z, v.x );
        }

        public static Vector4 ZYZY( this Vector4 v )
        {
            return new Vector4( v.z, v.y, v.z, v.y );
        }

        public static Vector4 ZYZZ( this Vector4 v )
        {
            return new Vector4( v.z, v.y, v.z, v.z );
        }

        public static Vector4 ZYZW( this Vector4 v )
        {
            return new Vector4( v.z, v.y, v.z, v.w );
        }

        public static Vector4 ZYZ_( this Vector4 v )
        {
            return new Vector4( v.z, v.y, v.z, 0f );
        }

        public static Vector4 ZYWX( this Vector4 v )
        {
            return new Vector4( v.z, v.y, v.w, v.x );
        }

        public static Vector4 ZYWY( this Vector4 v )
        {
            return new Vector4( v.z, v.y, v.w, v.y );
        }

        public static Vector4 ZYWZ( this Vector4 v )
        {
            return new Vector4( v.z, v.y, v.w, v.z );
        }

        public static Vector4 ZYWW( this Vector4 v )
        {
            return new Vector4( v.z, v.y, v.w, v.w );
        }

        public static Vector4 ZYW_( this Vector4 v )
        {
            return new Vector4( v.z, v.y, v.w, 0f );
        }

        public static Vector4 ZY_X( this Vector4 v )
        {
            return new Vector4( v.z, v.y, 0f, v.x );
        }

        public static Vector4 ZY_Y( this Vector4 v )
        {
            return new Vector4( v.z, v.y, 0f, v.y );
        }

        public static Vector4 ZY_Z( this Vector4 v )
        {
            return new Vector4( v.z, v.y, 0f, v.z );
        }

        public static Vector4 ZY_W( this Vector4 v )
        {
            return new Vector4( v.z, v.y, 0f, v.w );
        }

        public static Vector4 ZY__( this Vector4 v )
        {
            return new Vector4( v.z, v.y, 0f, 0f );
        }

        public static Vector4 ZZXX( this Vector4 v )
        {
            return new Vector4( v.z, v.z, v.x, v.x );
        }

        public static Vector4 ZZXY( this Vector4 v )
        {
            return new Vector4( v.z, v.z, v.x, v.y );
        }

        public static Vector4 ZZXZ( this Vector4 v )
        {
            return new Vector4( v.z, v.z, v.x, v.z );
        }

        public static Vector4 ZZXW( this Vector4 v )
        {
            return new Vector4( v.z, v.z, v.x, v.w );
        }

        public static Vector4 ZZX_( this Vector4 v )
        {
            return new Vector4( v.z, v.z, v.x, 0f );
        }

        public static Vector4 ZZYX( this Vector4 v )
        {
            return new Vector4( v.z, v.z, v.y, v.x );
        }

        public static Vector4 ZZYY( this Vector4 v )
        {
            return new Vector4( v.z, v.z, v.y, v.y );
        }

        public static Vector4 ZZYZ( this Vector4 v )
        {
            return new Vector4( v.z, v.z, v.y, v.z );
        }

        public static Vector4 ZZYW( this Vector4 v )
        {
            return new Vector4( v.z, v.z, v.y, v.w );
        }

        public static Vector4 ZZY_( this Vector4 v )
        {
            return new Vector4( v.z, v.z, v.y, 0f );
        }

        public static Vector4 ZZZX( this Vector4 v )
        {
            return new Vector4( v.z, v.z, v.z, v.x );
        }

        public static Vector4 ZZZY( this Vector4 v )
        {
            return new Vector4( v.z, v.z, v.z, v.y );
        }

        public static Vector4 ZZZZ( this Vector4 v )
        {
            return new Vector4( v.z, v.z, v.z, v.z );
        }

        public static Vector4 ZZZW( this Vector4 v )
        {
            return new Vector4( v.z, v.z, v.z, v.w );
        }

        public static Vector4 ZZZ_( this Vector4 v )
        {
            return new Vector4( v.z, v.z, v.z, 0f );
        }

        public static Vector4 ZZWX( this Vector4 v )
        {
            return new Vector4( v.z, v.z, v.w, v.x );
        }

        public static Vector4 ZZWY( this Vector4 v )
        {
            return new Vector4( v.z, v.z, v.w, v.y );
        }

        public static Vector4 ZZWZ( this Vector4 v )
        {
            return new Vector4( v.z, v.z, v.w, v.z );
        }

        public static Vector4 ZZWW( this Vector4 v )
        {
            return new Vector4( v.z, v.z, v.w, v.w );
        }

        public static Vector4 ZZW_( this Vector4 v )
        {
            return new Vector4( v.z, v.z, v.w, 0f );
        }

        public static Vector4 ZZ_X( this Vector4 v )
        {
            return new Vector4( v.z, v.z, 0f, v.x );
        }

        public static Vector4 ZZ_Y( this Vector4 v )
        {
            return new Vector4( v.z, v.z, 0f, v.y );
        }

        public static Vector4 ZZ_Z( this Vector4 v )
        {
            return new Vector4( v.z, v.z, 0f, v.z );
        }

        public static Vector4 ZZ_W( this Vector4 v )
        {
            return new Vector4( v.z, v.z, 0f, v.w );
        }

        public static Vector4 ZZ__( this Vector4 v )
        {
            return new Vector4( v.z, v.z, 0f, 0f );
        }

        public static Vector4 ZWXX( this Vector4 v )
        {
            return new Vector4( v.z, v.w, v.x, v.x );
        }

        public static Vector4 ZWXY( this Vector4 v )
        {
            return new Vector4( v.z, v.w, v.x, v.y );
        }

        public static Vector4 ZWXZ( this Vector4 v )
        {
            return new Vector4( v.z, v.w, v.x, v.z );
        }

        public static Vector4 ZWXW( this Vector4 v )
        {
            return new Vector4( v.z, v.w, v.x, v.w );
        }

        public static Vector4 ZWX_( this Vector4 v )
        {
            return new Vector4( v.z, v.w, v.x, 0f );
        }

        public static Vector4 ZWYX( this Vector4 v )
        {
            return new Vector4( v.z, v.w, v.y, v.x );
        }

        public static Vector4 ZWYY( this Vector4 v )
        {
            return new Vector4( v.z, v.w, v.y, v.y );
        }

        public static Vector4 ZWYZ( this Vector4 v )
        {
            return new Vector4( v.z, v.w, v.y, v.z );
        }

        public static Vector4 ZWYW( this Vector4 v )
        {
            return new Vector4( v.z, v.w, v.y, v.w );
        }

        public static Vector4 ZWY_( this Vector4 v )
        {
            return new Vector4( v.z, v.w, v.y, 0f );
        }

        public static Vector4 ZWZX( this Vector4 v )
        {
            return new Vector4( v.z, v.w, v.z, v.x );
        }

        public static Vector4 ZWZY( this Vector4 v )
        {
            return new Vector4( v.z, v.w, v.z, v.y );
        }

        public static Vector4 ZWZZ( this Vector4 v )
        {
            return new Vector4( v.z, v.w, v.z, v.z );
        }

        public static Vector4 ZWZW( this Vector4 v )
        {
            return new Vector4( v.z, v.w, v.z, v.w );
        }

        public static Vector4 ZWZ_( this Vector4 v )
        {
            return new Vector4( v.z, v.w, v.z, 0f );
        }

        public static Vector4 ZWWX( this Vector4 v )
        {
            return new Vector4( v.z, v.w, v.w, v.x );
        }

        public static Vector4 ZWWY( this Vector4 v )
        {
            return new Vector4( v.z, v.w, v.w, v.y );
        }

        public static Vector4 ZWWZ( this Vector4 v )
        {
            return new Vector4( v.z, v.w, v.w, v.z );
        }

        public static Vector4 ZWWW( this Vector4 v )
        {
            return new Vector4( v.z, v.w, v.w, v.w );
        }

        public static Vector4 ZWW_( this Vector4 v )
        {
            return new Vector4( v.z, v.w, v.w, 0f );
        }

        public static Vector4 ZW_X( this Vector4 v )
        {
            return new Vector4( v.z, v.w, 0f, v.x );
        }

        public static Vector4 ZW_Y( this Vector4 v )
        {
            return new Vector4( v.z, v.w, 0f, v.y );
        }

        public static Vector4 ZW_Z( this Vector4 v )
        {
            return new Vector4( v.z, v.w, 0f, v.z );
        }

        public static Vector4 ZW_W( this Vector4 v )
        {
            return new Vector4( v.z, v.w, 0f, v.w );
        }

        public static Vector4 ZW__( this Vector4 v )
        {
            return new Vector4( v.z, v.w, 0f, 0f );
        }

        public static Vector4 Z_XX( this Vector4 v )
        {
            return new Vector4( v.z, 0f, v.x, v.x );
        }

        public static Vector4 Z_XY( this Vector4 v )
        {
            return new Vector4( v.z, 0f, v.x, v.y );
        }

        public static Vector4 Z_XZ( this Vector4 v )
        {
            return new Vector4( v.z, 0f, v.x, v.z );
        }

        public static Vector4 Z_XW( this Vector4 v )
        {
            return new Vector4( v.z, 0f, v.x, v.w );
        }

        public static Vector4 Z_X_( this Vector4 v )
        {
            return new Vector4( v.z, 0f, v.x, 0f );
        }

        public static Vector4 Z_YX( this Vector4 v )
        {
            return new Vector4( v.z, 0f, v.y, v.x );
        }

        public static Vector4 Z_YY( this Vector4 v )
        {
            return new Vector4( v.z, 0f, v.y, v.y );
        }

        public static Vector4 Z_YZ( this Vector4 v )
        {
            return new Vector4( v.z, 0f, v.y, v.z );
        }

        public static Vector4 Z_YW( this Vector4 v )
        {
            return new Vector4( v.z, 0f, v.y, v.w );
        }

        public static Vector4 Z_Y_( this Vector4 v )
        {
            return new Vector4( v.z, 0f, v.y, 0f );
        }

        public static Vector4 Z_ZX( this Vector4 v )
        {
            return new Vector4( v.z, 0f, v.z, v.x );
        }

        public static Vector4 Z_ZY( this Vector4 v )
        {
            return new Vector4( v.z, 0f, v.z, v.y );
        }

        public static Vector4 Z_ZZ( this Vector4 v )
        {
            return new Vector4( v.z, 0f, v.z, v.z );
        }

        public static Vector4 Z_ZW( this Vector4 v )
        {
            return new Vector4( v.z, 0f, v.z, v.w );
        }

        public static Vector4 Z_Z_( this Vector4 v )
        {
            return new Vector4( v.z, 0f, v.z, 0f );
        }

        public static Vector4 Z_WX( this Vector4 v )
        {
            return new Vector4( v.z, 0f, v.w, v.x );
        }

        public static Vector4 Z_WY( this Vector4 v )
        {
            return new Vector4( v.z, 0f, v.w, v.y );
        }

        public static Vector4 Z_WZ( this Vector4 v )
        {
            return new Vector4( v.z, 0f, v.w, v.z );
        }

        public static Vector4 Z_WW( this Vector4 v )
        {
            return new Vector4( v.z, 0f, v.w, v.w );
        }

        public static Vector4 Z_W_( this Vector4 v )
        {
            return new Vector4( v.z, 0f, v.w, 0f );
        }

        public static Vector4 Z__X( this Vector4 v )
        {
            return new Vector4( v.z, 0f, 0f, v.x );
        }

        public static Vector4 Z__Y( this Vector4 v )
        {
            return new Vector4( v.z, 0f, 0f, v.y );
        }

        public static Vector4 Z__Z( this Vector4 v )
        {
            return new Vector4( v.z, 0f, 0f, v.z );
        }

        public static Vector4 Z__W( this Vector4 v )
        {
            return new Vector4( v.z, 0f, 0f, v.w );
        }

        public static Vector4 Z___( this Vector4 v )
        {
            return new Vector4( v.z, 0f, 0f, 0f );
        }

        public static Vector4 WXXX( this Vector4 v )
        {
            return new Vector4( v.w, v.x, v.x, v.x );
        }

        public static Vector4 WXXY( this Vector4 v )
        {
            return new Vector4( v.w, v.x, v.x, v.y );
        }

        public static Vector4 WXXZ( this Vector4 v )
        {
            return new Vector4( v.w, v.x, v.x, v.z );
        }

        public static Vector4 WXXW( this Vector4 v )
        {
            return new Vector4( v.w, v.x, v.x, v.w );
        }

        public static Vector4 WXX_( this Vector4 v )
        {
            return new Vector4( v.w, v.x, v.x, 0f );
        }

        public static Vector4 WXYX( this Vector4 v )
        {
            return new Vector4( v.w, v.x, v.y, v.x );
        }

        public static Vector4 WXYY( this Vector4 v )
        {
            return new Vector4( v.w, v.x, v.y, v.y );
        }

        public static Vector4 WXYZ( this Vector4 v )
        {
            return new Vector4( v.w, v.x, v.y, v.z );
        }

        public static Vector4 WXYW( this Vector4 v )
        {
            return new Vector4( v.w, v.x, v.y, v.w );
        }

        public static Vector4 WXY_( this Vector4 v )
        {
            return new Vector4( v.w, v.x, v.y, 0f );
        }

        public static Vector4 WXZX( this Vector4 v )
        {
            return new Vector4( v.w, v.x, v.z, v.x );
        }

        public static Vector4 WXZY( this Vector4 v )
        {
            return new Vector4( v.w, v.x, v.z, v.y );
        }

        public static Vector4 WXZZ( this Vector4 v )
        {
            return new Vector4( v.w, v.x, v.z, v.z );
        }

        public static Vector4 WXZW( this Vector4 v )
        {
            return new Vector4( v.w, v.x, v.z, v.w );
        }

        public static Vector4 WXZ_( this Vector4 v )
        {
            return new Vector4( v.w, v.x, v.z, 0f );
        }

        public static Vector4 WXWX( this Vector4 v )
        {
            return new Vector4( v.w, v.x, v.w, v.x );
        }

        public static Vector4 WXWY( this Vector4 v )
        {
            return new Vector4( v.w, v.x, v.w, v.y );
        }

        public static Vector4 WXWZ( this Vector4 v )
        {
            return new Vector4( v.w, v.x, v.w, v.z );
        }

        public static Vector4 WXWW( this Vector4 v )
        {
            return new Vector4( v.w, v.x, v.w, v.w );
        }

        public static Vector4 WXW_( this Vector4 v )
        {
            return new Vector4( v.w, v.x, v.w, 0f );
        }

        public static Vector4 WX_X( this Vector4 v )
        {
            return new Vector4( v.w, v.x, 0f, v.x );
        }

        public static Vector4 WX_Y( this Vector4 v )
        {
            return new Vector4( v.w, v.x, 0f, v.y );
        }

        public static Vector4 WX_Z( this Vector4 v )
        {
            return new Vector4( v.w, v.x, 0f, v.z );
        }

        public static Vector4 WX_W( this Vector4 v )
        {
            return new Vector4( v.w, v.x, 0f, v.w );
        }

        public static Vector4 WX__( this Vector4 v )
        {
            return new Vector4( v.w, v.x, 0f, 0f );
        }

        public static Vector4 WYXX( this Vector4 v )
        {
            return new Vector4( v.w, v.y, v.x, v.x );
        }

        public static Vector4 WYXY( this Vector4 v )
        {
            return new Vector4( v.w, v.y, v.x, v.y );
        }

        public static Vector4 WYXZ( this Vector4 v )
        {
            return new Vector4( v.w, v.y, v.x, v.z );
        }

        public static Vector4 WYXW( this Vector4 v )
        {
            return new Vector4( v.w, v.y, v.x, v.w );
        }

        public static Vector4 WYX_( this Vector4 v )
        {
            return new Vector4( v.w, v.y, v.x, 0f );
        }

        public static Vector4 WYYX( this Vector4 v )
        {
            return new Vector4( v.w, v.y, v.y, v.x );
        }

        public static Vector4 WYYY( this Vector4 v )
        {
            return new Vector4( v.w, v.y, v.y, v.y );
        }

        public static Vector4 WYYZ( this Vector4 v )
        {
            return new Vector4( v.w, v.y, v.y, v.z );
        }

        public static Vector4 WYYW( this Vector4 v )
        {
            return new Vector4( v.w, v.y, v.y, v.w );
        }

        public static Vector4 WYY_( this Vector4 v )
        {
            return new Vector4( v.w, v.y, v.y, 0f );
        }

        public static Vector4 WYZX( this Vector4 v )
        {
            return new Vector4( v.w, v.y, v.z, v.x );
        }

        public static Vector4 WYZY( this Vector4 v )
        {
            return new Vector4( v.w, v.y, v.z, v.y );
        }

        public static Vector4 WYZZ( this Vector4 v )
        {
            return new Vector4( v.w, v.y, v.z, v.z );
        }

        public static Vector4 WYZW( this Vector4 v )
        {
            return new Vector4( v.w, v.y, v.z, v.w );
        }

        public static Vector4 WYZ_( this Vector4 v )
        {
            return new Vector4( v.w, v.y, v.z, 0f );
        }

        public static Vector4 WYWX( this Vector4 v )
        {
            return new Vector4( v.w, v.y, v.w, v.x );
        }

        public static Vector4 WYWY( this Vector4 v )
        {
            return new Vector4( v.w, v.y, v.w, v.y );
        }

        public static Vector4 WYWZ( this Vector4 v )
        {
            return new Vector4( v.w, v.y, v.w, v.z );
        }

        public static Vector4 WYWW( this Vector4 v )
        {
            return new Vector4( v.w, v.y, v.w, v.w );
        }

        public static Vector4 WYW_( this Vector4 v )
        {
            return new Vector4( v.w, v.y, v.w, 0f );
        }

        public static Vector4 WY_X( this Vector4 v )
        {
            return new Vector4( v.w, v.y, 0f, v.x );
        }

        public static Vector4 WY_Y( this Vector4 v )
        {
            return new Vector4( v.w, v.y, 0f, v.y );
        }

        public static Vector4 WY_Z( this Vector4 v )
        {
            return new Vector4( v.w, v.y, 0f, v.z );
        }

        public static Vector4 WY_W( this Vector4 v )
        {
            return new Vector4( v.w, v.y, 0f, v.w );
        }

        public static Vector4 WY__( this Vector4 v )
        {
            return new Vector4( v.w, v.y, 0f, 0f );
        }

        public static Vector4 WZXX( this Vector4 v )
        {
            return new Vector4( v.w, v.z, v.x, v.x );
        }

        public static Vector4 WZXY( this Vector4 v )
        {
            return new Vector4( v.w, v.z, v.x, v.y );
        }

        public static Vector4 WZXZ( this Vector4 v )
        {
            return new Vector4( v.w, v.z, v.x, v.z );
        }

        public static Vector4 WZXW( this Vector4 v )
        {
            return new Vector4( v.w, v.z, v.x, v.w );
        }

        public static Vector4 WZX_( this Vector4 v )
        {
            return new Vector4( v.w, v.z, v.x, 0f );
        }

        public static Vector4 WZYX( this Vector4 v )
        {
            return new Vector4( v.w, v.z, v.y, v.x );
        }

        public static Vector4 WZYY( this Vector4 v )
        {
            return new Vector4( v.w, v.z, v.y, v.y );
        }

        public static Vector4 WZYZ( this Vector4 v )
        {
            return new Vector4( v.w, v.z, v.y, v.z );
        }

        public static Vector4 WZYW( this Vector4 v )
        {
            return new Vector4( v.w, v.z, v.y, v.w );
        }

        public static Vector4 WZY_( this Vector4 v )
        {
            return new Vector4( v.w, v.z, v.y, 0f );
        }

        public static Vector4 WZZX( this Vector4 v )
        {
            return new Vector4( v.w, v.z, v.z, v.x );
        }

        public static Vector4 WZZY( this Vector4 v )
        {
            return new Vector4( v.w, v.z, v.z, v.y );
        }

        public static Vector4 WZZZ( this Vector4 v )
        {
            return new Vector4( v.w, v.z, v.z, v.z );
        }

        public static Vector4 WZZW( this Vector4 v )
        {
            return new Vector4( v.w, v.z, v.z, v.w );
        }

        public static Vector4 WZZ_( this Vector4 v )
        {
            return new Vector4( v.w, v.z, v.z, 0f );
        }

        public static Vector4 WZWX( this Vector4 v )
        {
            return new Vector4( v.w, v.z, v.w, v.x );
        }

        public static Vector4 WZWY( this Vector4 v )
        {
            return new Vector4( v.w, v.z, v.w, v.y );
        }

        public static Vector4 WZWZ( this Vector4 v )
        {
            return new Vector4( v.w, v.z, v.w, v.z );
        }

        public static Vector4 WZWW( this Vector4 v )
        {
            return new Vector4( v.w, v.z, v.w, v.w );
        }

        public static Vector4 WZW_( this Vector4 v )
        {
            return new Vector4( v.w, v.z, v.w, 0f );
        }

        public static Vector4 WZ_X( this Vector4 v )
        {
            return new Vector4( v.w, v.z, 0f, v.x );
        }

        public static Vector4 WZ_Y( this Vector4 v )
        {
            return new Vector4( v.w, v.z, 0f, v.y );
        }

        public static Vector4 WZ_Z( this Vector4 v )
        {
            return new Vector4( v.w, v.z, 0f, v.z );
        }

        public static Vector4 WZ_W( this Vector4 v )
        {
            return new Vector4( v.w, v.z, 0f, v.w );
        }

        public static Vector4 WZ__( this Vector4 v )
        {
            return new Vector4( v.w, v.z, 0f, 0f );
        }

        public static Vector4 WWXX( this Vector4 v )
        {
            return new Vector4( v.w, v.w, v.x, v.x );
        }

        public static Vector4 WWXY( this Vector4 v )
        {
            return new Vector4( v.w, v.w, v.x, v.y );
        }

        public static Vector4 WWXZ( this Vector4 v )
        {
            return new Vector4( v.w, v.w, v.x, v.z );
        }

        public static Vector4 WWXW( this Vector4 v )
        {
            return new Vector4( v.w, v.w, v.x, v.w );
        }

        public static Vector4 WWX_( this Vector4 v )
        {
            return new Vector4( v.w, v.w, v.x, 0f );
        }

        public static Vector4 WWYX( this Vector4 v )
        {
            return new Vector4( v.w, v.w, v.y, v.x );
        }

        public static Vector4 WWYY( this Vector4 v )
        {
            return new Vector4( v.w, v.w, v.y, v.y );
        }

        public static Vector4 WWYZ( this Vector4 v )
        {
            return new Vector4( v.w, v.w, v.y, v.z );
        }

        public static Vector4 WWYW( this Vector4 v )
        {
            return new Vector4( v.w, v.w, v.y, v.w );
        }

        public static Vector4 WWY_( this Vector4 v )
        {
            return new Vector4( v.w, v.w, v.y, 0f );
        }

        public static Vector4 WWZX( this Vector4 v )
        {
            return new Vector4( v.w, v.w, v.z, v.x );
        }

        public static Vector4 WWZY( this Vector4 v )
        {
            return new Vector4( v.w, v.w, v.z, v.y );
        }

        public static Vector4 WWZZ( this Vector4 v )
        {
            return new Vector4( v.w, v.w, v.z, v.z );
        }

        public static Vector4 WWZW( this Vector4 v )
        {
            return new Vector4( v.w, v.w, v.z, v.w );
        }

        public static Vector4 WWZ_( this Vector4 v )
        {
            return new Vector4( v.w, v.w, v.z, 0f );
        }

        public static Vector4 WWWX( this Vector4 v )
        {
            return new Vector4( v.w, v.w, v.w, v.x );
        }

        public static Vector4 WWWY( this Vector4 v )
        {
            return new Vector4( v.w, v.w, v.w, v.y );
        }

        public static Vector4 WWWZ( this Vector4 v )
        {
            return new Vector4( v.w, v.w, v.w, v.z );
        }

        public static Vector4 WWWW( this Vector4 v )
        {
            return new Vector4( v.w, v.w, v.w, v.w );
        }

        public static Vector4 WWW_( this Vector4 v )
        {
            return new Vector4( v.w, v.w, v.w, 0f );
        }

        public static Vector4 WW_X( this Vector4 v )
        {
            return new Vector4( v.w, v.w, 0f, v.x );
        }

        public static Vector4 WW_Y( this Vector4 v )
        {
            return new Vector4( v.w, v.w, 0f, v.y );
        }

        public static Vector4 WW_Z( this Vector4 v )
        {
            return new Vector4( v.w, v.w, 0f, v.z );
        }

        public static Vector4 WW_W( this Vector4 v )
        {
            return new Vector4( v.w, v.w, 0f, v.w );
        }

        public static Vector4 WW__( this Vector4 v )
        {
            return new Vector4( v.w, v.w, 0f, 0f );
        }

        public static Vector4 W_XX( this Vector4 v )
        {
            return new Vector4( v.w, 0f, v.x, v.x );
        }

        public static Vector4 W_XY( this Vector4 v )
        {
            return new Vector4( v.w, 0f, v.x, v.y );
        }

        public static Vector4 W_XZ( this Vector4 v )
        {
            return new Vector4( v.w, 0f, v.x, v.z );
        }

        public static Vector4 W_XW( this Vector4 v )
        {
            return new Vector4( v.w, 0f, v.x, v.w );
        }

        public static Vector4 W_X_( this Vector4 v )
        {
            return new Vector4( v.w, 0f, v.x, 0f );
        }

        public static Vector4 W_YX( this Vector4 v )
        {
            return new Vector4( v.w, 0f, v.y, v.x );
        }

        public static Vector4 W_YY( this Vector4 v )
        {
            return new Vector4( v.w, 0f, v.y, v.y );
        }

        public static Vector4 W_YZ( this Vector4 v )
        {
            return new Vector4( v.w, 0f, v.y, v.z );
        }

        public static Vector4 W_YW( this Vector4 v )
        {
            return new Vector4( v.w, 0f, v.y, v.w );
        }

        public static Vector4 W_Y_( this Vector4 v )
        {
            return new Vector4( v.w, 0f, v.y, 0f );
        }

        public static Vector4 W_ZX( this Vector4 v )
        {
            return new Vector4( v.w, 0f, v.z, v.x );
        }

        public static Vector4 W_ZY( this Vector4 v )
        {
            return new Vector4( v.w, 0f, v.z, v.y );
        }

        public static Vector4 W_ZZ( this Vector4 v )
        {
            return new Vector4( v.w, 0f, v.z, v.z );
        }

        public static Vector4 W_ZW( this Vector4 v )
        {
            return new Vector4( v.w, 0f, v.z, v.w );
        }

        public static Vector4 W_Z_( this Vector4 v )
        {
            return new Vector4( v.w, 0f, v.z, 0f );
        }

        public static Vector4 W_WX( this Vector4 v )
        {
            return new Vector4( v.w, 0f, v.w, v.x );
        }

        public static Vector4 W_WY( this Vector4 v )
        {
            return new Vector4( v.w, 0f, v.w, v.y );
        }

        public static Vector4 W_WZ( this Vector4 v )
        {
            return new Vector4( v.w, 0f, v.w, v.z );
        }

        public static Vector4 W_WW( this Vector4 v )
        {
            return new Vector4( v.w, 0f, v.w, v.w );
        }

        public static Vector4 W_W_( this Vector4 v )
        {
            return new Vector4( v.w, 0f, v.w, 0f );
        }

        public static Vector4 W__X( this Vector4 v )
        {
            return new Vector4( v.w, 0f, 0f, v.x );
        }

        public static Vector4 W__Y( this Vector4 v )
        {
            return new Vector4( v.w, 0f, 0f, v.y );
        }

        public static Vector4 W__Z( this Vector4 v )
        {
            return new Vector4( v.w, 0f, 0f, v.z );
        }

        public static Vector4 W__W( this Vector4 v )
        {
            return new Vector4( v.w, 0f, 0f, v.w );
        }

        public static Vector4 W___( this Vector4 v )
        {
            return new Vector4( v.w, 0f, 0f, 0f );
        }

        public static Vector4 _XXX( this Vector4 v )
        {
            return new Vector4( 0f, v.x, v.x, v.x );
        }

        public static Vector4 _XXY( this Vector4 v )
        {
            return new Vector4( 0f, v.x, v.x, v.y );
        }

        public static Vector4 _XXZ( this Vector4 v )
        {
            return new Vector4( 0f, v.x, v.x, v.z );
        }

        public static Vector4 _XXW( this Vector4 v )
        {
            return new Vector4( 0f, v.x, v.x, v.w );
        }

        public static Vector4 _XX_( this Vector4 v )
        {
            return new Vector4( 0f, v.x, v.x, 0f );
        }

        public static Vector4 _XYX( this Vector4 v )
        {
            return new Vector4( 0f, v.x, v.y, v.x );
        }

        public static Vector4 _XYY( this Vector4 v )
        {
            return new Vector4( 0f, v.x, v.y, v.y );
        }

        public static Vector4 _XYZ( this Vector4 v )
        {
            return new Vector4( 0f, v.x, v.y, v.z );
        }

        public static Vector4 _XYW( this Vector4 v )
        {
            return new Vector4( 0f, v.x, v.y, v.w );
        }

        public static Vector4 _XY_( this Vector4 v )
        {
            return new Vector4( 0f, v.x, v.y, 0f );
        }

        public static Vector4 _XZX( this Vector4 v )
        {
            return new Vector4( 0f, v.x, v.z, v.x );
        }

        public static Vector4 _XZY( this Vector4 v )
        {
            return new Vector4( 0f, v.x, v.z, v.y );
        }

        public static Vector4 _XZZ( this Vector4 v )
        {
            return new Vector4( 0f, v.x, v.z, v.z );
        }

        public static Vector4 _XZW( this Vector4 v )
        {
            return new Vector4( 0f, v.x, v.z, v.w );
        }

        public static Vector4 _XZ_( this Vector4 v )
        {
            return new Vector4( 0f, v.x, v.z, 0f );
        }

        public static Vector4 _XWX( this Vector4 v )
        {
            return new Vector4( 0f, v.x, v.w, v.x );
        }

        public static Vector4 _XWY( this Vector4 v )
        {
            return new Vector4( 0f, v.x, v.w, v.y );
        }

        public static Vector4 _XWZ( this Vector4 v )
        {
            return new Vector4( 0f, v.x, v.w, v.z );
        }

        public static Vector4 _XWW( this Vector4 v )
        {
            return new Vector4( 0f, v.x, v.w, v.w );
        }

        public static Vector4 _XW_( this Vector4 v )
        {
            return new Vector4( 0f, v.x, v.w, 0f );
        }

        public static Vector4 _X_X( this Vector4 v )
        {
            return new Vector4( 0f, v.x, 0f, v.x );
        }

        public static Vector4 _X_Y( this Vector4 v )
        {
            return new Vector4( 0f, v.x, 0f, v.y );
        }

        public static Vector4 _X_Z( this Vector4 v )
        {
            return new Vector4( 0f, v.x, 0f, v.z );
        }

        public static Vector4 _X_W( this Vector4 v )
        {
            return new Vector4( 0f, v.x, 0f, v.w );
        }

        public static Vector4 _X__( this Vector4 v )
        {
            return new Vector4( 0f, v.x, 0f, 0f );
        }

        public static Vector4 _YXX( this Vector4 v )
        {
            return new Vector4( 0f, v.y, v.x, v.x );
        }

        public static Vector4 _YXY( this Vector4 v )
        {
            return new Vector4( 0f, v.y, v.x, v.y );
        }

        public static Vector4 _YXZ( this Vector4 v )
        {
            return new Vector4( 0f, v.y, v.x, v.z );
        }

        public static Vector4 _YXW( this Vector4 v )
        {
            return new Vector4( 0f, v.y, v.x, v.w );
        }

        public static Vector4 _YX_( this Vector4 v )
        {
            return new Vector4( 0f, v.y, v.x, 0f );
        }

        public static Vector4 _YYX( this Vector4 v )
        {
            return new Vector4( 0f, v.y, v.y, v.x );
        }

        public static Vector4 _YYY( this Vector4 v )
        {
            return new Vector4( 0f, v.y, v.y, v.y );
        }

        public static Vector4 _YYZ( this Vector4 v )
        {
            return new Vector4( 0f, v.y, v.y, v.z );
        }

        public static Vector4 _YYW( this Vector4 v )
        {
            return new Vector4( 0f, v.y, v.y, v.w );
        }

        public static Vector4 _YY_( this Vector4 v )
        {
            return new Vector4( 0f, v.y, v.y, 0f );
        }

        public static Vector4 _YZX( this Vector4 v )
        {
            return new Vector4( 0f, v.y, v.z, v.x );
        }

        public static Vector4 _YZY( this Vector4 v )
        {
            return new Vector4( 0f, v.y, v.z, v.y );
        }

        public static Vector4 _YZZ( this Vector4 v )
        {
            return new Vector4( 0f, v.y, v.z, v.z );
        }

        public static Vector4 _YZW( this Vector4 v )
        {
            return new Vector4( 0f, v.y, v.z, v.w );
        }

        public static Vector4 _YZ_( this Vector4 v )
        {
            return new Vector4( 0f, v.y, v.z, 0f );
        }

        public static Vector4 _YWX( this Vector4 v )
        {
            return new Vector4( 0f, v.y, v.w, v.x );
        }

        public static Vector4 _YWY( this Vector4 v )
        {
            return new Vector4( 0f, v.y, v.w, v.y );
        }

        public static Vector4 _YWZ( this Vector4 v )
        {
            return new Vector4( 0f, v.y, v.w, v.z );
        }

        public static Vector4 _YWW( this Vector4 v )
        {
            return new Vector4( 0f, v.y, v.w, v.w );
        }

        public static Vector4 _YW_( this Vector4 v )
        {
            return new Vector4( 0f, v.y, v.w, 0f );
        }

        public static Vector4 _Y_X( this Vector4 v )
        {
            return new Vector4( 0f, v.y, 0f, v.x );
        }

        public static Vector4 _Y_Y( this Vector4 v )
        {
            return new Vector4( 0f, v.y, 0f, v.y );
        }

        public static Vector4 _Y_Z( this Vector4 v )
        {
            return new Vector4( 0f, v.y, 0f, v.z );
        }

        public static Vector4 _Y_W( this Vector4 v )
        {
            return new Vector4( 0f, v.y, 0f, v.w );
        }

        public static Vector4 _Y__( this Vector4 v )
        {
            return new Vector4( 0f, v.y, 0f, 0f );
        }

        public static Vector4 _ZXX( this Vector4 v )
        {
            return new Vector4( 0f, v.z, v.x, v.x );
        }

        public static Vector4 _ZXY( this Vector4 v )
        {
            return new Vector4( 0f, v.z, v.x, v.y );
        }

        public static Vector4 _ZXZ( this Vector4 v )
        {
            return new Vector4( 0f, v.z, v.x, v.z );
        }

        public static Vector4 _ZXW( this Vector4 v )
        {
            return new Vector4( 0f, v.z, v.x, v.w );
        }

        public static Vector4 _ZX_( this Vector4 v )
        {
            return new Vector4( 0f, v.z, v.x, 0f );
        }

        public static Vector4 _ZYX( this Vector4 v )
        {
            return new Vector4( 0f, v.z, v.y, v.x );
        }

        public static Vector4 _ZYY( this Vector4 v )
        {
            return new Vector4( 0f, v.z, v.y, v.y );
        }

        public static Vector4 _ZYZ( this Vector4 v )
        {
            return new Vector4( 0f, v.z, v.y, v.z );
        }

        public static Vector4 _ZYW( this Vector4 v )
        {
            return new Vector4( 0f, v.z, v.y, v.w );
        }

        public static Vector4 _ZY_( this Vector4 v )
        {
            return new Vector4( 0f, v.z, v.y, 0f );
        }

        public static Vector4 _ZZX( this Vector4 v )
        {
            return new Vector4( 0f, v.z, v.z, v.x );
        }

        public static Vector4 _ZZY( this Vector4 v )
        {
            return new Vector4( 0f, v.z, v.z, v.y );
        }

        public static Vector4 _ZZZ( this Vector4 v )
        {
            return new Vector4( 0f, v.z, v.z, v.z );
        }

        public static Vector4 _ZZW( this Vector4 v )
        {
            return new Vector4( 0f, v.z, v.z, v.w );
        }

        public static Vector4 _ZZ_( this Vector4 v )
        {
            return new Vector4( 0f, v.z, v.z, 0f );
        }

        public static Vector4 _ZWX( this Vector4 v )
        {
            return new Vector4( 0f, v.z, v.w, v.x );
        }

        public static Vector4 _ZWY( this Vector4 v )
        {
            return new Vector4( 0f, v.z, v.w, v.y );
        }

        public static Vector4 _ZWZ( this Vector4 v )
        {
            return new Vector4( 0f, v.z, v.w, v.z );
        }

        public static Vector4 _ZWW( this Vector4 v )
        {
            return new Vector4( 0f, v.z, v.w, v.w );
        }

        public static Vector4 _ZW_( this Vector4 v )
        {
            return new Vector4( 0f, v.z, v.w, 0f );
        }

        public static Vector4 _Z_X( this Vector4 v )
        {
            return new Vector4( 0f, v.z, 0f, v.x );
        }

        public static Vector4 _Z_Y( this Vector4 v )
        {
            return new Vector4( 0f, v.z, 0f, v.y );
        }

        public static Vector4 _Z_Z( this Vector4 v )
        {
            return new Vector4( 0f, v.z, 0f, v.z );
        }

        public static Vector4 _Z_W( this Vector4 v )
        {
            return new Vector4( 0f, v.z, 0f, v.w );
        }

        public static Vector4 _Z__( this Vector4 v )
        {
            return new Vector4( 0f, v.z, 0f, 0f );
        }

        public static Vector4 _WXX( this Vector4 v )
        {
            return new Vector4( 0f, v.w, v.x, v.x );
        }

        public static Vector4 _WXY( this Vector4 v )
        {
            return new Vector4( 0f, v.w, v.x, v.y );
        }

        public static Vector4 _WXZ( this Vector4 v )
        {
            return new Vector4( 0f, v.w, v.x, v.z );
        }

        public static Vector4 _WXW( this Vector4 v )
        {
            return new Vector4( 0f, v.w, v.x, v.w );
        }

        public static Vector4 _WX_( this Vector4 v )
        {
            return new Vector4( 0f, v.w, v.x, 0f );
        }

        public static Vector4 _WYX( this Vector4 v )
        {
            return new Vector4( 0f, v.w, v.y, v.x );
        }

        public static Vector4 _WYY( this Vector4 v )
        {
            return new Vector4( 0f, v.w, v.y, v.y );
        }

        public static Vector4 _WYZ( this Vector4 v )
        {
            return new Vector4( 0f, v.w, v.y, v.z );
        }

        public static Vector4 _WYW( this Vector4 v )
        {
            return new Vector4( 0f, v.w, v.y, v.w );
        }

        public static Vector4 _WY_( this Vector4 v )
        {
            return new Vector4( 0f, v.w, v.y, 0f );
        }

        public static Vector4 _WZX( this Vector4 v )
        {
            return new Vector4( 0f, v.w, v.z, v.x );
        }

        public static Vector4 _WZY( this Vector4 v )
        {
            return new Vector4( 0f, v.w, v.z, v.y );
        }

        public static Vector4 _WZZ( this Vector4 v )
        {
            return new Vector4( 0f, v.w, v.z, v.z );
        }

        public static Vector4 _WZW( this Vector4 v )
        {
            return new Vector4( 0f, v.w, v.z, v.w );
        }

        public static Vector4 _WZ_( this Vector4 v )
        {
            return new Vector4( 0f, v.w, v.z, 0f );
        }

        public static Vector4 _WWX( this Vector4 v )
        {
            return new Vector4( 0f, v.w, v.w, v.x );
        }

        public static Vector4 _WWY( this Vector4 v )
        {
            return new Vector4( 0f, v.w, v.w, v.y );
        }

        public static Vector4 _WWZ( this Vector4 v )
        {
            return new Vector4( 0f, v.w, v.w, v.z );
        }

        public static Vector4 _WWW( this Vector4 v )
        {
            return new Vector4( 0f, v.w, v.w, v.w );
        }

        public static Vector4 _WW_( this Vector4 v )
        {
            return new Vector4( 0f, v.w, v.w, 0f );
        }

        public static Vector4 _W_X( this Vector4 v )
        {
            return new Vector4( 0f, v.w, 0f, v.x );
        }

        public static Vector4 _W_Y( this Vector4 v )
        {
            return new Vector4( 0f, v.w, 0f, v.y );
        }

        public static Vector4 _W_Z( this Vector4 v )
        {
            return new Vector4( 0f, v.w, 0f, v.z );
        }

        public static Vector4 _W_W( this Vector4 v )
        {
            return new Vector4( 0f, v.w, 0f, v.w );
        }

        public static Vector4 _W__( this Vector4 v )
        {
            return new Vector4( 0f, v.w, 0f, 0f );
        }

        public static Vector4 __XX( this Vector4 v )
        {
            return new Vector4( 0f, 0f, v.x, v.x );
        }

        public static Vector4 __XY( this Vector4 v )
        {
            return new Vector4( 0f, 0f, v.x, v.y );
        }

        public static Vector4 __XZ( this Vector4 v )
        {
            return new Vector4( 0f, 0f, v.x, v.z );
        }

        public static Vector4 __XW( this Vector4 v )
        {
            return new Vector4( 0f, 0f, v.x, v.w );
        }

        public static Vector4 __X_( this Vector4 v )
        {
            return new Vector4( 0f, 0f, v.x, 0f );
        }

        public static Vector4 __YX( this Vector4 v )
        {
            return new Vector4( 0f, 0f, v.y, v.x );
        }

        public static Vector4 __YY( this Vector4 v )
        {
            return new Vector4( 0f, 0f, v.y, v.y );
        }

        public static Vector4 __YZ( this Vector4 v )
        {
            return new Vector4( 0f, 0f, v.y, v.z );
        }

        public static Vector4 __YW( this Vector4 v )
        {
            return new Vector4( 0f, 0f, v.y, v.w );
        }

        public static Vector4 __Y_( this Vector4 v )
        {
            return new Vector4( 0f, 0f, v.y, 0f );
        }

        public static Vector4 __ZX( this Vector4 v )
        {
            return new Vector4( 0f, 0f, v.z, v.x );
        }

        public static Vector4 __ZY( this Vector4 v )
        {
            return new Vector4( 0f, 0f, v.z, v.y );
        }

        public static Vector4 __ZZ( this Vector4 v )
        {
            return new Vector4( 0f, 0f, v.z, v.z );
        }

        public static Vector4 __ZW( this Vector4 v )
        {
            return new Vector4( 0f, 0f, v.z, v.w );
        }

        public static Vector4 __Z_( this Vector4 v )
        {
            return new Vector4( 0f, 0f, v.z, 0f );
        }

        public static Vector4 __WX( this Vector4 v )
        {
            return new Vector4( 0f, 0f, v.w, v.x );
        }

        public static Vector4 __WY( this Vector4 v )
        {
            return new Vector4( 0f, 0f, v.w, v.y );
        }

        public static Vector4 __WZ( this Vector4 v )
        {
            return new Vector4( 0f, 0f, v.w, v.z );
        }

        public static Vector4 __WW( this Vector4 v )
        {
            return new Vector4( 0f, 0f, v.w, v.w );
        }

        public static Vector4 __W_( this Vector4 v )
        {
            return new Vector4( 0f, 0f, v.w, 0f );
        }

        public static Vector4 ___X( this Vector4 v )
        {
            return new Vector4( 0f, 0f, 0f, v.x );
        }

        public static Vector4 ___Y( this Vector4 v )
        {
            return new Vector4( 0f, 0f, 0f, v.y );
        }

        public static Vector4 ___Z( this Vector4 v )
        {
            return new Vector4( 0f, 0f, 0f, v.z );
        }

        public static Vector4 ___W( this Vector4 v )
        {
            return new Vector4( 0f, 0f, 0f, v.w );
        }
        #endregion Vector4.XXXX

        #region Vector2Int.XX
        public static Vector2Int XX( this Vector2Int v )
        {
            return new Vector2Int( v.x, v.x );
        }

        public static Vector2Int XY( this Vector2Int v )
        {
            return new Vector2Int( v.x, v.y );
        }

        public static Vector2Int X_( this Vector2Int v )
        {
            return new Vector2Int( v.x, 0 );
        }

        public static Vector2Int YX( this Vector2Int v )
        {
            return new Vector2Int( v.y, v.x );
        }

        public static Vector2Int YY( this Vector2Int v )
        {
            return new Vector2Int( v.y, v.y );
        }

        public static Vector2Int Y_( this Vector2Int v )
        {
            return new Vector2Int( v.y, 0 );
        }

        public static Vector2Int _X( this Vector2Int v )
        {
            return new Vector2Int( 0, v.x );
        }

        public static Vector2Int _Y( this Vector2Int v )
        {
            return new Vector2Int( 0, v.y );
        }
        #endregion Vector2Int.XX

        #region Vector2Int.XXX
        public static Vector3Int XXX( this Vector2Int v )
        {
            return new Vector3Int( v.x, v.x, v.x );
        }

        public static Vector3Int XXY( this Vector2Int v )
        {
            return new Vector3Int( v.x, v.x, v.y );
        }

        public static Vector3Int XX_( this Vector2Int v )
        {
            return new Vector3Int( v.x, v.x, 0 );
        }

        public static Vector3Int XYX( this Vector2Int v )
        {
            return new Vector3Int( v.x, v.y, v.x );
        }

        public static Vector3Int XYY( this Vector2Int v )
        {
            return new Vector3Int( v.x, v.y, v.y );
        }

        public static Vector3Int XY_( this Vector2Int v )
        {
            return new Vector3Int( v.x, v.y, 0 );
        }

        public static Vector3Int X_X( this Vector2Int v )
        {
            return new Vector3Int( v.x, 0, v.x );
        }

        public static Vector3Int X_Y( this Vector2Int v )
        {
            return new Vector3Int( v.x, 0, v.y );
        }

        public static Vector3Int X__( this Vector2Int v )
        {
            return new Vector3Int( v.x, 0, 0 );
        }

        public static Vector3Int YXX( this Vector2Int v )
        {
            return new Vector3Int( v.y, v.x, v.x );
        }

        public static Vector3Int YXY( this Vector2Int v )
        {
            return new Vector3Int( v.y, v.x, v.y );
        }

        public static Vector3Int YX_( this Vector2Int v )
        {
            return new Vector3Int( v.y, v.x, 0 );
        }

        public static Vector3Int YYX( this Vector2Int v )
        {
            return new Vector3Int( v.y, v.y, v.x );
        }

        public static Vector3Int YYY( this Vector2Int v )
        {
            return new Vector3Int( v.y, v.y, v.y );
        }

        public static Vector3Int YY_( this Vector2Int v )
        {
            return new Vector3Int( v.y, v.y, 0 );
        }

        public static Vector3Int Y_X( this Vector2Int v )
        {
            return new Vector3Int( v.y, 0, v.x );
        }

        public static Vector3Int Y_Y( this Vector2Int v )
        {
            return new Vector3Int( v.y, 0, v.y );
        }

        public static Vector3Int Y__( this Vector2Int v )
        {
            return new Vector3Int( v.y, 0, 0 );
        }

        public static Vector3Int _XX( this Vector2Int v )
        {
            return new Vector3Int( 0, v.x, v.x );
        }

        public static Vector3Int _XY( this Vector2Int v )
        {
            return new Vector3Int( 0, v.x, v.y );
        }

        public static Vector3Int _X_( this Vector2Int v )
        {
            return new Vector3Int( 0, v.x, 0 );
        }

        public static Vector3Int _YX( this Vector2Int v )
        {
            return new Vector3Int( 0, v.y, v.x );
        }

        public static Vector3Int _YY( this Vector2Int v )
        {
            return new Vector3Int( 0, v.y, v.y );
        }

        public static Vector3Int _Y_( this Vector2Int v )
        {
            return new Vector3Int( 0, v.y, 0 );
        }

        public static Vector3Int __X( this Vector2Int v )
        {
            return new Vector3Int( 0, 0, v.x );
        }

        public static Vector3Int __Y( this Vector2Int v )
        {
            return new Vector3Int( 0, 0, v.y );
        }
        #endregion Vector2Int.XXX

        #region Vector3Int.XX
        public static Vector2Int XX( this Vector3Int v )
        {
            return new Vector2Int( v.x, v.x );
        }

        public static Vector2Int XY( this Vector3Int v )
        {
            return new Vector2Int( v.x, v.y );
        }

        public static Vector2Int XZ( this Vector3Int v )
        {
            return new Vector2Int( v.x, v.z );
        }

        public static Vector2Int X_( this Vector3Int v )
        {
            return new Vector2Int( v.x, 0 );
        }

        public static Vector2Int YX( this Vector3Int v )
        {
            return new Vector2Int( v.y, v.x );
        }

        public static Vector2Int YY( this Vector3Int v )
        {
            return new Vector2Int( v.y, v.y );
        }

        public static Vector2Int YZ( this Vector3Int v )
        {
            return new Vector2Int( v.y, v.z );
        }

        public static Vector2Int Y_( this Vector3Int v )
        {
            return new Vector2Int( v.y, 0 );
        }

        public static Vector2Int ZX( this Vector3Int v )
        {
            return new Vector2Int( v.z, v.x );
        }

        public static Vector2Int ZY( this Vector3Int v )
        {
            return new Vector2Int( v.z, v.y );
        }

        public static Vector2Int ZZ( this Vector3Int v )
        {
            return new Vector2Int( v.z, v.z );
        }

        public static Vector2Int Z_( this Vector3Int v )
        {
            return new Vector2Int( v.z, 0 );
        }

        public static Vector2Int _X( this Vector3Int v )
        {
            return new Vector2Int( 0, v.x );
        }

        public static Vector2Int _Y( this Vector3Int v )
        {
            return new Vector2Int( 0, v.y );
        }

        public static Vector2Int _Z( this Vector3Int v )
        {
            return new Vector2Int( 0, v.z );
        }
        #endregion Vector3Int.XX

        #region Vector3Int.XXX
        public static Vector3Int XXX( this Vector3Int v )
        {
            return new Vector3Int( v.x, v.x, v.x );
        }

        public static Vector3Int XXY( this Vector3Int v )
        {
            return new Vector3Int( v.x, v.x, v.y );
        }

        public static Vector3Int XXZ( this Vector3Int v )
        {
            return new Vector3Int( v.x, v.x, v.z );
        }

        public static Vector3Int XX_( this Vector3Int v )
        {
            return new Vector3Int( v.x, v.x, 0 );
        }

        public static Vector3Int XYX( this Vector3Int v )
        {
            return new Vector3Int( v.x, v.y, v.x );
        }

        public static Vector3Int XYY( this Vector3Int v )
        {
            return new Vector3Int( v.x, v.y, v.y );
        }

        public static Vector3Int XYZ( this Vector3Int v )
        {
            return new Vector3Int( v.x, v.y, v.z );
        }

        public static Vector3Int XY_( this Vector3Int v )
        {
            return new Vector3Int( v.x, v.y, 0 );
        }

        public static Vector3Int XZX( this Vector3Int v )
        {
            return new Vector3Int( v.x, v.z, v.x );
        }

        public static Vector3Int XZY( this Vector3Int v )
        {
            return new Vector3Int( v.x, v.z, v.y );
        }

        public static Vector3Int XZZ( this Vector3Int v )
        {
            return new Vector3Int( v.x, v.z, v.z );
        }

        public static Vector3Int XZ_( this Vector3Int v )
        {
            return new Vector3Int( v.x, v.z, 0 );
        }

        public static Vector3Int X_X( this Vector3Int v )
        {
            return new Vector3Int( v.x, 0, v.x );
        }

        public static Vector3Int X_Y( this Vector3Int v )
        {
            return new Vector3Int( v.x, 0, v.y );
        }

        public static Vector3Int X_Z( this Vector3Int v )
        {
            return new Vector3Int( v.x, 0, v.z );
        }

        public static Vector3Int X__( this Vector3Int v )
        {
            return new Vector3Int( v.x, 0, 0 );
        }

        public static Vector3Int YXX( this Vector3Int v )
        {
            return new Vector3Int( v.y, v.x, v.x );
        }

        public static Vector3Int YXY( this Vector3Int v )
        {
            return new Vector3Int( v.y, v.x, v.y );
        }

        public static Vector3Int YXZ( this Vector3Int v )
        {
            return new Vector3Int( v.y, v.x, v.z );
        }

        public static Vector3Int YX_( this Vector3Int v )
        {
            return new Vector3Int( v.y, v.x, 0 );
        }

        public static Vector3Int YYX( this Vector3Int v )
        {
            return new Vector3Int( v.y, v.y, v.x );
        }

        public static Vector3Int YYY( this Vector3Int v )
        {
            return new Vector3Int( v.y, v.y, v.y );
        }

        public static Vector3Int YYZ( this Vector3Int v )
        {
            return new Vector3Int( v.y, v.y, v.z );
        }

        public static Vector3Int YY_( this Vector3Int v )
        {
            return new Vector3Int( v.y, v.y, 0 );
        }

        public static Vector3Int YZX( this Vector3Int v )
        {
            return new Vector3Int( v.y, v.z, v.x );
        }

        public static Vector3Int YZY( this Vector3Int v )
        {
            return new Vector3Int( v.y, v.z, v.y );
        }

        public static Vector3Int YZZ( this Vector3Int v )
        {
            return new Vector3Int( v.y, v.z, v.z );
        }

        public static Vector3Int YZ_( this Vector3Int v )
        {
            return new Vector3Int( v.y, v.z, 0 );
        }

        public static Vector3Int Y_X( this Vector3Int v )
        {
            return new Vector3Int( v.y, 0, v.x );
        }

        public static Vector3Int Y_Y( this Vector3Int v )
        {
            return new Vector3Int( v.y, 0, v.y );
        }

        public static Vector3Int Y_Z( this Vector3Int v )
        {
            return new Vector3Int( v.y, 0, v.z );
        }

        public static Vector3Int Y__( this Vector3Int v )
        {
            return new Vector3Int( v.y, 0, 0 );
        }

        public static Vector3Int ZXX( this Vector3Int v )
        {
            return new Vector3Int( v.z, v.x, v.x );
        }

        public static Vector3Int ZXY( this Vector3Int v )
        {
            return new Vector3Int( v.z, v.x, v.y );
        }

        public static Vector3Int ZXZ( this Vector3Int v )
        {
            return new Vector3Int( v.z, v.x, v.z );
        }

        public static Vector3Int ZX_( this Vector3Int v )
        {
            return new Vector3Int( v.z, v.x, 0 );
        }

        public static Vector3Int ZYX( this Vector3Int v )
        {
            return new Vector3Int( v.z, v.y, v.x );
        }

        public static Vector3Int ZYY( this Vector3Int v )
        {
            return new Vector3Int( v.z, v.y, v.y );
        }

        public static Vector3Int ZYZ( this Vector3Int v )
        {
            return new Vector3Int( v.z, v.y, v.z );
        }

        public static Vector3Int ZY_( this Vector3Int v )
        {
            return new Vector3Int( v.z, v.y, 0 );
        }

        public static Vector3Int ZZX( this Vector3Int v )
        {
            return new Vector3Int( v.z, v.z, v.x );
        }

        public static Vector3Int ZZY( this Vector3Int v )
        {
            return new Vector3Int( v.z, v.z, v.y );
        }

        public static Vector3Int ZZZ( this Vector3Int v )
        {
            return new Vector3Int( v.z, v.z, v.z );
        }

        public static Vector3Int ZZ_( this Vector3Int v )
        {
            return new Vector3Int( v.z, v.z, 0 );
        }

        public static Vector3Int Z_X( this Vector3Int v )
        {
            return new Vector3Int( v.z, 0, v.x );
        }

        public static Vector3Int Z_Y( this Vector3Int v )
        {
            return new Vector3Int( v.z, 0, v.y );
        }

        public static Vector3Int Z_Z( this Vector3Int v )
        {
            return new Vector3Int( v.z, 0, v.z );
        }

        public static Vector3Int Z__( this Vector3Int v )
        {
            return new Vector3Int( v.z, 0, 0 );
        }

        public static Vector3Int _XX( this Vector3Int v )
        {
            return new Vector3Int( 0, v.x, v.x );
        }

        public static Vector3Int _XY( this Vector3Int v )
        {
            return new Vector3Int( 0, v.x, v.y );
        }

        public static Vector3Int _XZ( this Vector3Int v )
        {
            return new Vector3Int( 0, v.x, v.z );
        }

        public static Vector3Int _X_( this Vector3Int v )
        {
            return new Vector3Int( 0, v.x, 0 );
        }

        public static Vector3Int _YX( this Vector3Int v )
        {
            return new Vector3Int( 0, v.y, v.x );
        }

        public static Vector3Int _YY( this Vector3Int v )
        {
            return new Vector3Int( 0, v.y, v.y );
        }

        public static Vector3Int _YZ( this Vector3Int v )
        {
            return new Vector3Int( 0, v.y, v.z );
        }

        public static Vector3Int _Y_( this Vector3Int v )
        {
            return new Vector3Int( 0, v.y, 0 );
        }

        public static Vector3Int _ZX( this Vector3Int v )
        {
            return new Vector3Int( 0, v.z, v.x );
        }

        public static Vector3Int _ZY( this Vector3Int v )
        {
            return new Vector3Int( 0, v.z, v.y );
        }

        public static Vector3Int _ZZ( this Vector3Int v )
        {
            return new Vector3Int( 0, v.z, v.z );
        }

        public static Vector3Int _Z_( this Vector3Int v )
        {
            return new Vector3Int( 0, v.z, 0 );
        }

        public static Vector3Int __X( this Vector3Int v )
        {
            return new Vector3Int( 0, 0, v.x );
        }

        public static Vector3Int __Y( this Vector3Int v )
        {
            return new Vector3Int( 0, 0, v.y );
        }

        public static Vector3Int __Z( this Vector3Int v )
        {
            return new Vector3Int( 0, 0, v.z );
        }
        #endregion Vector3Int.XXX

        #region Color.RRRR
        public static Color RRRR( this Color v )
        {
            return new Color( v.r, v.r, v.r, v.r );
        }

        public static Color RRRG( this Color v )
        {
            return new Color( v.r, v.r, v.r, v.g );
        }

        public static Color RRRB( this Color v )
        {
            return new Color( v.r, v.r, v.r, v.b );
        }

        public static Color RRRA( this Color v )
        {
            return new Color( v.r, v.r, v.r, v.a );
        }

        public static Color RRR_( this Color v )
        {
            return new Color( v.r, v.r, v.r, 0f );
        }

        public static Color RRGR( this Color v )
        {
            return new Color( v.r, v.r, v.g, v.r );
        }

        public static Color RRGG( this Color v )
        {
            return new Color( v.r, v.r, v.g, v.g );
        }

        public static Color RRGB( this Color v )
        {
            return new Color( v.r, v.r, v.g, v.b );
        }

        public static Color RRGA( this Color v )
        {
            return new Color( v.r, v.r, v.g, v.a );
        }

        public static Color RRG_( this Color v )
        {
            return new Color( v.r, v.r, v.g, 0f );
        }

        public static Color RRBR( this Color v )
        {
            return new Color( v.r, v.r, v.b, v.r );
        }

        public static Color RRBG( this Color v )
        {
            return new Color( v.r, v.r, v.b, v.g );
        }

        public static Color RRBB( this Color v )
        {
            return new Color( v.r, v.r, v.b, v.b );
        }

        public static Color RRBA( this Color v )
        {
            return new Color( v.r, v.r, v.b, v.a );
        }

        public static Color RRB_( this Color v )
        {
            return new Color( v.r, v.r, v.b, 0f );
        }

        public static Color RRAR( this Color v )
        {
            return new Color( v.r, v.r, v.a, v.r );
        }

        public static Color RRAG( this Color v )
        {
            return new Color( v.r, v.r, v.a, v.g );
        }

        public static Color RRAB( this Color v )
        {
            return new Color( v.r, v.r, v.a, v.b );
        }

        public static Color RRAA( this Color v )
        {
            return new Color( v.r, v.r, v.a, v.a );
        }

        public static Color RRA_( this Color v )
        {
            return new Color( v.r, v.r, v.a, 0f );
        }

        public static Color RR_R( this Color v )
        {
            return new Color( v.r, v.r, 0f, v.r );
        }

        public static Color RR_G( this Color v )
        {
            return new Color( v.r, v.r, 0f, v.g );
        }

        public static Color RR_B( this Color v )
        {
            return new Color( v.r, v.r, 0f, v.b );
        }

        public static Color RR_A( this Color v )
        {
            return new Color( v.r, v.r, 0f, v.a );
        }

        public static Color RR__( this Color v )
        {
            return new Color( v.r, v.r, 0f, 0f );
        }

        public static Color RGRR( this Color v )
        {
            return new Color( v.r, v.g, v.r, v.r );
        }

        public static Color RGRG( this Color v )
        {
            return new Color( v.r, v.g, v.r, v.g );
        }

        public static Color RGRB( this Color v )
        {
            return new Color( v.r, v.g, v.r, v.b );
        }

        public static Color RGRA( this Color v )
        {
            return new Color( v.r, v.g, v.r, v.a );
        }

        public static Color RGR_( this Color v )
        {
            return new Color( v.r, v.g, v.r, 0f );
        }

        public static Color RGGR( this Color v )
        {
            return new Color( v.r, v.g, v.g, v.r );
        }

        public static Color RGGG( this Color v )
        {
            return new Color( v.r, v.g, v.g, v.g );
        }

        public static Color RGGB( this Color v )
        {
            return new Color( v.r, v.g, v.g, v.b );
        }

        public static Color RGGA( this Color v )
        {
            return new Color( v.r, v.g, v.g, v.a );
        }

        public static Color RGG_( this Color v )
        {
            return new Color( v.r, v.g, v.g, 0f );
        }

        public static Color RGBR( this Color v )
        {
            return new Color( v.r, v.g, v.b, v.r );
        }

        public static Color RGBG( this Color v )
        {
            return new Color( v.r, v.g, v.b, v.g );
        }

        public static Color RGBB( this Color v )
        {
            return new Color( v.r, v.g, v.b, v.b );
        }

        public static Color RGBA( this Color v )
        {
            return new Color( v.r, v.g, v.b, v.a );
        }

        public static Color RGB_( this Color v )
        {
            return new Color( v.r, v.g, v.b, 0f );
        }

        public static Color RGAR( this Color v )
        {
            return new Color( v.r, v.g, v.a, v.r );
        }

        public static Color RGAG( this Color v )
        {
            return new Color( v.r, v.g, v.a, v.g );
        }

        public static Color RGAB( this Color v )
        {
            return new Color( v.r, v.g, v.a, v.b );
        }

        public static Color RGAA( this Color v )
        {
            return new Color( v.r, v.g, v.a, v.a );
        }

        public static Color RGA_( this Color v )
        {
            return new Color( v.r, v.g, v.a, 0f );
        }

        public static Color RG_R( this Color v )
        {
            return new Color( v.r, v.g, 0f, v.r );
        }

        public static Color RG_G( this Color v )
        {
            return new Color( v.r, v.g, 0f, v.g );
        }

        public static Color RG_B( this Color v )
        {
            return new Color( v.r, v.g, 0f, v.b );
        }

        public static Color RG_A( this Color v )
        {
            return new Color( v.r, v.g, 0f, v.a );
        }

        public static Color RG__( this Color v )
        {
            return new Color( v.r, v.g, 0f, 0f );
        }

        public static Color RBRR( this Color v )
        {
            return new Color( v.r, v.b, v.r, v.r );
        }

        public static Color RBRG( this Color v )
        {
            return new Color( v.r, v.b, v.r, v.g );
        }

        public static Color RBRB( this Color v )
        {
            return new Color( v.r, v.b, v.r, v.b );
        }

        public static Color RBRA( this Color v )
        {
            return new Color( v.r, v.b, v.r, v.a );
        }

        public static Color RBR_( this Color v )
        {
            return new Color( v.r, v.b, v.r, 0f );
        }

        public static Color RBGR( this Color v )
        {
            return new Color( v.r, v.b, v.g, v.r );
        }

        public static Color RBGG( this Color v )
        {
            return new Color( v.r, v.b, v.g, v.g );
        }

        public static Color RBGB( this Color v )
        {
            return new Color( v.r, v.b, v.g, v.b );
        }

        public static Color RBGA( this Color v )
        {
            return new Color( v.r, v.b, v.g, v.a );
        }

        public static Color RBG_( this Color v )
        {
            return new Color( v.r, v.b, v.g, 0f );
        }

        public static Color RBBR( this Color v )
        {
            return new Color( v.r, v.b, v.b, v.r );
        }

        public static Color RBBG( this Color v )
        {
            return new Color( v.r, v.b, v.b, v.g );
        }

        public static Color RBBB( this Color v )
        {
            return new Color( v.r, v.b, v.b, v.b );
        }

        public static Color RBBA( this Color v )
        {
            return new Color( v.r, v.b, v.b, v.a );
        }

        public static Color RBB_( this Color v )
        {
            return new Color( v.r, v.b, v.b, 0f );
        }

        public static Color RBAR( this Color v )
        {
            return new Color( v.r, v.b, v.a, v.r );
        }

        public static Color RBAG( this Color v )
        {
            return new Color( v.r, v.b, v.a, v.g );
        }

        public static Color RBAB( this Color v )
        {
            return new Color( v.r, v.b, v.a, v.b );
        }

        public static Color RBAA( this Color v )
        {
            return new Color( v.r, v.b, v.a, v.a );
        }

        public static Color RBA_( this Color v )
        {
            return new Color( v.r, v.b, v.a, 0f );
        }

        public static Color RB_R( this Color v )
        {
            return new Color( v.r, v.b, 0f, v.r );
        }

        public static Color RB_G( this Color v )
        {
            return new Color( v.r, v.b, 0f, v.g );
        }

        public static Color RB_B( this Color v )
        {
            return new Color( v.r, v.b, 0f, v.b );
        }

        public static Color RB_A( this Color v )
        {
            return new Color( v.r, v.b, 0f, v.a );
        }

        public static Color RB__( this Color v )
        {
            return new Color( v.r, v.b, 0f, 0f );
        }

        public static Color RARR( this Color v )
        {
            return new Color( v.r, v.a, v.r, v.r );
        }

        public static Color RARG( this Color v )
        {
            return new Color( v.r, v.a, v.r, v.g );
        }

        public static Color RARB( this Color v )
        {
            return new Color( v.r, v.a, v.r, v.b );
        }

        public static Color RARA( this Color v )
        {
            return new Color( v.r, v.a, v.r, v.a );
        }

        public static Color RAR_( this Color v )
        {
            return new Color( v.r, v.a, v.r, 0f );
        }

        public static Color RAGR( this Color v )
        {
            return new Color( v.r, v.a, v.g, v.r );
        }

        public static Color RAGG( this Color v )
        {
            return new Color( v.r, v.a, v.g, v.g );
        }

        public static Color RAGB( this Color v )
        {
            return new Color( v.r, v.a, v.g, v.b );
        }

        public static Color RAGA( this Color v )
        {
            return new Color( v.r, v.a, v.g, v.a );
        }

        public static Color RAG_( this Color v )
        {
            return new Color( v.r, v.a, v.g, 0f );
        }

        public static Color RABR( this Color v )
        {
            return new Color( v.r, v.a, v.b, v.r );
        }

        public static Color RABG( this Color v )
        {
            return new Color( v.r, v.a, v.b, v.g );
        }

        public static Color RABB( this Color v )
        {
            return new Color( v.r, v.a, v.b, v.b );
        }

        public static Color RABA( this Color v )
        {
            return new Color( v.r, v.a, v.b, v.a );
        }

        public static Color RAB_( this Color v )
        {
            return new Color( v.r, v.a, v.b, 0f );
        }

        public static Color RAAR( this Color v )
        {
            return new Color( v.r, v.a, v.a, v.r );
        }

        public static Color RAAG( this Color v )
        {
            return new Color( v.r, v.a, v.a, v.g );
        }

        public static Color RAAB( this Color v )
        {
            return new Color( v.r, v.a, v.a, v.b );
        }

        public static Color RAAA( this Color v )
        {
            return new Color( v.r, v.a, v.a, v.a );
        }

        public static Color RAA_( this Color v )
        {
            return new Color( v.r, v.a, v.a, 0f );
        }

        public static Color RA_R( this Color v )
        {
            return new Color( v.r, v.a, 0f, v.r );
        }

        public static Color RA_G( this Color v )
        {
            return new Color( v.r, v.a, 0f, v.g );
        }

        public static Color RA_B( this Color v )
        {
            return new Color( v.r, v.a, 0f, v.b );
        }

        public static Color RA_A( this Color v )
        {
            return new Color( v.r, v.a, 0f, v.a );
        }

        public static Color RA__( this Color v )
        {
            return new Color( v.r, v.a, 0f, 0f );
        }

        public static Color R_RR( this Color v )
        {
            return new Color( v.r, 0f, v.r, v.r );
        }

        public static Color R_RG( this Color v )
        {
            return new Color( v.r, 0f, v.r, v.g );
        }

        public static Color R_RB( this Color v )
        {
            return new Color( v.r, 0f, v.r, v.b );
        }

        public static Color R_RA( this Color v )
        {
            return new Color( v.r, 0f, v.r, v.a );
        }

        public static Color R_R_( this Color v )
        {
            return new Color( v.r, 0f, v.r, 0f );
        }

        public static Color R_GR( this Color v )
        {
            return new Color( v.r, 0f, v.g, v.r );
        }

        public static Color R_GG( this Color v )
        {
            return new Color( v.r, 0f, v.g, v.g );
        }

        public static Color R_GB( this Color v )
        {
            return new Color( v.r, 0f, v.g, v.b );
        }

        public static Color R_GA( this Color v )
        {
            return new Color( v.r, 0f, v.g, v.a );
        }

        public static Color R_G_( this Color v )
        {
            return new Color( v.r, 0f, v.g, 0f );
        }

        public static Color R_BR( this Color v )
        {
            return new Color( v.r, 0f, v.b, v.r );
        }

        public static Color R_BG( this Color v )
        {
            return new Color( v.r, 0f, v.b, v.g );
        }

        public static Color R_BB( this Color v )
        {
            return new Color( v.r, 0f, v.b, v.b );
        }

        public static Color R_BA( this Color v )
        {
            return new Color( v.r, 0f, v.b, v.a );
        }

        public static Color R_B_( this Color v )
        {
            return new Color( v.r, 0f, v.b, 0f );
        }

        public static Color R_AR( this Color v )
        {
            return new Color( v.r, 0f, v.a, v.r );
        }

        public static Color R_AG( this Color v )
        {
            return new Color( v.r, 0f, v.a, v.g );
        }

        public static Color R_AB( this Color v )
        {
            return new Color( v.r, 0f, v.a, v.b );
        }

        public static Color R_AA( this Color v )
        {
            return new Color( v.r, 0f, v.a, v.a );
        }

        public static Color R_A_( this Color v )
        {
            return new Color( v.r, 0f, v.a, 0f );
        }

        public static Color R__R( this Color v )
        {
            return new Color( v.r, 0f, 0f, v.r );
        }

        public static Color R__G( this Color v )
        {
            return new Color( v.r, 0f, 0f, v.g );
        }

        public static Color R__B( this Color v )
        {
            return new Color( v.r, 0f, 0f, v.b );
        }

        public static Color R__A( this Color v )
        {
            return new Color( v.r, 0f, 0f, v.a );
        }

        public static Color R___( this Color v )
        {
            return new Color( v.r, 0f, 0f, 0f );
        }

        public static Color GRRR( this Color v )
        {
            return new Color( v.g, v.r, v.r, v.r );
        }

        public static Color GRRG( this Color v )
        {
            return new Color( v.g, v.r, v.r, v.g );
        }

        public static Color GRRB( this Color v )
        {
            return new Color( v.g, v.r, v.r, v.b );
        }

        public static Color GRRA( this Color v )
        {
            return new Color( v.g, v.r, v.r, v.a );
        }

        public static Color GRR_( this Color v )
        {
            return new Color( v.g, v.r, v.r, 0f );
        }

        public static Color GRGR( this Color v )
        {
            return new Color( v.g, v.r, v.g, v.r );
        }

        public static Color GRGG( this Color v )
        {
            return new Color( v.g, v.r, v.g, v.g );
        }

        public static Color GRGB( this Color v )
        {
            return new Color( v.g, v.r, v.g, v.b );
        }

        public static Color GRGA( this Color v )
        {
            return new Color( v.g, v.r, v.g, v.a );
        }

        public static Color GRG_( this Color v )
        {
            return new Color( v.g, v.r, v.g, 0f );
        }

        public static Color GRBR( this Color v )
        {
            return new Color( v.g, v.r, v.b, v.r );
        }

        public static Color GRBG( this Color v )
        {
            return new Color( v.g, v.r, v.b, v.g );
        }

        public static Color GRBB( this Color v )
        {
            return new Color( v.g, v.r, v.b, v.b );
        }

        public static Color GRBA( this Color v )
        {
            return new Color( v.g, v.r, v.b, v.a );
        }

        public static Color GRB_( this Color v )
        {
            return new Color( v.g, v.r, v.b, 0f );
        }

        public static Color GRAR( this Color v )
        {
            return new Color( v.g, v.r, v.a, v.r );
        }

        public static Color GRAG( this Color v )
        {
            return new Color( v.g, v.r, v.a, v.g );
        }

        public static Color GRAB( this Color v )
        {
            return new Color( v.g, v.r, v.a, v.b );
        }

        public static Color GRAA( this Color v )
        {
            return new Color( v.g, v.r, v.a, v.a );
        }

        public static Color GRA_( this Color v )
        {
            return new Color( v.g, v.r, v.a, 0f );
        }

        public static Color GR_R( this Color v )
        {
            return new Color( v.g, v.r, 0f, v.r );
        }

        public static Color GR_G( this Color v )
        {
            return new Color( v.g, v.r, 0f, v.g );
        }

        public static Color GR_B( this Color v )
        {
            return new Color( v.g, v.r, 0f, v.b );
        }

        public static Color GR_A( this Color v )
        {
            return new Color( v.g, v.r, 0f, v.a );
        }

        public static Color GR__( this Color v )
        {
            return new Color( v.g, v.r, 0f, 0f );
        }

        public static Color GGRR( this Color v )
        {
            return new Color( v.g, v.g, v.r, v.r );
        }

        public static Color GGRG( this Color v )
        {
            return new Color( v.g, v.g, v.r, v.g );
        }

        public static Color GGRB( this Color v )
        {
            return new Color( v.g, v.g, v.r, v.b );
        }

        public static Color GGRA( this Color v )
        {
            return new Color( v.g, v.g, v.r, v.a );
        }

        public static Color GGR_( this Color v )
        {
            return new Color( v.g, v.g, v.r, 0f );
        }

        public static Color GGGR( this Color v )
        {
            return new Color( v.g, v.g, v.g, v.r );
        }

        public static Color GGGG( this Color v )
        {
            return new Color( v.g, v.g, v.g, v.g );
        }

        public static Color GGGB( this Color v )
        {
            return new Color( v.g, v.g, v.g, v.b );
        }

        public static Color GGGA( this Color v )
        {
            return new Color( v.g, v.g, v.g, v.a );
        }

        public static Color GGG_( this Color v )
        {
            return new Color( v.g, v.g, v.g, 0f );
        }

        public static Color GGBR( this Color v )
        {
            return new Color( v.g, v.g, v.b, v.r );
        }

        public static Color GGBG( this Color v )
        {
            return new Color( v.g, v.g, v.b, v.g );
        }

        public static Color GGBB( this Color v )
        {
            return new Color( v.g, v.g, v.b, v.b );
        }

        public static Color GGBA( this Color v )
        {
            return new Color( v.g, v.g, v.b, v.a );
        }

        public static Color GGB_( this Color v )
        {
            return new Color( v.g, v.g, v.b, 0f );
        }

        public static Color GGAR( this Color v )
        {
            return new Color( v.g, v.g, v.a, v.r );
        }

        public static Color GGAG( this Color v )
        {
            return new Color( v.g, v.g, v.a, v.g );
        }

        public static Color GGAB( this Color v )
        {
            return new Color( v.g, v.g, v.a, v.b );
        }

        public static Color GGAA( this Color v )
        {
            return new Color( v.g, v.g, v.a, v.a );
        }

        public static Color GGA_( this Color v )
        {
            return new Color( v.g, v.g, v.a, 0f );
        }

        public static Color GG_R( this Color v )
        {
            return new Color( v.g, v.g, 0f, v.r );
        }

        public static Color GG_G( this Color v )
        {
            return new Color( v.g, v.g, 0f, v.g );
        }

        public static Color GG_B( this Color v )
        {
            return new Color( v.g, v.g, 0f, v.b );
        }

        public static Color GG_A( this Color v )
        {
            return new Color( v.g, v.g, 0f, v.a );
        }

        public static Color GG__( this Color v )
        {
            return new Color( v.g, v.g, 0f, 0f );
        }

        public static Color GBRR( this Color v )
        {
            return new Color( v.g, v.b, v.r, v.r );
        }

        public static Color GBRG( this Color v )
        {
            return new Color( v.g, v.b, v.r, v.g );
        }

        public static Color GBRB( this Color v )
        {
            return new Color( v.g, v.b, v.r, v.b );
        }

        public static Color GBRA( this Color v )
        {
            return new Color( v.g, v.b, v.r, v.a );
        }

        public static Color GBR_( this Color v )
        {
            return new Color( v.g, v.b, v.r, 0f );
        }

        public static Color GBGR( this Color v )
        {
            return new Color( v.g, v.b, v.g, v.r );
        }

        public static Color GBGG( this Color v )
        {
            return new Color( v.g, v.b, v.g, v.g );
        }

        public static Color GBGB( this Color v )
        {
            return new Color( v.g, v.b, v.g, v.b );
        }

        public static Color GBGA( this Color v )
        {
            return new Color( v.g, v.b, v.g, v.a );
        }

        public static Color GBG_( this Color v )
        {
            return new Color( v.g, v.b, v.g, 0f );
        }

        public static Color GBBR( this Color v )
        {
            return new Color( v.g, v.b, v.b, v.r );
        }

        public static Color GBBG( this Color v )
        {
            return new Color( v.g, v.b, v.b, v.g );
        }

        public static Color GBBB( this Color v )
        {
            return new Color( v.g, v.b, v.b, v.b );
        }

        public static Color GBBA( this Color v )
        {
            return new Color( v.g, v.b, v.b, v.a );
        }

        public static Color GBB_( this Color v )
        {
            return new Color( v.g, v.b, v.b, 0f );
        }

        public static Color GBAR( this Color v )
        {
            return new Color( v.g, v.b, v.a, v.r );
        }

        public static Color GBAG( this Color v )
        {
            return new Color( v.g, v.b, v.a, v.g );
        }

        public static Color GBAB( this Color v )
        {
            return new Color( v.g, v.b, v.a, v.b );
        }

        public static Color GBAA( this Color v )
        {
            return new Color( v.g, v.b, v.a, v.a );
        }

        public static Color GBA_( this Color v )
        {
            return new Color( v.g, v.b, v.a, 0f );
        }

        public static Color GB_R( this Color v )
        {
            return new Color( v.g, v.b, 0f, v.r );
        }

        public static Color GB_G( this Color v )
        {
            return new Color( v.g, v.b, 0f, v.g );
        }

        public static Color GB_B( this Color v )
        {
            return new Color( v.g, v.b, 0f, v.b );
        }

        public static Color GB_A( this Color v )
        {
            return new Color( v.g, v.b, 0f, v.a );
        }

        public static Color GB__( this Color v )
        {
            return new Color( v.g, v.b, 0f, 0f );
        }

        public static Color GARR( this Color v )
        {
            return new Color( v.g, v.a, v.r, v.r );
        }

        public static Color GARG( this Color v )
        {
            return new Color( v.g, v.a, v.r, v.g );
        }

        public static Color GARB( this Color v )
        {
            return new Color( v.g, v.a, v.r, v.b );
        }

        public static Color GARA( this Color v )
        {
            return new Color( v.g, v.a, v.r, v.a );
        }

        public static Color GAR_( this Color v )
        {
            return new Color( v.g, v.a, v.r, 0f );
        }

        public static Color GAGR( this Color v )
        {
            return new Color( v.g, v.a, v.g, v.r );
        }

        public static Color GAGG( this Color v )
        {
            return new Color( v.g, v.a, v.g, v.g );
        }

        public static Color GAGB( this Color v )
        {
            return new Color( v.g, v.a, v.g, v.b );
        }

        public static Color GAGA( this Color v )
        {
            return new Color( v.g, v.a, v.g, v.a );
        }

        public static Color GAG_( this Color v )
        {
            return new Color( v.g, v.a, v.g, 0f );
        }

        public static Color GABR( this Color v )
        {
            return new Color( v.g, v.a, v.b, v.r );
        }

        public static Color GABG( this Color v )
        {
            return new Color( v.g, v.a, v.b, v.g );
        }

        public static Color GABB( this Color v )
        {
            return new Color( v.g, v.a, v.b, v.b );
        }

        public static Color GABA( this Color v )
        {
            return new Color( v.g, v.a, v.b, v.a );
        }

        public static Color GAB_( this Color v )
        {
            return new Color( v.g, v.a, v.b, 0f );
        }

        public static Color GAAR( this Color v )
        {
            return new Color( v.g, v.a, v.a, v.r );
        }

        public static Color GAAG( this Color v )
        {
            return new Color( v.g, v.a, v.a, v.g );
        }

        public static Color GAAB( this Color v )
        {
            return new Color( v.g, v.a, v.a, v.b );
        }

        public static Color GAAA( this Color v )
        {
            return new Color( v.g, v.a, v.a, v.a );
        }

        public static Color GAA_( this Color v )
        {
            return new Color( v.g, v.a, v.a, 0f );
        }

        public static Color GA_R( this Color v )
        {
            return new Color( v.g, v.a, 0f, v.r );
        }

        public static Color GA_G( this Color v )
        {
            return new Color( v.g, v.a, 0f, v.g );
        }

        public static Color GA_B( this Color v )
        {
            return new Color( v.g, v.a, 0f, v.b );
        }

        public static Color GA_A( this Color v )
        {
            return new Color( v.g, v.a, 0f, v.a );
        }

        public static Color GA__( this Color v )
        {
            return new Color( v.g, v.a, 0f, 0f );
        }

        public static Color G_RR( this Color v )
        {
            return new Color( v.g, 0f, v.r, v.r );
        }

        public static Color G_RG( this Color v )
        {
            return new Color( v.g, 0f, v.r, v.g );
        }

        public static Color G_RB( this Color v )
        {
            return new Color( v.g, 0f, v.r, v.b );
        }

        public static Color G_RA( this Color v )
        {
            return new Color( v.g, 0f, v.r, v.a );
        }

        public static Color G_R_( this Color v )
        {
            return new Color( v.g, 0f, v.r, 0f );
        }

        public static Color G_GR( this Color v )
        {
            return new Color( v.g, 0f, v.g, v.r );
        }

        public static Color G_GG( this Color v )
        {
            return new Color( v.g, 0f, v.g, v.g );
        }

        public static Color G_GB( this Color v )
        {
            return new Color( v.g, 0f, v.g, v.b );
        }

        public static Color G_GA( this Color v )
        {
            return new Color( v.g, 0f, v.g, v.a );
        }

        public static Color G_G_( this Color v )
        {
            return new Color( v.g, 0f, v.g, 0f );
        }

        public static Color G_BR( this Color v )
        {
            return new Color( v.g, 0f, v.b, v.r );
        }

        public static Color G_BG( this Color v )
        {
            return new Color( v.g, 0f, v.b, v.g );
        }

        public static Color G_BB( this Color v )
        {
            return new Color( v.g, 0f, v.b, v.b );
        }

        public static Color G_BA( this Color v )
        {
            return new Color( v.g, 0f, v.b, v.a );
        }

        public static Color G_B_( this Color v )
        {
            return new Color( v.g, 0f, v.b, 0f );
        }

        public static Color G_AR( this Color v )
        {
            return new Color( v.g, 0f, v.a, v.r );
        }

        public static Color G_AG( this Color v )
        {
            return new Color( v.g, 0f, v.a, v.g );
        }

        public static Color G_AB( this Color v )
        {
            return new Color( v.g, 0f, v.a, v.b );
        }

        public static Color G_AA( this Color v )
        {
            return new Color( v.g, 0f, v.a, v.a );
        }

        public static Color G_A_( this Color v )
        {
            return new Color( v.g, 0f, v.a, 0f );
        }

        public static Color G__R( this Color v )
        {
            return new Color( v.g, 0f, 0f, v.r );
        }

        public static Color G__G( this Color v )
        {
            return new Color( v.g, 0f, 0f, v.g );
        }

        public static Color G__B( this Color v )
        {
            return new Color( v.g, 0f, 0f, v.b );
        }

        public static Color G__A( this Color v )
        {
            return new Color( v.g, 0f, 0f, v.a );
        }

        public static Color G___( this Color v )
        {
            return new Color( v.g, 0f, 0f, 0f );
        }

        public static Color BRRR( this Color v )
        {
            return new Color( v.b, v.r, v.r, v.r );
        }

        public static Color BRRG( this Color v )
        {
            return new Color( v.b, v.r, v.r, v.g );
        }

        public static Color BRRB( this Color v )
        {
            return new Color( v.b, v.r, v.r, v.b );
        }

        public static Color BRRA( this Color v )
        {
            return new Color( v.b, v.r, v.r, v.a );
        }

        public static Color BRR_( this Color v )
        {
            return new Color( v.b, v.r, v.r, 0f );
        }

        public static Color BRGR( this Color v )
        {
            return new Color( v.b, v.r, v.g, v.r );
        }

        public static Color BRGG( this Color v )
        {
            return new Color( v.b, v.r, v.g, v.g );
        }

        public static Color BRGB( this Color v )
        {
            return new Color( v.b, v.r, v.g, v.b );
        }

        public static Color BRGA( this Color v )
        {
            return new Color( v.b, v.r, v.g, v.a );
        }

        public static Color BRG_( this Color v )
        {
            return new Color( v.b, v.r, v.g, 0f );
        }

        public static Color BRBR( this Color v )
        {
            return new Color( v.b, v.r, v.b, v.r );
        }

        public static Color BRBG( this Color v )
        {
            return new Color( v.b, v.r, v.b, v.g );
        }

        public static Color BRBB( this Color v )
        {
            return new Color( v.b, v.r, v.b, v.b );
        }

        public static Color BRBA( this Color v )
        {
            return new Color( v.b, v.r, v.b, v.a );
        }

        public static Color BRB_( this Color v )
        {
            return new Color( v.b, v.r, v.b, 0f );
        }

        public static Color BRAR( this Color v )
        {
            return new Color( v.b, v.r, v.a, v.r );
        }

        public static Color BRAG( this Color v )
        {
            return new Color( v.b, v.r, v.a, v.g );
        }

        public static Color BRAB( this Color v )
        {
            return new Color( v.b, v.r, v.a, v.b );
        }

        public static Color BRAA( this Color v )
        {
            return new Color( v.b, v.r, v.a, v.a );
        }

        public static Color BRA_( this Color v )
        {
            return new Color( v.b, v.r, v.a, 0f );
        }

        public static Color BR_R( this Color v )
        {
            return new Color( v.b, v.r, 0f, v.r );
        }

        public static Color BR_G( this Color v )
        {
            return new Color( v.b, v.r, 0f, v.g );
        }

        public static Color BR_B( this Color v )
        {
            return new Color( v.b, v.r, 0f, v.b );
        }

        public static Color BR_A( this Color v )
        {
            return new Color( v.b, v.r, 0f, v.a );
        }

        public static Color BR__( this Color v )
        {
            return new Color( v.b, v.r, 0f, 0f );
        }

        public static Color BGRR( this Color v )
        {
            return new Color( v.b, v.g, v.r, v.r );
        }

        public static Color BGRG( this Color v )
        {
            return new Color( v.b, v.g, v.r, v.g );
        }

        public static Color BGRB( this Color v )
        {
            return new Color( v.b, v.g, v.r, v.b );
        }

        public static Color BGRA( this Color v )
        {
            return new Color( v.b, v.g, v.r, v.a );
        }

        public static Color BGR_( this Color v )
        {
            return new Color( v.b, v.g, v.r, 0f );
        }

        public static Color BGGR( this Color v )
        {
            return new Color( v.b, v.g, v.g, v.r );
        }

        public static Color BGGG( this Color v )
        {
            return new Color( v.b, v.g, v.g, v.g );
        }

        public static Color BGGB( this Color v )
        {
            return new Color( v.b, v.g, v.g, v.b );
        }

        public static Color BGGA( this Color v )
        {
            return new Color( v.b, v.g, v.g, v.a );
        }

        public static Color BGG_( this Color v )
        {
            return new Color( v.b, v.g, v.g, 0f );
        }

        public static Color BGBR( this Color v )
        {
            return new Color( v.b, v.g, v.b, v.r );
        }

        public static Color BGBG( this Color v )
        {
            return new Color( v.b, v.g, v.b, v.g );
        }

        public static Color BGBB( this Color v )
        {
            return new Color( v.b, v.g, v.b, v.b );
        }

        public static Color BGBA( this Color v )
        {
            return new Color( v.b, v.g, v.b, v.a );
        }

        public static Color BGB_( this Color v )
        {
            return new Color( v.b, v.g, v.b, 0f );
        }

        public static Color BGAR( this Color v )
        {
            return new Color( v.b, v.g, v.a, v.r );
        }

        public static Color BGAG( this Color v )
        {
            return new Color( v.b, v.g, v.a, v.g );
        }

        public static Color BGAB( this Color v )
        {
            return new Color( v.b, v.g, v.a, v.b );
        }

        public static Color BGAA( this Color v )
        {
            return new Color( v.b, v.g, v.a, v.a );
        }

        public static Color BGA_( this Color v )
        {
            return new Color( v.b, v.g, v.a, 0f );
        }

        public static Color BG_R( this Color v )
        {
            return new Color( v.b, v.g, 0f, v.r );
        }

        public static Color BG_G( this Color v )
        {
            return new Color( v.b, v.g, 0f, v.g );
        }

        public static Color BG_B( this Color v )
        {
            return new Color( v.b, v.g, 0f, v.b );
        }

        public static Color BG_A( this Color v )
        {
            return new Color( v.b, v.g, 0f, v.a );
        }

        public static Color BG__( this Color v )
        {
            return new Color( v.b, v.g, 0f, 0f );
        }

        public static Color BBRR( this Color v )
        {
            return new Color( v.b, v.b, v.r, v.r );
        }

        public static Color BBRG( this Color v )
        {
            return new Color( v.b, v.b, v.r, v.g );
        }

        public static Color BBRB( this Color v )
        {
            return new Color( v.b, v.b, v.r, v.b );
        }

        public static Color BBRA( this Color v )
        {
            return new Color( v.b, v.b, v.r, v.a );
        }

        public static Color BBR_( this Color v )
        {
            return new Color( v.b, v.b, v.r, 0f );
        }

        public static Color BBGR( this Color v )
        {
            return new Color( v.b, v.b, v.g, v.r );
        }

        public static Color BBGG( this Color v )
        {
            return new Color( v.b, v.b, v.g, v.g );
        }

        public static Color BBGB( this Color v )
        {
            return new Color( v.b, v.b, v.g, v.b );
        }

        public static Color BBGA( this Color v )
        {
            return new Color( v.b, v.b, v.g, v.a );
        }

        public static Color BBG_( this Color v )
        {
            return new Color( v.b, v.b, v.g, 0f );
        }

        public static Color BBBR( this Color v )
        {
            return new Color( v.b, v.b, v.b, v.r );
        }

        public static Color BBBG( this Color v )
        {
            return new Color( v.b, v.b, v.b, v.g );
        }

        public static Color BBBB( this Color v )
        {
            return new Color( v.b, v.b, v.b, v.b );
        }

        public static Color BBBA( this Color v )
        {
            return new Color( v.b, v.b, v.b, v.a );
        }

        public static Color BBB_( this Color v )
        {
            return new Color( v.b, v.b, v.b, 0f );
        }

        public static Color BBAR( this Color v )
        {
            return new Color( v.b, v.b, v.a, v.r );
        }

        public static Color BBAG( this Color v )
        {
            return new Color( v.b, v.b, v.a, v.g );
        }

        public static Color BBAB( this Color v )
        {
            return new Color( v.b, v.b, v.a, v.b );
        }

        public static Color BBAA( this Color v )
        {
            return new Color( v.b, v.b, v.a, v.a );
        }

        public static Color BBA_( this Color v )
        {
            return new Color( v.b, v.b, v.a, 0f );
        }

        public static Color BB_R( this Color v )
        {
            return new Color( v.b, v.b, 0f, v.r );
        }

        public static Color BB_G( this Color v )
        {
            return new Color( v.b, v.b, 0f, v.g );
        }

        public static Color BB_B( this Color v )
        {
            return new Color( v.b, v.b, 0f, v.b );
        }

        public static Color BB_A( this Color v )
        {
            return new Color( v.b, v.b, 0f, v.a );
        }

        public static Color BB__( this Color v )
        {
            return new Color( v.b, v.b, 0f, 0f );
        }

        public static Color BARR( this Color v )
        {
            return new Color( v.b, v.a, v.r, v.r );
        }

        public static Color BARG( this Color v )
        {
            return new Color( v.b, v.a, v.r, v.g );
        }

        public static Color BARB( this Color v )
        {
            return new Color( v.b, v.a, v.r, v.b );
        }

        public static Color BARA( this Color v )
        {
            return new Color( v.b, v.a, v.r, v.a );
        }

        public static Color BAR_( this Color v )
        {
            return new Color( v.b, v.a, v.r, 0f );
        }

        public static Color BAGR( this Color v )
        {
            return new Color( v.b, v.a, v.g, v.r );
        }

        public static Color BAGG( this Color v )
        {
            return new Color( v.b, v.a, v.g, v.g );
        }

        public static Color BAGB( this Color v )
        {
            return new Color( v.b, v.a, v.g, v.b );
        }

        public static Color BAGA( this Color v )
        {
            return new Color( v.b, v.a, v.g, v.a );
        }

        public static Color BAG_( this Color v )
        {
            return new Color( v.b, v.a, v.g, 0f );
        }

        public static Color BABR( this Color v )
        {
            return new Color( v.b, v.a, v.b, v.r );
        }

        public static Color BABG( this Color v )
        {
            return new Color( v.b, v.a, v.b, v.g );
        }

        public static Color BABB( this Color v )
        {
            return new Color( v.b, v.a, v.b, v.b );
        }

        public static Color BABA( this Color v )
        {
            return new Color( v.b, v.a, v.b, v.a );
        }

        public static Color BAB_( this Color v )
        {
            return new Color( v.b, v.a, v.b, 0f );
        }

        public static Color BAAR( this Color v )
        {
            return new Color( v.b, v.a, v.a, v.r );
        }

        public static Color BAAG( this Color v )
        {
            return new Color( v.b, v.a, v.a, v.g );
        }

        public static Color BAAB( this Color v )
        {
            return new Color( v.b, v.a, v.a, v.b );
        }

        public static Color BAAA( this Color v )
        {
            return new Color( v.b, v.a, v.a, v.a );
        }

        public static Color BAA_( this Color v )
        {
            return new Color( v.b, v.a, v.a, 0f );
        }

        public static Color BA_R( this Color v )
        {
            return new Color( v.b, v.a, 0f, v.r );
        }

        public static Color BA_G( this Color v )
        {
            return new Color( v.b, v.a, 0f, v.g );
        }

        public static Color BA_B( this Color v )
        {
            return new Color( v.b, v.a, 0f, v.b );
        }

        public static Color BA_A( this Color v )
        {
            return new Color( v.b, v.a, 0f, v.a );
        }

        public static Color BA__( this Color v )
        {
            return new Color( v.b, v.a, 0f, 0f );
        }

        public static Color B_RR( this Color v )
        {
            return new Color( v.b, 0f, v.r, v.r );
        }

        public static Color B_RG( this Color v )
        {
            return new Color( v.b, 0f, v.r, v.g );
        }

        public static Color B_RB( this Color v )
        {
            return new Color( v.b, 0f, v.r, v.b );
        }

        public static Color B_RA( this Color v )
        {
            return new Color( v.b, 0f, v.r, v.a );
        }

        public static Color B_R_( this Color v )
        {
            return new Color( v.b, 0f, v.r, 0f );
        }

        public static Color B_GR( this Color v )
        {
            return new Color( v.b, 0f, v.g, v.r );
        }

        public static Color B_GG( this Color v )
        {
            return new Color( v.b, 0f, v.g, v.g );
        }

        public static Color B_GB( this Color v )
        {
            return new Color( v.b, 0f, v.g, v.b );
        }

        public static Color B_GA( this Color v )
        {
            return new Color( v.b, 0f, v.g, v.a );
        }

        public static Color B_G_( this Color v )
        {
            return new Color( v.b, 0f, v.g, 0f );
        }

        public static Color B_BR( this Color v )
        {
            return new Color( v.b, 0f, v.b, v.r );
        }

        public static Color B_BG( this Color v )
        {
            return new Color( v.b, 0f, v.b, v.g );
        }

        public static Color B_BB( this Color v )
        {
            return new Color( v.b, 0f, v.b, v.b );
        }

        public static Color B_BA( this Color v )
        {
            return new Color( v.b, 0f, v.b, v.a );
        }

        public static Color B_B_( this Color v )
        {
            return new Color( v.b, 0f, v.b, 0f );
        }

        public static Color B_AR( this Color v )
        {
            return new Color( v.b, 0f, v.a, v.r );
        }

        public static Color B_AG( this Color v )
        {
            return new Color( v.b, 0f, v.a, v.g );
        }

        public static Color B_AB( this Color v )
        {
            return new Color( v.b, 0f, v.a, v.b );
        }

        public static Color B_AA( this Color v )
        {
            return new Color( v.b, 0f, v.a, v.a );
        }

        public static Color B_A_( this Color v )
        {
            return new Color( v.b, 0f, v.a, 0f );
        }

        public static Color B__R( this Color v )
        {
            return new Color( v.b, 0f, 0f, v.r );
        }

        public static Color B__G( this Color v )
        {
            return new Color( v.b, 0f, 0f, v.g );
        }

        public static Color B__B( this Color v )
        {
            return new Color( v.b, 0f, 0f, v.b );
        }

        public static Color B__A( this Color v )
        {
            return new Color( v.b, 0f, 0f, v.a );
        }

        public static Color B___( this Color v )
        {
            return new Color( v.b, 0f, 0f, 0f );
        }

        public static Color ARRR( this Color v )
        {
            return new Color( v.a, v.r, v.r, v.r );
        }

        public static Color ARRG( this Color v )
        {
            return new Color( v.a, v.r, v.r, v.g );
        }

        public static Color ARRB( this Color v )
        {
            return new Color( v.a, v.r, v.r, v.b );
        }

        public static Color ARRA( this Color v )
        {
            return new Color( v.a, v.r, v.r, v.a );
        }

        public static Color ARR_( this Color v )
        {
            return new Color( v.a, v.r, v.r, 0f );
        }

        public static Color ARGR( this Color v )
        {
            return new Color( v.a, v.r, v.g, v.r );
        }

        public static Color ARGG( this Color v )
        {
            return new Color( v.a, v.r, v.g, v.g );
        }

        public static Color ARGB( this Color v )
        {
            return new Color( v.a, v.r, v.g, v.b );
        }

        public static Color ARGA( this Color v )
        {
            return new Color( v.a, v.r, v.g, v.a );
        }

        public static Color ARG_( this Color v )
        {
            return new Color( v.a, v.r, v.g, 0f );
        }

        public static Color ARBR( this Color v )
        {
            return new Color( v.a, v.r, v.b, v.r );
        }

        public static Color ARBG( this Color v )
        {
            return new Color( v.a, v.r, v.b, v.g );
        }

        public static Color ARBB( this Color v )
        {
            return new Color( v.a, v.r, v.b, v.b );
        }

        public static Color ARBA( this Color v )
        {
            return new Color( v.a, v.r, v.b, v.a );
        }

        public static Color ARB_( this Color v )
        {
            return new Color( v.a, v.r, v.b, 0f );
        }

        public static Color ARAR( this Color v )
        {
            return new Color( v.a, v.r, v.a, v.r );
        }

        public static Color ARAG( this Color v )
        {
            return new Color( v.a, v.r, v.a, v.g );
        }

        public static Color ARAB( this Color v )
        {
            return new Color( v.a, v.r, v.a, v.b );
        }

        public static Color ARAA( this Color v )
        {
            return new Color( v.a, v.r, v.a, v.a );
        }

        public static Color ARA_( this Color v )
        {
            return new Color( v.a, v.r, v.a, 0f );
        }

        public static Color AR_R( this Color v )
        {
            return new Color( v.a, v.r, 0f, v.r );
        }

        public static Color AR_G( this Color v )
        {
            return new Color( v.a, v.r, 0f, v.g );
        }

        public static Color AR_B( this Color v )
        {
            return new Color( v.a, v.r, 0f, v.b );
        }

        public static Color AR_A( this Color v )
        {
            return new Color( v.a, v.r, 0f, v.a );
        }

        public static Color AR__( this Color v )
        {
            return new Color( v.a, v.r, 0f, 0f );
        }

        public static Color AGRR( this Color v )
        {
            return new Color( v.a, v.g, v.r, v.r );
        }

        public static Color AGRG( this Color v )
        {
            return new Color( v.a, v.g, v.r, v.g );
        }

        public static Color AGRB( this Color v )
        {
            return new Color( v.a, v.g, v.r, v.b );
        }

        public static Color AGRA( this Color v )
        {
            return new Color( v.a, v.g, v.r, v.a );
        }

        public static Color AGR_( this Color v )
        {
            return new Color( v.a, v.g, v.r, 0f );
        }

        public static Color AGGR( this Color v )
        {
            return new Color( v.a, v.g, v.g, v.r );
        }

        public static Color AGGG( this Color v )
        {
            return new Color( v.a, v.g, v.g, v.g );
        }

        public static Color AGGB( this Color v )
        {
            return new Color( v.a, v.g, v.g, v.b );
        }

        public static Color AGGA( this Color v )
        {
            return new Color( v.a, v.g, v.g, v.a );
        }

        public static Color AGG_( this Color v )
        {
            return new Color( v.a, v.g, v.g, 0f );
        }

        public static Color AGBR( this Color v )
        {
            return new Color( v.a, v.g, v.b, v.r );
        }

        public static Color AGBG( this Color v )
        {
            return new Color( v.a, v.g, v.b, v.g );
        }

        public static Color AGBB( this Color v )
        {
            return new Color( v.a, v.g, v.b, v.b );
        }

        public static Color AGBA( this Color v )
        {
            return new Color( v.a, v.g, v.b, v.a );
        }

        public static Color AGB_( this Color v )
        {
            return new Color( v.a, v.g, v.b, 0f );
        }

        public static Color AGAR( this Color v )
        {
            return new Color( v.a, v.g, v.a, v.r );
        }

        public static Color AGAG( this Color v )
        {
            return new Color( v.a, v.g, v.a, v.g );
        }

        public static Color AGAB( this Color v )
        {
            return new Color( v.a, v.g, v.a, v.b );
        }

        public static Color AGAA( this Color v )
        {
            return new Color( v.a, v.g, v.a, v.a );
        }

        public static Color AGA_( this Color v )
        {
            return new Color( v.a, v.g, v.a, 0f );
        }

        public static Color AG_R( this Color v )
        {
            return new Color( v.a, v.g, 0f, v.r );
        }

        public static Color AG_G( this Color v )
        {
            return new Color( v.a, v.g, 0f, v.g );
        }

        public static Color AG_B( this Color v )
        {
            return new Color( v.a, v.g, 0f, v.b );
        }

        public static Color AG_A( this Color v )
        {
            return new Color( v.a, v.g, 0f, v.a );
        }

        public static Color AG__( this Color v )
        {
            return new Color( v.a, v.g, 0f, 0f );
        }

        public static Color ABRR( this Color v )
        {
            return new Color( v.a, v.b, v.r, v.r );
        }

        public static Color ABRG( this Color v )
        {
            return new Color( v.a, v.b, v.r, v.g );
        }

        public static Color ABRB( this Color v )
        {
            return new Color( v.a, v.b, v.r, v.b );
        }

        public static Color ABRA( this Color v )
        {
            return new Color( v.a, v.b, v.r, v.a );
        }

        public static Color ABR_( this Color v )
        {
            return new Color( v.a, v.b, v.r, 0f );
        }

        public static Color ABGR( this Color v )
        {
            return new Color( v.a, v.b, v.g, v.r );
        }

        public static Color ABGG( this Color v )
        {
            return new Color( v.a, v.b, v.g, v.g );
        }

        public static Color ABGB( this Color v )
        {
            return new Color( v.a, v.b, v.g, v.b );
        }

        public static Color ABGA( this Color v )
        {
            return new Color( v.a, v.b, v.g, v.a );
        }

        public static Color ABG_( this Color v )
        {
            return new Color( v.a, v.b, v.g, 0f );
        }

        public static Color ABBR( this Color v )
        {
            return new Color( v.a, v.b, v.b, v.r );
        }

        public static Color ABBG( this Color v )
        {
            return new Color( v.a, v.b, v.b, v.g );
        }

        public static Color ABBB( this Color v )
        {
            return new Color( v.a, v.b, v.b, v.b );
        }

        public static Color ABBA( this Color v )
        {
            return new Color( v.a, v.b, v.b, v.a );
        }

        public static Color ABB_( this Color v )
        {
            return new Color( v.a, v.b, v.b, 0f );
        }

        public static Color ABAR( this Color v )
        {
            return new Color( v.a, v.b, v.a, v.r );
        }

        public static Color ABAG( this Color v )
        {
            return new Color( v.a, v.b, v.a, v.g );
        }

        public static Color ABAB( this Color v )
        {
            return new Color( v.a, v.b, v.a, v.b );
        }

        public static Color ABAA( this Color v )
        {
            return new Color( v.a, v.b, v.a, v.a );
        }

        public static Color ABA_( this Color v )
        {
            return new Color( v.a, v.b, v.a, 0f );
        }

        public static Color AB_R( this Color v )
        {
            return new Color( v.a, v.b, 0f, v.r );
        }

        public static Color AB_G( this Color v )
        {
            return new Color( v.a, v.b, 0f, v.g );
        }

        public static Color AB_B( this Color v )
        {
            return new Color( v.a, v.b, 0f, v.b );
        }

        public static Color AB_A( this Color v )
        {
            return new Color( v.a, v.b, 0f, v.a );
        }

        public static Color AB__( this Color v )
        {
            return new Color( v.a, v.b, 0f, 0f );
        }

        public static Color AARR( this Color v )
        {
            return new Color( v.a, v.a, v.r, v.r );
        }

        public static Color AARG( this Color v )
        {
            return new Color( v.a, v.a, v.r, v.g );
        }

        public static Color AARB( this Color v )
        {
            return new Color( v.a, v.a, v.r, v.b );
        }

        public static Color AARA( this Color v )
        {
            return new Color( v.a, v.a, v.r, v.a );
        }

        public static Color AAR_( this Color v )
        {
            return new Color( v.a, v.a, v.r, 0f );
        }

        public static Color AAGR( this Color v )
        {
            return new Color( v.a, v.a, v.g, v.r );
        }

        public static Color AAGG( this Color v )
        {
            return new Color( v.a, v.a, v.g, v.g );
        }

        public static Color AAGB( this Color v )
        {
            return new Color( v.a, v.a, v.g, v.b );
        }

        public static Color AAGA( this Color v )
        {
            return new Color( v.a, v.a, v.g, v.a );
        }

        public static Color AAG_( this Color v )
        {
            return new Color( v.a, v.a, v.g, 0f );
        }

        public static Color AABR( this Color v )
        {
            return new Color( v.a, v.a, v.b, v.r );
        }

        public static Color AABG( this Color v )
        {
            return new Color( v.a, v.a, v.b, v.g );
        }

        public static Color AABB( this Color v )
        {
            return new Color( v.a, v.a, v.b, v.b );
        }

        public static Color AABA( this Color v )
        {
            return new Color( v.a, v.a, v.b, v.a );
        }

        public static Color AAB_( this Color v )
        {
            return new Color( v.a, v.a, v.b, 0f );
        }

        public static Color AAAR( this Color v )
        {
            return new Color( v.a, v.a, v.a, v.r );
        }

        public static Color AAAG( this Color v )
        {
            return new Color( v.a, v.a, v.a, v.g );
        }

        public static Color AAAB( this Color v )
        {
            return new Color( v.a, v.a, v.a, v.b );
        }

        public static Color AAAA( this Color v )
        {
            return new Color( v.a, v.a, v.a, v.a );
        }

        public static Color AAA_( this Color v )
        {
            return new Color( v.a, v.a, v.a, 0f );
        }

        public static Color AA_R( this Color v )
        {
            return new Color( v.a, v.a, 0f, v.r );
        }

        public static Color AA_G( this Color v )
        {
            return new Color( v.a, v.a, 0f, v.g );
        }

        public static Color AA_B( this Color v )
        {
            return new Color( v.a, v.a, 0f, v.b );
        }

        public static Color AA_A( this Color v )
        {
            return new Color( v.a, v.a, 0f, v.a );
        }

        public static Color AA__( this Color v )
        {
            return new Color( v.a, v.a, 0f, 0f );
        }

        public static Color A_RR( this Color v )
        {
            return new Color( v.a, 0f, v.r, v.r );
        }

        public static Color A_RG( this Color v )
        {
            return new Color( v.a, 0f, v.r, v.g );
        }

        public static Color A_RB( this Color v )
        {
            return new Color( v.a, 0f, v.r, v.b );
        }

        public static Color A_RA( this Color v )
        {
            return new Color( v.a, 0f, v.r, v.a );
        }

        public static Color A_R_( this Color v )
        {
            return new Color( v.a, 0f, v.r, 0f );
        }

        public static Color A_GR( this Color v )
        {
            return new Color( v.a, 0f, v.g, v.r );
        }

        public static Color A_GG( this Color v )
        {
            return new Color( v.a, 0f, v.g, v.g );
        }

        public static Color A_GB( this Color v )
        {
            return new Color( v.a, 0f, v.g, v.b );
        }

        public static Color A_GA( this Color v )
        {
            return new Color( v.a, 0f, v.g, v.a );
        }

        public static Color A_G_( this Color v )
        {
            return new Color( v.a, 0f, v.g, 0f );
        }

        public static Color A_BR( this Color v )
        {
            return new Color( v.a, 0f, v.b, v.r );
        }

        public static Color A_BG( this Color v )
        {
            return new Color( v.a, 0f, v.b, v.g );
        }

        public static Color A_BB( this Color v )
        {
            return new Color( v.a, 0f, v.b, v.b );
        }

        public static Color A_BA( this Color v )
        {
            return new Color( v.a, 0f, v.b, v.a );
        }

        public static Color A_B_( this Color v )
        {
            return new Color( v.a, 0f, v.b, 0f );
        }

        public static Color A_AR( this Color v )
        {
            return new Color( v.a, 0f, v.a, v.r );
        }

        public static Color A_AG( this Color v )
        {
            return new Color( v.a, 0f, v.a, v.g );
        }

        public static Color A_AB( this Color v )
        {
            return new Color( v.a, 0f, v.a, v.b );
        }

        public static Color A_AA( this Color v )
        {
            return new Color( v.a, 0f, v.a, v.a );
        }

        public static Color A_A_( this Color v )
        {
            return new Color( v.a, 0f, v.a, 0f );
        }

        public static Color A__R( this Color v )
        {
            return new Color( v.a, 0f, 0f, v.r );
        }

        public static Color A__G( this Color v )
        {
            return new Color( v.a, 0f, 0f, v.g );
        }

        public static Color A__B( this Color v )
        {
            return new Color( v.a, 0f, 0f, v.b );
        }

        public static Color A__A( this Color v )
        {
            return new Color( v.a, 0f, 0f, v.a );
        }

        public static Color A___( this Color v )
        {
            return new Color( v.a, 0f, 0f, 0f );
        }

        public static Color _RRR( this Color v )
        {
            return new Color( 0f, v.r, v.r, v.r );
        }

        public static Color _RRG( this Color v )
        {
            return new Color( 0f, v.r, v.r, v.g );
        }

        public static Color _RRB( this Color v )
        {
            return new Color( 0f, v.r, v.r, v.b );
        }

        public static Color _RRA( this Color v )
        {
            return new Color( 0f, v.r, v.r, v.a );
        }

        public static Color _RR_( this Color v )
        {
            return new Color( 0f, v.r, v.r, 0f );
        }

        public static Color _RGR( this Color v )
        {
            return new Color( 0f, v.r, v.g, v.r );
        }

        public static Color _RGG( this Color v )
        {
            return new Color( 0f, v.r, v.g, v.g );
        }

        public static Color _RGB( this Color v )
        {
            return new Color( 0f, v.r, v.g, v.b );
        }

        public static Color _RGA( this Color v )
        {
            return new Color( 0f, v.r, v.g, v.a );
        }

        public static Color _RG_( this Color v )
        {
            return new Color( 0f, v.r, v.g, 0f );
        }

        public static Color _RBR( this Color v )
        {
            return new Color( 0f, v.r, v.b, v.r );
        }

        public static Color _RBG( this Color v )
        {
            return new Color( 0f, v.r, v.b, v.g );
        }

        public static Color _RBB( this Color v )
        {
            return new Color( 0f, v.r, v.b, v.b );
        }

        public static Color _RBA( this Color v )
        {
            return new Color( 0f, v.r, v.b, v.a );
        }

        public static Color _RB_( this Color v )
        {
            return new Color( 0f, v.r, v.b, 0f );
        }

        public static Color _RAR( this Color v )
        {
            return new Color( 0f, v.r, v.a, v.r );
        }

        public static Color _RAG( this Color v )
        {
            return new Color( 0f, v.r, v.a, v.g );
        }

        public static Color _RAB( this Color v )
        {
            return new Color( 0f, v.r, v.a, v.b );
        }

        public static Color _RAA( this Color v )
        {
            return new Color( 0f, v.r, v.a, v.a );
        }

        public static Color _RA_( this Color v )
        {
            return new Color( 0f, v.r, v.a, 0f );
        }

        public static Color _R_R( this Color v )
        {
            return new Color( 0f, v.r, 0f, v.r );
        }

        public static Color _R_G( this Color v )
        {
            return new Color( 0f, v.r, 0f, v.g );
        }

        public static Color _R_B( this Color v )
        {
            return new Color( 0f, v.r, 0f, v.b );
        }

        public static Color _R_A( this Color v )
        {
            return new Color( 0f, v.r, 0f, v.a );
        }

        public static Color _R__( this Color v )
        {
            return new Color( 0f, v.r, 0f, 0f );
        }

        public static Color _GRR( this Color v )
        {
            return new Color( 0f, v.g, v.r, v.r );
        }

        public static Color _GRG( this Color v )
        {
            return new Color( 0f, v.g, v.r, v.g );
        }

        public static Color _GRB( this Color v )
        {
            return new Color( 0f, v.g, v.r, v.b );
        }

        public static Color _GRA( this Color v )
        {
            return new Color( 0f, v.g, v.r, v.a );
        }

        public static Color _GR_( this Color v )
        {
            return new Color( 0f, v.g, v.r, 0f );
        }

        public static Color _GGR( this Color v )
        {
            return new Color( 0f, v.g, v.g, v.r );
        }

        public static Color _GGG( this Color v )
        {
            return new Color( 0f, v.g, v.g, v.g );
        }

        public static Color _GGB( this Color v )
        {
            return new Color( 0f, v.g, v.g, v.b );
        }

        public static Color _GGA( this Color v )
        {
            return new Color( 0f, v.g, v.g, v.a );
        }

        public static Color _GG_( this Color v )
        {
            return new Color( 0f, v.g, v.g, 0f );
        }

        public static Color _GBR( this Color v )
        {
            return new Color( 0f, v.g, v.b, v.r );
        }

        public static Color _GBG( this Color v )
        {
            return new Color( 0f, v.g, v.b, v.g );
        }

        public static Color _GBB( this Color v )
        {
            return new Color( 0f, v.g, v.b, v.b );
        }

        public static Color _GBA( this Color v )
        {
            return new Color( 0f, v.g, v.b, v.a );
        }

        public static Color _GB_( this Color v )
        {
            return new Color( 0f, v.g, v.b, 0f );
        }

        public static Color _GAR( this Color v )
        {
            return new Color( 0f, v.g, v.a, v.r );
        }

        public static Color _GAG( this Color v )
        {
            return new Color( 0f, v.g, v.a, v.g );
        }

        public static Color _GAB( this Color v )
        {
            return new Color( 0f, v.g, v.a, v.b );
        }

        public static Color _GAA( this Color v )
        {
            return new Color( 0f, v.g, v.a, v.a );
        }

        public static Color _GA_( this Color v )
        {
            return new Color( 0f, v.g, v.a, 0f );
        }

        public static Color _G_R( this Color v )
        {
            return new Color( 0f, v.g, 0f, v.r );
        }

        public static Color _G_G( this Color v )
        {
            return new Color( 0f, v.g, 0f, v.g );
        }

        public static Color _G_B( this Color v )
        {
            return new Color( 0f, v.g, 0f, v.b );
        }

        public static Color _G_A( this Color v )
        {
            return new Color( 0f, v.g, 0f, v.a );
        }

        public static Color _G__( this Color v )
        {
            return new Color( 0f, v.g, 0f, 0f );
        }

        public static Color _BRR( this Color v )
        {
            return new Color( 0f, v.b, v.r, v.r );
        }

        public static Color _BRG( this Color v )
        {
            return new Color( 0f, v.b, v.r, v.g );
        }

        public static Color _BRB( this Color v )
        {
            return new Color( 0f, v.b, v.r, v.b );
        }

        public static Color _BRA( this Color v )
        {
            return new Color( 0f, v.b, v.r, v.a );
        }

        public static Color _BR_( this Color v )
        {
            return new Color( 0f, v.b, v.r, 0f );
        }

        public static Color _BGR( this Color v )
        {
            return new Color( 0f, v.b, v.g, v.r );
        }

        public static Color _BGG( this Color v )
        {
            return new Color( 0f, v.b, v.g, v.g );
        }

        public static Color _BGB( this Color v )
        {
            return new Color( 0f, v.b, v.g, v.b );
        }

        public static Color _BGA( this Color v )
        {
            return new Color( 0f, v.b, v.g, v.a );
        }

        public static Color _BG_( this Color v )
        {
            return new Color( 0f, v.b, v.g, 0f );
        }

        public static Color _BBR( this Color v )
        {
            return new Color( 0f, v.b, v.b, v.r );
        }

        public static Color _BBG( this Color v )
        {
            return new Color( 0f, v.b, v.b, v.g );
        }

        public static Color _BBB( this Color v )
        {
            return new Color( 0f, v.b, v.b, v.b );
        }

        public static Color _BBA( this Color v )
        {
            return new Color( 0f, v.b, v.b, v.a );
        }

        public static Color _BB_( this Color v )
        {
            return new Color( 0f, v.b, v.b, 0f );
        }

        public static Color _BAR( this Color v )
        {
            return new Color( 0f, v.b, v.a, v.r );
        }

        public static Color _BAG( this Color v )
        {
            return new Color( 0f, v.b, v.a, v.g );
        }

        public static Color _BAB( this Color v )
        {
            return new Color( 0f, v.b, v.a, v.b );
        }

        public static Color _BAA( this Color v )
        {
            return new Color( 0f, v.b, v.a, v.a );
        }

        public static Color _BA_( this Color v )
        {
            return new Color( 0f, v.b, v.a, 0f );
        }

        public static Color _B_R( this Color v )
        {
            return new Color( 0f, v.b, 0f, v.r );
        }

        public static Color _B_G( this Color v )
        {
            return new Color( 0f, v.b, 0f, v.g );
        }

        public static Color _B_B( this Color v )
        {
            return new Color( 0f, v.b, 0f, v.b );
        }

        public static Color _B_A( this Color v )
        {
            return new Color( 0f, v.b, 0f, v.a );
        }

        public static Color _B__( this Color v )
        {
            return new Color( 0f, v.b, 0f, 0f );
        }

        public static Color _ARR( this Color v )
        {
            return new Color( 0f, v.a, v.r, v.r );
        }

        public static Color _ARG( this Color v )
        {
            return new Color( 0f, v.a, v.r, v.g );
        }

        public static Color _ARB( this Color v )
        {
            return new Color( 0f, v.a, v.r, v.b );
        }

        public static Color _ARA( this Color v )
        {
            return new Color( 0f, v.a, v.r, v.a );
        }

        public static Color _AR_( this Color v )
        {
            return new Color( 0f, v.a, v.r, 0f );
        }

        public static Color _AGR( this Color v )
        {
            return new Color( 0f, v.a, v.g, v.r );
        }

        public static Color _AGG( this Color v )
        {
            return new Color( 0f, v.a, v.g, v.g );
        }

        public static Color _AGB( this Color v )
        {
            return new Color( 0f, v.a, v.g, v.b );
        }

        public static Color _AGA( this Color v )
        {
            return new Color( 0f, v.a, v.g, v.a );
        }

        public static Color _AG_( this Color v )
        {
            return new Color( 0f, v.a, v.g, 0f );
        }

        public static Color _ABR( this Color v )
        {
            return new Color( 0f, v.a, v.b, v.r );
        }

        public static Color _ABG( this Color v )
        {
            return new Color( 0f, v.a, v.b, v.g );
        }

        public static Color _ABB( this Color v )
        {
            return new Color( 0f, v.a, v.b, v.b );
        }

        public static Color _ABA( this Color v )
        {
            return new Color( 0f, v.a, v.b, v.a );
        }

        public static Color _AB_( this Color v )
        {
            return new Color( 0f, v.a, v.b, 0f );
        }

        public static Color _AAR( this Color v )
        {
            return new Color( 0f, v.a, v.a, v.r );
        }

        public static Color _AAG( this Color v )
        {
            return new Color( 0f, v.a, v.a, v.g );
        }

        public static Color _AAB( this Color v )
        {
            return new Color( 0f, v.a, v.a, v.b );
        }

        public static Color _AAA( this Color v )
        {
            return new Color( 0f, v.a, v.a, v.a );
        }

        public static Color _AA_( this Color v )
        {
            return new Color( 0f, v.a, v.a, 0f );
        }

        public static Color _A_R( this Color v )
        {
            return new Color( 0f, v.a, 0f, v.r );
        }

        public static Color _A_G( this Color v )
        {
            return new Color( 0f, v.a, 0f, v.g );
        }

        public static Color _A_B( this Color v )
        {
            return new Color( 0f, v.a, 0f, v.b );
        }

        public static Color _A_A( this Color v )
        {
            return new Color( 0f, v.a, 0f, v.a );
        }

        public static Color _A__( this Color v )
        {
            return new Color( 0f, v.a, 0f, 0f );
        }

        public static Color __RR( this Color v )
        {
            return new Color( 0f, 0f, v.r, v.r );
        }

        public static Color __RG( this Color v )
        {
            return new Color( 0f, 0f, v.r, v.g );
        }

        public static Color __RB( this Color v )
        {
            return new Color( 0f, 0f, v.r, v.b );
        }

        public static Color __RA( this Color v )
        {
            return new Color( 0f, 0f, v.r, v.a );
        }

        public static Color __R_( this Color v )
        {
            return new Color( 0f, 0f, v.r, 0f );
        }

        public static Color __GR( this Color v )
        {
            return new Color( 0f, 0f, v.g, v.r );
        }

        public static Color __GG( this Color v )
        {
            return new Color( 0f, 0f, v.g, v.g );
        }

        public static Color __GB( this Color v )
        {
            return new Color( 0f, 0f, v.g, v.b );
        }

        public static Color __GA( this Color v )
        {
            return new Color( 0f, 0f, v.g, v.a );
        }

        public static Color __G_( this Color v )
        {
            return new Color( 0f, 0f, v.g, 0f );
        }

        public static Color __BR( this Color v )
        {
            return new Color( 0f, 0f, v.b, v.r );
        }

        public static Color __BG( this Color v )
        {
            return new Color( 0f, 0f, v.b, v.g );
        }

        public static Color __BB( this Color v )
        {
            return new Color( 0f, 0f, v.b, v.b );
        }

        public static Color __BA( this Color v )
        {
            return new Color( 0f, 0f, v.b, v.a );
        }

        public static Color __B_( this Color v )
        {
            return new Color( 0f, 0f, v.b, 0f );
        }

        public static Color __AR( this Color v )
        {
            return new Color( 0f, 0f, v.a, v.r );
        }

        public static Color __AG( this Color v )
        {
            return new Color( 0f, 0f, v.a, v.g );
        }

        public static Color __AB( this Color v )
        {
            return new Color( 0f, 0f, v.a, v.b );
        }

        public static Color __AA( this Color v )
        {
            return new Color( 0f, 0f, v.a, v.a );
        }

        public static Color __A_( this Color v )
        {
            return new Color( 0f, 0f, v.a, 0f );
        }

        public static Color ___R( this Color v )
        {
            return new Color( 0f, 0f, 0f, v.r );
        }

        public static Color ___G( this Color v )
        {
            return new Color( 0f, 0f, 0f, v.g );
        }

        public static Color ___B( this Color v )
        {
            return new Color( 0f, 0f, 0f, v.b );
        }

        public static Color ___A( this Color v )
        {
            return new Color( 0f, 0f, 0f, v.a );
        }
        #endregion Color.RRRR

    }
}
