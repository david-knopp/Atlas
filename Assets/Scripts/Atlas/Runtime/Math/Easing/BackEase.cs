namespace Atlas
{
    // Adapted from Robert Penner's easing functions (http://robertpenner.com/easing/)
    public static class BackEase
    {
        public static float In( float curTime, float duration )
        {
            const float s = 1.70158f;
            float t = curTime / duration;
            return t * curTime * ( ( s + 1.0f ) * curTime - s );
        }

        public static float Out( float curTime, float duration )
        {
            const float s = 1.70158f;
            float t = curTime / duration - 1.0f;
            return t * t * ( ( s + 1.0f ) * t + s ) + 1.0f;
        }

        public static float InOut( float curTime, float duration )
        {
            float s = 1.70158f;
            float t = curTime / ( duration / 2.0f );
            if ( t < 1.0f )
            {
                s *= 1.525f;
                return 0.5f * ( t * t * ( ( s + 1.0f ) * t - s ) );
            }

            t -= 2.0f;
            s *= 1.525f;
            return 0.5f * ( t * t * ( ( s + 1.0f ) * t + s ) + 2.0f );
        }
    }
}