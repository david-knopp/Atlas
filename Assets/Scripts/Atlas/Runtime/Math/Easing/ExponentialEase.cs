using UnityEngine;

namespace Atlas
{
    // Adapted from Robert Penner's easing functions (http://robertpenner.com/easing/)
    public static class ExponentialEase
    {
        public static float In( float t, float start, float delta, float duration )
        {
            if ( t == 0.0f )
            {
                return start;
            }
            else
            {
                return delta * Mathf.Pow( 2.0f, 10.0f * ( t / duration - 1 ) ) + start;
            }
        }

        public static float Out( float t, float start, float delta, float duration )
        {
            if ( t == duration )
            {
                return start + delta;
            }
            else
            {
                // c * (-pow(2, -10 * t/d) + 1) + b
                return delta * ( -Mathf.Pow( 2.0f, -10.0f * ( t / duration ) ) + 1.0f ) + start;
            }
        }

        public static float InOut( float t, float start, float delta, float duration )
        {
            if ( t == 0.0f )
            {
                return start;
            }
            else if ( t == duration )
            {
                return start + delta;
            }

            t /= duration / 2.0f;
            if ( t < 1.0f )
            {
                return delta / 2.0f * Mathf.Pow( 2.0f, 10.0f * ( t - 1.0f ) ) + start;
            }
            
            return delta / 2.0f * ( -Mathf.Pow( 2.0f, -10.0f * ( t - 1.0f ) ) + 2.0f ) + start;
        }
    }
}