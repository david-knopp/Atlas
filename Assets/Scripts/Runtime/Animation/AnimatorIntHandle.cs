using System;
using UnityEngine;

namespace Atlas
{
    [Serializable]
    public struct AnimatorIntHandle : ISerializationCallbackReceiver
    {
        public AnimatorIntHandle( string intName )
        {
            m_name = intName;
            NameHash = Animator.StringToHash( intName );
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

        public static implicit operator AnimatorIntHandle( string intName )
        {
            return new AnimatorIntHandle( intName );
        }

        [SerializeField] private string m_name;
    }
}
