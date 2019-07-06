using System.Collections.Generic;

namespace Atlas
{
    /// <summary>
    /// Represents a single state within a <see cref="IStateMachine"/>
    /// </summary>
    /// <seealso cref="IStateMachine"/>
    /// <seealso cref="Atlas.StateMachine"/>
    public abstract class State
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public State()
        {
            StateLinks = new List<IStateLink>();
        }

        /// <summary>
        /// The <see cref="IStateMachine"/> that owns this state
        /// </summary>
        public IStateMachine StateMachine
        {
            get;
            set;
        }

        /// <summary>
        /// Links to other states
        /// </summary>
        public List<IStateLink> StateLinks
        {
            get;
            private set;
        }

        /// <summary>
        /// Adds a link to another state
        /// </summary>
        /// <param name="link">The link to add</param>
        public void AddStateLink( IStateLink link )
        {
            StateLinks.Add( link );
        }

        /// <summary>
        /// Adds a link to another state
        /// </summary>
        /// <param name="nextState">The state to transition to when the given condition is satisfied</param>
        /// <param name="condition">The condition used to evaluate if this link is satisfied</param>
        public void AddStateLink( State nextState,
                                  StateLink.TransitionCondition condition )
        {
            AddStateLink( new StateLink( nextState, condition ) );
        }

        /// <summary>
        /// Called when the state is entered
        /// </summary>
        public virtual void Enter()
        {
        }

        /// <summary>
        /// Called when the state is updated
        /// </summary>
        public virtual void Tick()
        {
        }

        /// <summary>
        /// Called when the state is exited
        /// </summary>
        public virtual void Exit()
        {
        }
    }
}
