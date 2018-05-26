using System;
using UnityEngine;

namespace Atlas
{
    public class GLColorScope : IDisposable
    {
        public GLColorScope( Color color )
        {
            m_prevColor = GUI.color;
            GL.Color( color );
        }

        public void Dispose()
        {
            if ( !m_disposed )
            {
                GL.Color( m_prevColor );
                m_disposed = true;
            }
        }

        private Color m_prevColor;
        private bool m_disposed;
    }
}