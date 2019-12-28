using System;
using UnityEngine;

namespace Atlas
{
    /// <summary>
    /// A Unity-serializable Guid value
    /// </summary>
    [Serializable]
    public class GUID : IEquatable<GUID>, ISerializationCallbackReceiver
    {
        public GUID() : this( Guid.NewGuid() )
        {
        }

        public GUID( Guid value )
        {
            Value = value;
        }

        /// <summary>
        /// The raw Guid value
        /// </summary>
        public Guid Value
        {
            get;
            set;
        }

        /// <summary>
        /// Generates a new GUID, internally using "Guid.NewGuid()"
        /// </summary>
        /// <returns>a new GUID with a unique value</returns>
        public static GUID NewGUID()
        {
            return new GUID( Guid.NewGuid() );
        }

        public void OnBeforeSerialize()
        {
            m_serialiedGUID = Value.ToByteArray();
        }

        public void OnAfterDeserialize()
        {
            if ( m_serialiedGUID != null )
            {
                Value = new Guid( m_serialiedGUID );
            }
        }

        public bool Equals( GUID other )
        {
            if ( other == null )
            {
                return false;
            }

            return Value.Equals( other.Value );
        }

        public override bool Equals( object obj )
        {
            return Equals( obj as GUID );
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public static bool operator ==( GUID a, GUID b )
        {
            if ( ReferenceEquals( a, null ) )
            {
                return ReferenceEquals( b, null );
            }

            return a.Equals( b );
        }

        public static bool operator !=( GUID a, GUID b )
        {
            return !( a == b );
        }

        public static implicit operator Guid( GUID guid )
        {
            return guid.Value;
        }

        public static implicit operator GUID( Guid guid )
        {
            return new GUID( guid );
        }

        [SerializeField, HideInInspector]
        private byte[] m_serialiedGUID;
    }
}
