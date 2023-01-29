using System;
using UnityEngine;

namespace Atlas
{
    /// <summary>
    /// Represents a bool <see cref="Animator"/> parameter,
    /// providing a dropdown of available parameters in the inspector, and
    /// improved runtime performance through animator hashes
    /// </summary>
    [Serializable]
    public struct AnimatorBoolHandle : ISerializationCallbackReceiver
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="boolName">Name of the bool animator parameter</param>
        public AnimatorBoolHandle( string boolName )
        {
            m_name = boolName;
            NameHash = Animator.StringToHash( boolName );
        }

        /// <summary>
        /// Name of the given <see cref="Animator"/> parameter
        /// </summary>
        public string Name => m_name;

        /// <summary>
        /// Hash of the given <see cref="Animator"/> parameter
        /// </summary>
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
