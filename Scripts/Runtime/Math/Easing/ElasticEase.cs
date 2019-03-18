using UnityEngine;

namespace Atlas
{
    // Adapted from Robert Penner's easing functions (http://robertpenner.com/easing/)
    public static class ElasticEase
    {
        public static float In( float curTime, float duration )
        {
            if ( curTime == 0.0f )
            {
                return 0.0f;
            }

            float t = curTime / duration;
            if ( t == 1.0f )
            {
                return 1.0f;
            }

            float p = duration * 0.3f;
            float s = p / 4.0f;
            t -= 1.0f;
            float postFix = Mathf.Pow( 2.0f, 10.0f * t );

            return -1.0f * ( postFix * Mathf.Sin( ( t * duration - s ) * ( 2 * Mathf.PI ) / p ) );
        }

        public static float Out( float curTime, float duration )
        {
            if ( curTime == 0.0f )
            {
                return 0.0f;
            }

            float t = curTime / duration;
            if ( t == 1.0f )
            {
                return 1.0f;
            }

            float p = duration * 0.3f;
            float s = p / 4.0f;
            return Mathf.Pow( 2.0f, -10.0f * t ) * Mathf.Sin( ( t * duration - s ) * ( 2 * Mathf.PI ) / p ) + 1.0f;
        }

        public static float InOut( float curTime, float duration )
        {
            if ( curTime == 0.0f )
            {
                return 0.0f;
            }

            float t = curTime / ( duration / 2.0f );
            if ( t == 2 )
            {
                return 1.0f;
            }

            float p = duration * ( 0.45f );
            float s = p / 4.0f;

            if ( t < 1.0f )
            {
                t -= 1.0f;
                float postFix = Mathf.Pow( 2.0f, 10.0f * t );
                return -0.5f * ( postFix * Mathf.Sin( ( t * duration - s ) * ( 2 * Mathf.PI ) / p ) );
            }
            else
            {
                t -= 1.0f;
                float postFix =  Mathf.Pow( 2.0f, -10.0f * t );
                return postFix * Mathf.Sin( ( t * duration - s ) * ( 2 * Mathf.PI ) / p ) * 0.5f + 1.0f;
            }
        }
    }
}
