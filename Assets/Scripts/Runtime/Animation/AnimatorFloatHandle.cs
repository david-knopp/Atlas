using System;
using UnityEngine;

namespace Atlas
{
    [Serializable]
    public struct AnimatorFloatHandle : ISerializationCallbackReceiver
    {
        public AnimatorFloatHandle( string floatName )
        {
            m_name = floatName;
            NameHash = Animator.StringToHash( floatName );
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

        public static implicit operator AnimatorFloatHandle( string floatName )
        {
            return new AnimatorFloatHandle( floatName );
        }

        [SerializeField] private string m_name;
    }
}
