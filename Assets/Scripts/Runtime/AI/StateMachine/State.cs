using System.Collections.Generic;

namespace Atlas
{
    public abstract class State
    {
        public State()
        {
            m_stateLinks = new List<IStateLink>();
        }

        public IStateMachine StateMachine
        {
            get;
            set;
        }

        public List<IStateLink> StateLinks
        {
            get { return m_stateLinks; }
        }

        public void AddStateLink( IStateLink link )
        {
            m_stateLinks.Add( link );
        }

        public void AddStateLink( State nextState,
                                  StateLink.TransitionCondition condition )
        {
            AddStateLink( new StateLink( nextState, condition ) );
        }

        public virtual void Enter()
        {
        }

        public virtual void Tick()
        {
        }

        public virtual void Exit()
        {
        }

        private List<IStateLink> m_stateLinks;
    }
}