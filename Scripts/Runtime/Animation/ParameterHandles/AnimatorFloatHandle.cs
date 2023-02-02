using System;
using UnityEngine;

namespace Atlas
{
    /// <summary>
    /// Represents a float <see cref="Animator"/> parameter,
    /// providing a dropdown of available parameters in the inspector, and
    /// improved runtime performance through animator hashes
    /// </summary>
    [Serializable]
    public struct AnimatorFloatHandle : ISerializationCallbackReceiver
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="boolName">Name of the float animator parameter</param>
        public AnimatorFloatHandle( string floatName )
        {
            m_name = floatName;
            NameHash = Animator.StringToHash( floatName );
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

        public static implicit operator AnimatorFloatHandle( string floatName )
        {
            return new AnimatorFloatHandle( floatName );
        }

        [SerializeField, AnimatorParameterName( AnimatorControllerParameterType.Float )] private string m_name;
    }
}
