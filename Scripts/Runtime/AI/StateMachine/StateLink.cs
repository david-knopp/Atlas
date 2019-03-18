using UnityEngine.Assertions;

namespace Atlas
{
    /// <summary>
    /// A concrete object representing the link from one state to another
    /// </summary>
    /// <seealso cref="IStateLink"/>
    /// <seealso cref="StateMachine"/>
    public struct StateLink : IStateLink
    {
        #region public
        /// <summary>
        /// The callback for determining whether or not this link's transition
        /// condition is satisfied
        /// </summary>
        /// <returns>True if a transition is desired, false otherwise</returns>
        public delegate bool TransitionCondition();

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nextState">The state to transition to when the condition satisfied</param>
        /// <param name="condition">The callback used to determine when a transition should occur</param>
        public StateLink( State nextState, TransitionCondition condition )
        {
            Assert.IsNotNull( nextState, "StateLink: nextState is null" );
            Assert.IsNotNull( condition, "StateLink: condition is null" );

            m_nextState = nextState;
            m_condition = condition;
        }

        /// <summary>
        /// The state to transition to when the condition satisfied
        /// </summary>
        public State NextState
        {
            get { return m_nextState; }
        }

        /// <summary>
        /// Whether or not a transition to <see cref="NextState"/> is desired
        /// </summary>
        public bool IsSatisfied
        {
            get { return m_condition(); }
        }
        #endregion // public

        #region private
        private TransitionCondition m_condition;
        private readonly State m_nextState;
        #endregion // private
    }
}
