using System;

namespace Atlas
{
    public sealed class GUIListener : SingletonBehavior<GUIListener>
    {
        public event Action OnGUIRender
        {
            add { m_guiRenderAction += value; }
            remove { m_guiRenderAction -= value; }
        }

        private Action m_guiRenderAction = () => { };

        private void OnGUI()
        {
            m_guiRenderAction.Invoke();
        }
    }
}