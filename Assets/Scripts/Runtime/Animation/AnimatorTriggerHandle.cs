using System;
using UnityEngine;

namespace Atlas
{
    [Serializable]
    public struct AnimatorTriggerHandle : ISerializationCallbackReceiver
    {
        public AnimatorTriggerHandle( string triggerName )
        {
            m_name = triggerName;
            NameHash = Animator.StringToHash( triggerName );
        }

        public string Name => m_name;
        public int NameHash { get; private set; }

        public void OnBeforeSerialize()
        {
        }

        public void OnAfterDeserialize()
        {
            NameHash = Animator.StringToHash( m_name );
        }

        public static implicit operator AnimatorTriggerHandle( string triggerName )
        {
            return new AnimatorTriggerHandle( triggerName );
        }

        [SerializeField] private string m_name;
    }
}
