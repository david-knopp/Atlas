using System;
using UnityEngine;

namespace Atlas
{
    public class SingletonBehavior<T> : MonoBehaviour where T : MonoBehaviour
    {
        #region public
        public static bool HasInstance
        {
            get
            {
                return m_instance != null;
            }
        }

        public static T Instance
        {
            get
            {
                if ( m_instance == null )
                {
                    m_instance = FindObjectOfType<T>();

                    if ( m_instance == null )
                    {
                        Debug.LogFormat( "SingletonBehavior.Instance: Couldn't find a scene reference of type '{0}', creating a new one", typeof( T ) );

                        GameObject singletonObj = new GameObject();
                        m_instance = singletonObj.AddComponent<T>();
                        singletonObj.name = typeof( T ).ToString();

                        DontDestroyOnLoad( singletonObj );
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
                throw new InvalidOperationException( string.Format( "SingletonBehavior.Awake: A singleton instance of type '{0}' already exists", typeof( T ) ) );
            }

            m_instance = this as T;
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
        private static T m_instance;
        #endregion // private
    }
}