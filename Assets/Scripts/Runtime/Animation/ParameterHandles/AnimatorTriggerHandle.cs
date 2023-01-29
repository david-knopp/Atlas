using System;
using UnityEngine;

namespace Atlas
{
    /// <summary>
    /// Represents a trigger <see cref="Animator"/> parameter,
    /// providing a dropdown of available parameters in the inspector, and
    /// improved runtime performance through animator hashes
    /// </summary>
    [Serializable]
    public struct AnimatorTriggerHandle : ISerializationCallbackReceiver
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="boolName">Name of the trigger animator parameter</param>s
        public AnimatorTriggerHandle( string triggerName )
        {
            m_name = triggerName;
            NameHash = Animator.StringToHash( triggerName );
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

        public static implicit operator AnimatorTriggerHandle( string triggerName )
        {
            return new AnimatorTriggerHandle( triggerName );
        }

        [SerializeField, AnimatorParameterName( AnimatorControllerParameterType.Trigger )] private string m_name;
    }
}
