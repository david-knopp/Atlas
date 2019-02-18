using System;
using System.Collections.Generic;
using UnityEngine.Assertions;

namespace Atlas
{
    /// <summary>
    /// A stack data structure for management and presentation of UI Panels
    /// </summary>
    public sealed class UIStack
    {
        #region public
        /// <summary>
        /// Types of panel transitions
        /// </summary>
        [Flags]
        public enum Transition
        {
            /// <summary>
            /// No transition
            /// </summary>
            None = 0,

            /// <summary>
            /// Play a transition only in <see cref="IUIPanel.OnPush(bool)"/> / <see cref="IUIPanel.OnShow(bool)"/>
            /// </summary>
            Intro = 1,

            /// <summary>
            /// Play a transition only in <see cref="IUIPanel.OnPop(bool)"/> / <see cref="IUIPanel.OnHide(bool)"/>
            /// </summary>
            Outro = 2,

            /// <summary>
            /// Play all transitions
            /// </summary>
            Full = Intro | Outro
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public UIStack()
        {
            m_stack = new Stack<IUIPanel>();
        }

        /// <summary>
        /// Number of panels currently in the stack
        /// </summary>
        public int Count
        {
            get { return m_stack.Count; }
        }

        /// <summary>
        /// Pushes the given panel onto the top of the stack, hiding all current panels, with
        /// full transitions
        /// </summary>
        /// <param name="panel">The panel to push</param>
        public void Push( IUIPanel panel )
        {
            Push( panel, Transition.Full );
        }

        /// <summary>
        /// Pushes the given panel onto the top of the stack, hiding all current panels using
        /// the given transitions
        /// </summary>
        /// <param name="panel">The panel to push</param>
        /// <param name="transition">Type of transition(s) to play</param>
        public void Push( IUIPanel panel, Transition transition )
        {
            Assert.IsNotNull( panel, "UiStack.Push: panel is null" );

            // hide top
            if ( Count > 0 )
            {
                IUIPanel curPanel = Peek();
                curPanel.IsActive = false;
                curPanel.OnHide( BitField.IsFlagSet( transition, Transition.Outro ) );
            }

            // push new
            m_stack.Push( panel );
            panel.IsActive = true;
            panel.OnPush( BitField.IsFlagSet( transition, Transition.Intro ) );
        }

        /// <summary>
        /// Removes the top panel from the stack, with full transitions
        /// </summary>
        /// <returns>The popped panel</returns>
        public IUIPanel Pop()
        {
            return Pop( Transition.Full );
        }
        
        /// <summary>
        /// Removes the top panel from the stack, with the given transition(s)
        /// </summary>
        /// <param name="transition">Type of transition(s) to play</param>
        /// <returns>The popped panel</returns>
        public IUIPanel Pop( Transition transition )
        {
            // pop top
            IUIPanel poppedPanel = m_stack.Pop();
            Assert.IsNotNull( poppedPanel, "UIStack.Pop: Top panel is null" );
            poppedPanel.IsActive = false;
            poppedPanel.OnPop( BitField.IsFlagSet( transition, Transition.Outro ) );

            // show prev
            if ( Count > 0 )
            {
                IUIPanel newTop = Peek();
                Assert.IsNotNull( poppedPanel, "UIStack.Pop: New top panel is null" );
                newTop.IsActive = true;
                newTop.OnShow( BitField.IsFlagSet( transition, Transition.Intro ) );
            }

            return poppedPanel;
        }

        /// <summary>
        /// Removes all panels from the stack. <see cref="IUIPanel.OnPop(bool)"/> will not
        /// be called.
        /// </summary>
        public void Clear()
        {
            m_stack.Clear();
        }

        /// <summary>
        /// Returns the top <see cref="IUIPanel"/>
        /// </summary>
        /// <returns>The top panel</returns>
        public IUIPanel Peek()
        {
            Assert.IsTrue( Count > 0, "UIStack.Peek: The stack is empty" );
            return m_stack.Peek();
        }

        /// <summary>
        /// Determines whether or not the given panel is contained within the stack
        /// </summary>
        /// <param name="panel">The panel to check</param>
        /// <returns>True if the panel is in the stack, false otherwise</returns>
        public bool Contains( IUIPanel panel )
        {
            return m_stack.Contains( panel );
        }
        #endregion // public

        #region private
        private Stack<IUIPanel> m_stack;
        #endregion // private
    }
}
