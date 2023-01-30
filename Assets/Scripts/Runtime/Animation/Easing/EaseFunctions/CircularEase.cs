using UnityEngine;

namespace Atlas
{
    // Adapted from Robert Penner's easing functions (http://robertpenner.com/easing/)
    public static class CircularEase
    {
        public static float In( float curTime, float duration )
        {
            float t = curTime / duration;
            return -1.0f * ( Mathf.Sqrt( 1.0f - t * t ) - 1.0f );
        }

        public static float Out( float curTime, float duration )
        {
            float t = curTime / duration - 1.0f;
            return Mathf.Sqrt( 1.0f - t * t );
        }

        public static float InOut( float curTime, float duration )
        {
            float t = curTime / ( duration / 2.0f );
            if ( t < 1 )
            {
                return -0.5f * ( Mathf.Sqrt( 1.0f - t * t ) - 1.0f );
            }

            t -= 2.0f;
            return 0.5f * ( Mathf.Sqrt( 1.0f - t * t ) + 1.0f );
        }
    }
}
