using System;
using UnityEngine;

namespace Atlas
{
    /// <summary>
    /// A handy scope variable that sets <see cref="GUI.backgroundColor"/> to the given color, 
    /// and automatically resets it to its original color when the scope ends
    /// </summary>
    /// <seealso cref="ProfilerScope"/>
    public struct GUIBackgroundColorScope : IDisposable
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="color">The target color</param>
        /// <param name="shouldSetColor">Optional conditional for bypassing color assignment</param>
        public GUIBackgroundColorScope( Color color, bool shouldSetColor = true )
        {
            m_disposed = false;
            m_prevColor = GUI.backgroundColor;

            if ( shouldSetColor )
            {
                GUI.backgroundColor = color;
            }
        }

        /// <summary>
        /// Ends the scope
        /// </summary>
        public void Dispose()
        {
            if ( !m_disposed )
            {
                GUI.backgroundColor = m_prevColor;
                m_disposed = true;
            }
        }

        private Color m_prevColor;
        private bool m_disposed;
    }
}
