using UnityEngine;
using UnityEngine.Playables;

namespace Atlas
{
    /// <summary>
    /// Handles playable playback for use with the effect system
    /// </summary>
    [RequireComponent( typeof( PlayableDirector ) )]
    public sealed class PlayableEffectEmitter : EffectEmitterBase
    {
        #region public
        public override void Play()
        {
            base.Play();
            m_playable.Play();
        }

        public override void Stop()
        {
            base.Stop();
            m_playable.Stop();
        }
        #endregion public

        #region protected
        protected override bool IsFinished => m_playable.state == PlayState.Paused;
        #endregion protected

        #region private
        private PlayableDirector m_playable;

        private void Awake()
        {
            m_playable = GetComponent<PlayableDirector>();
            m_playable.playOnAwake = false;
        } 
        #endregion private
    }
}
