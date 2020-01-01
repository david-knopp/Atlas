using UnityEngine;

namespace Atlas
{
    /// <summary>
    /// Handles audio playback for use with the effect system
    /// </summary>
    [RequireComponent( typeof( AudioSource ) )]
    public sealed class AudioEffectEmitter : EffectEmitterBase
    {
        #region public
        /// <summary>
        /// Starts playing the underlying audio source
        /// </summary>
        public override void Play()
        {
            base.Play();
            m_audioSource.Play();
        }

        /// <summary>
        /// Stops playing the audio source
        /// </summary>
        public override void Stop()
        {
            base.Stop();
            m_audioSource.Stop();
        }
        #endregion public

        #region protected
        protected override bool IsFinished
        {
            get => m_audioSource.isPlaying == false;
        } 
        #endregion protected

        #region private
        private AudioSource m_audioSource;

        private void Awake()
        {
            m_audioSource = GetComponent<AudioSource>();
            m_audioSource.playOnAwake = false;
        } 
        #endregion private
    }
}
