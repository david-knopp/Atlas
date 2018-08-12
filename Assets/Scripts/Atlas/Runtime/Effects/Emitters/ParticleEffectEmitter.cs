﻿using UnityEngine;

namespace Atlas
{
    [RequireComponent( typeof( ParticleSystem ) )]
    public class ParticleEffectEmitter : EffectEmitterBase
    {
        public override void Play()
        {
            base.Play();
            m_particleSystem.Play();
        }

        public override void Stop()
        {
            base.Stop();
            m_particleSystem.Stop();
        }

        protected override bool IsFinished
        {
            get
            {
                return m_particleSystem.IsAlive( true ) == false;
            }
        }

        private ParticleSystem m_particleSystem;

        private void Awake()
        {
            m_particleSystem = GetComponent<ParticleSystem>();
            var mainModule = m_particleSystem.main;
            mainModule.playOnAwake = false;
        }
    }
}