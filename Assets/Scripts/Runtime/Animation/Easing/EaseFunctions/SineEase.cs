using UnityEngine;

namespace Atlas
{
    // Adapted from Robert Penner's easing functions (http://robertpenner.com/easing/)
    public static class SineEase
    {
        public static float In( float curTime, float duration )
        {
            return -1.0f * Mathf.Cos( curTime / duration * ( Mathf.PI / 2.0f ) ) + 1.0f;
        }

        public static float Out( float curTime, float duration )
        {
            return Mathf.Sin( curTime / duration * ( Mathf.PI / 2.0f ) );
        }

        public static float InOut( float curTime, float duration )
        {
            return -0.5f * ( Mathf.Cos( Mathf.PI * curTime / duration ) - 1.0f );
        }
    }
}
