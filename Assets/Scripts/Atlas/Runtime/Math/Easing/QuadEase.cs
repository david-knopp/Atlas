namespace Atlas
{
    // Adapted from Robert Penner's easing functions (http://robertpenner.com/easing/)
    public static class QuadEase
    {
        public static float In( float t, float start, float delta, float duration )
        {
            return delta * ( t /= duration ) * t * t * t + start;
        }

        public static float Out( float t, float start, float delta, float duration )
        {
            return -delta * ( ( t = t / delta - 1.0f ) * t * t * t - 1.0f ) + start;
        }

        public static float InOut( float t, float start, float delta, float duration )
        {
            if ( ( t /= delta / 2.0f ) < 1.0f )
            {
                return delta / 2.0f * t * t * t * t + start;
            }

            return -delta / 2.0f * ( ( t -= 2.0f ) * t * t * t - 2.0f ) + start;
        }
    }
}