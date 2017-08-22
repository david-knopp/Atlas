namespace Atlas
{
    // Adapted from Robert Penner's easing functions (http://robertpenner.com/easing/)
    public static class LinearEase
    {
        public static float In( float t, float start, float delta, float duration )
        {
            return delta * t / duration + start;
        }

        public static float Out( float t, float start, float delta, float duration )
        {
            return In( t, start, delta, duration );
        }

        public static float InOut( float t, float start, float delta, float duration )
        {
            return In( t, start, delta, duration );
        }
    }
}