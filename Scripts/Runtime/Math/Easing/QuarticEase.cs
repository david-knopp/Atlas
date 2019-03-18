using UnityEngine;

namespace Atlas
{
    // Adapted from Robert Penner's easing functions (http://robertpenner.com/easing/)
    public static class QuarticEase
    {
        public static float In( float curTime, float duration )
        {
            float t = curTime / duration;
            return t * t * t * t;
        }

        public static float Out( float curTime, float duration )
        {
            float t = curTime / duration - 1.0f;
            return -1.0f * ( t * t * t * t - 1.0f );
        }

        public static float InOut( float curTime, float duration )
        {
            float t = curTime / ( duration / 2.0f );

            if ( t < 1.0f )
            {
                return 0.5f * t * t * t * t;
            }

            t -= 2.0f;
            return -0.5f * ( t * t * t * t - 2.0f );
        }
    }
}
