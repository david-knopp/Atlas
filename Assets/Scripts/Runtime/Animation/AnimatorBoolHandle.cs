using System;
using UnityEngine;

namespace Atlas
{
    [Serializable]
    public struct AnimatorBoolHandle : ISerializationCallbackReceiver
    {
        public AnimatorBoolHandle( string boolName )
        {
            m_name = boolName;
            NameHash = Animator.StringToHash( boolName );
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

        public static implicit operator AnimatorBoolHandle( string boolName )
        {
            return new AnimatorBoolHandle( boolName );
        }

        [SerializeField, AnimatorParameterName( AnimatorControllerParameterType.Bool )] private string m_name;
    }
}
