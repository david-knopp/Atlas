using UnityEngine;
using System.Collections.Generic;

namespace Atlas
{
    public class Effect : MonoBehaviour
    {
        public enum ActivationEventType
        {
            Start = 0,
            Manual = 1
        }

        public enum DestructionEventType
        {
            Finished = 0,
            Manual = 1
        }

        public ActivationEventType ActivationEvent
        {
            get { return m_activationEvent; }
        }

        public DestructionEventType DestructionEvent
        {
            get { return m_destructionEvent; }
        }

        public bool IsPlaying
        {
            get;
            private set;
        }

        public void Play()
        {
            IsPlaying = true;

            foreach ( var emitter in m_emitters )
            {
                emitter.Play();
            }
        }

        public void Stop()
        {
            if ( IsPlaying )
            {
                foreach ( var emitter in m_emitters )
                {
                    emitter.Stop();
                }

                OnFinished();
            }
        }

        [SerializeField] private List<EffectEmitterBase> m_emitters;
        [SerializeField] private ActivationEventType m_activationEvent;
        [SerializeField] private DestructionEventType m_destructionEvent;

        private int m_finishedEmittersCount;

        private void Awake()
        {
            for ( int i = 0; i < m_emitters.Count; i++ )
            {
                m_emitters[i].EmissionFinishedEvent += OnEmitterFinished;
            }
        }

        private void Start()
        {
            if ( ActivationEvent == ActivationEventType.Start )
            {
                Play();
            }
        }

        private void OnEmitterFinished()
        {
            ++m_finishedEmittersCount;
            if ( m_finishedEmittersCount == m_emitters.Count )
            {
                OnFinished();
            }
        }

        private void OnFinished()
        {
            IsPlaying = false;

            if ( DestructionEvent == DestructionEventType.Finished )
            {
                Destroy( gameObject );
            }
        }
    }
}