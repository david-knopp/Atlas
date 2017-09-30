namespace Atlas
{
    // Adapted from Robert Penner's easing functions (http://robertpenner.com/easing/)
    public static class LinearEase
    {
        public static float In( float curTime, float duration )
        {
            return curTime / duration;
        }

        public static float Out( float curTime, float duration )
        {
            return In( curTime, duration );
        }

        public static float InOut( float curTime, float duration )
        {
            return In( curTime, duration );
        }
    }
}