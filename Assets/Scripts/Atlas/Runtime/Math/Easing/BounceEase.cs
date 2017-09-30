namespace Atlas
{
    // Adapted from Robert Penner's easing functions (http://robertpenner.com/easing/)
    public static class BounceEase
    {
        public static float In( float curTime, float duration )
        {
            return 1.0f - Out( duration - curTime, duration );
        }

        public static float Out( float curTime, float duration )
        {
            float t = curTime / duration;

            if ( t < ( 1.0f / 2.75f ) )
            {
                return 7.5625f * t * t;
            }
            else if ( t < 2 / ( 2.75f ) )
            {
                t -= ( 1.5f / 2.75f );
                return 7.5625f * t * t + 0.75f;
            }
            else if ( t < ( 2.5f / 2.75f ) )
            {
                t -= ( 2.25f / 2.75f );
                return 7.5625f * t * t + 0.9375f;
            }
            else
            {
                t -= ( 2.625f / 2.75f );
                return 7.5625f * t * t + 0.984375f;
            }
        }

        public static float InOut( float curTime, float duration )
        {
            if ( curTime < duration / 2.0f )
            {
                return In( curTime * 2.0f, duration ) * 0.5f;
            }
            else
            {
                return Out( curTime * 2.0f - duration, duration ) * 0.5f + 0.5f;
            }
        }
    }
}