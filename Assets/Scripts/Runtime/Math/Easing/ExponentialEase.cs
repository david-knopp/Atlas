using UnityEngine;

namespace Atlas
{
    // Adapted from Robert Penner's easing functions (http://robertpenner.com/easing/)
    public static class ExponentialEase
    {
        public static float In( float curTime, float duration )
        {
            if ( curTime == 0.0f )
            {
                return 0.0f;
            }
            else
            {
                return Mathf.Pow( 2.0f, 10.0f * ( curTime / duration - 1 ) );
            }
        }

        public static float Out( float curTime, float duration )
        {
            if ( curTime == duration )
            {
                return 1.0f;
            }
            else
            {
                return -Mathf.Pow( 2.0f, -10.0f * ( curTime / duration ) ) + 1.0f;
            }
        }

        public static float InOut( float curTime, float duration )
        {
            if ( curTime == 0.0f )
            {
                return 0.0f;
            }
            else if ( curTime == duration )
            {
                return 1.0f;
            }

            curTime /= duration / 2.0f;
            if ( curTime < 1.0f )
            {
                return 1.0f / 2.0f * Mathf.Pow( 2.0f, 10.0f * ( curTime - 1.0f ) );
            }
            
            return 1.0f / 2.0f * ( -Mathf.Pow( 2.0f, -10.0f * ( curTime - 1.0f ) ) + 2.0f );
        }
    }
}