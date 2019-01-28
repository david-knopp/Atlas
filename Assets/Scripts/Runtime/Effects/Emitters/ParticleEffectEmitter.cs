using UnityEngine;

namespace Atlas
{
    /// <summary>
    /// Effect component for emitting particles
    /// </summary>
    [RequireComponent( typeof( ParticleSystem ) )]
    public sealed class ParticleEffectEmitter : EffectEmitterBase
    {
        #region public
        /// <summary>
        /// Starts playing the emitter
        /// </summary>
        public override void Play()
        {
            base.Play();
            m_particleSystem.Play( true );
        }

        /// <summary>
        /// Stops the emitter
        /// </summary>
        public override void Stop()
        {
            base.Stop();
            m_particleSystem.Stop( true );
        } 
        #endregion public

        #region protected
        /// <summary>
        /// Whether or not the emitter has finished emitting
        /// </summary>
        protected override bool IsFinished
        {
            get
            {
                return m_particleSystem.IsAlive( true ) == false;
            }
        }
        #endregion protected

        #region private
        private ParticleSystem m_particleSystem;

        private void Awake()
        {
            m_particleSystem = GetComponent<ParticleSystem>();
            var mainModule = m_particleSystem.main;
            mainModule.playOnAwake = false;
        }
        #endregion private
    }
}