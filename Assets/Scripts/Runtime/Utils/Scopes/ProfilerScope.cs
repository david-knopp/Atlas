using System;
using UnityEngine.Profiling;

using Object = UnityEngine.Object;

namespace Atlas
{
    /// <summary>
    /// A handy scope variable that starts a <see cref="Profiler"/> sample, 
    /// and ends it when the scope ends
    /// </summary>
    /// <seealso cref="GUIColorScope"/>
    public struct ProfilerScope : IDisposable
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">A string to identify the sample in the Profiler window</param>
        public ProfilerScope( string name )
        {
            m_disposed = false;
            Profiler.BeginSample( name );
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">A string to identify the sample in the Profiler window</param>
        /// <param name="targetObject">An object that provides context to the sample</param>
        public ProfilerScope( string name, Object targetObject )
        {
            m_disposed = false;
            Profiler.BeginSample( name, targetObject );
        }

        /// <summary>
        /// Ends the scope
        /// </summary>
        public void Dispose()
        {
            if ( !m_disposed )
            {
                Profiler.EndSample();
                m_disposed = true;
            }
        }
        
        private bool m_disposed;
    }
}