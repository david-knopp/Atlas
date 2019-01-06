using System;
using UnityEngine.Profiling;

using Object = UnityEngine.Object;

namespace Atlas
{
    public struct ProfilerScope : IDisposable
    {
        public ProfilerScope( string name )
        {
            m_disposed = false;
            Profiler.BeginSample( name );
        }

        public ProfilerScope( string name, Object targetObject )
        {
            m_disposed = false;
            Profiler.BeginSample( name, targetObject );
        }

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