using System;
using UnityEngine;

namespace Atlas
{
    /// <summary>
    /// Base class that applies the singleton design pattern to a <see cref="MonoBehaviour"/>,
    /// providing a shared instance of the given type
    /// </summary>
    /// <typeparam name="TDerived">Type of the derived class</typeparam>
    public abstract class SingletonBehavior<TDerived> : MonoBehaviour where TDerived : MonoBehaviour
    {
        #region public
        /// <summary>
        /// Whether or not an instance exists. Since destruction order isn't guaranteed in Unity,
        /// it's recommended to reference this property when accessing singletons in shutdown
        /// methods such as OnDestroy
        /// </summary>
        public static bool HasInstance
        {
            get
            {
                return m_instance != null;
            }
        }

        /// <summary>
        /// The instance of the class. If an instance does not yet exist, an attempt will be made to find
        /// one using <see cref="UnityEngine.Object.FindObjectOfType{TDerived}"/>. If an instance is still
        /// not found, an <see cref="GameObject"/> will be instantiated with the desired class instance 
        /// attached.
        /// </summary>
        public static TDerived Instance
        {
            get
            {
                if ( m_instance == null )
                {
                    m_instance = FindObjectOfType<TDerived>();

                    if ( m_instance == null )
                    {
                        Debug.LogFormat( "SingletonBehavior.Instance: Couldn't find a scene reference of type '{0}', creating a new one", typeof( TDerived ) );

                        GameObject singletonObj = new GameObject();
                        m_instance = singletonObj.AddComponent<TDerived>();
                        singletonObj.name = typeof( TDerived ).ToString();
                    }
                }

                return m_instance;
            }
        }
        #endregion // public

        #region protected
        protected virtual void Awake()
        {
            if ( HasInstance )
            {
                throw new InvalidOperationException( string.Format( "SingletonBehavior.Awake: A singleton instance of type '{0}' already exists", typeof( TDerived ) ) );
            }

            m_instance = this as TDerived;
        }

        protected virtual void OnDestroy()
        {
            if ( ReferenceEquals( this, m_instance ) )
            {
                m_instance = null;
            }
        }
        #endregion // protected

        #region private
        private static TDerived m_instance;
        #endregion // private
    }
}