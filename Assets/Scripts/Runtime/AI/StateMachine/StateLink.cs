using UnityEngine.Assertions;

namespace Atlas
{
    public sealed class StateLink : IStateLink
    {
        #region public
        public delegate bool TransitionCondition();

        public StateLink( State nextState, TransitionCondition condition )
        {
            Assert.IsNotNull( nextState, "StateLink: nextState is null" );
            Assert.IsNotNull( condition, "StateLink: condition is null" );

            m_nextState = nextState;
            m_condition = condition;
        }

        public State NextState
        {
            get { return m_nextState; }
        }

        public bool IsSatisfied
        {
            get { return m_condition(); }
        }
        #endregion // public

        #region private
        private TransitionCondition m_condition;
        private State m_nextState;
        #endregion // private
    }
}