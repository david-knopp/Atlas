using System;
using UnityEngine;

namespace Atlas
{
    /// <summary>
    /// Represents an integer <see cref="Animator"/> parameter,
    /// providing a dropdown of available parameters in the inspector, and
    /// improved runtime performance through animator hashes
    /// </summary>
    [Serializable]
    public struct AnimatorIntHandle : ISerializationCallbackReceiver
    {

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="boolName">Name of the int animator parameter</param>
        public AnimatorIntHandle( string intName )
        {
            m_name = intName;
            NameHash = Animator.StringToHash( intName );
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

        public static implicit operator AnimatorIntHandle( string intName )
        {
            return new AnimatorIntHandle( intName );
        }

        [SerializeField, AnimatorParameterName( AnimatorControllerParameterType.Int )] private string m_name;
    }
}
