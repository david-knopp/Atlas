namespace Atlas.Examples
{
    public sealed class Example_SingletonBehavior
    {
        // declare singleton class
        public sealed class AudioSystem : SingletonBehavior<AudioSystem>
        {
            public void PlayAudioClip( int id )
            {
                // Audio playback code...
            }
        }

        // called when a goal is scored
        public void OnGoalScored()
        {
            // play audio using shared AudioSystem instance
            AudioSystem.Instance.PlayAudioClip( c_goalAudioID );
        }

        private const int c_goalAudioID = 5;
    }
}
