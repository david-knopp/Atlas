﻿using System;
using UnityEngine;

namespace Atlas
{
    public struct GUIColorScope : IDisposable
    {
        public GUIColorScope( Color color )
        {
            m_disposed = false;
            m_prevColor = GUI.color;
            GUI.color = color;
        }

        public void Dispose()
        {
            if ( !m_disposed )
            {
                GUI.color = m_prevColor;
                m_disposed = true;
            }
        }

        private Color m_prevColor;
        private bool m_disposed;
    }
}