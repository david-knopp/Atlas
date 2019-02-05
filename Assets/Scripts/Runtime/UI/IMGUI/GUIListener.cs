using System;

namespace Atlas
{
    /// <summary>
    /// A singleton class for registering and executing callbacks in Unity's OnGUI.
    /// Since simply including the OnGUI method in a <see cref="UnityEngine.MonoBehaviour"/>
    /// will cause undesirable heap allocations, this class is meant to collect those calls
    /// into one place, which can be disabled in live builds or even lazily instantiated
    /// for rendering debug information only when necessary.
    /// </summary>
    public sealed class GUIListener : SingletonBehavior<GUIListener>
    {
        #region public
        /// <summary>
        /// Event that fires every OnGUI update cycle
        /// </summary>
        public event Action GUIRenderEvent
        {
            add { m_guiRenderAction += value; }
            remove { m_guiRenderAction -= value; }
        }
        #endregion public

        #region private
        private Action m_guiRenderAction = () => { };

        private void OnGUI()
        {
            m_guiRenderAction.Invoke();
        } 
        #endregion private
    }
}