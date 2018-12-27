using System;
using UnityEngine;
using UnityEngine.Profiling;

using Object = UnityEngine.Object;

namespace Atlas
{
    public class ProfilerScope : IDisposable
    {
        public ProfilerScope( string name )
        {
            Profiler.BeginSample( name );
        }

        public ProfilerScope( string name, Object targetObject )
        {
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

        private Color m_prevColor;
        private bool m_disposed;
    }
}