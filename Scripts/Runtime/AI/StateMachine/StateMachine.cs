using System;
using System.Collections.Generic;

namespace Atlas
{
    /// <summary>
    /// A finite state machine data structure that executes states, and handles switching between them
    /// </summary>
    /// <seealso cref="StateMachineBehavior"/>
    public class StateMachine : IStateMachine
    {
        #region public
        /// <summary>
        /// The state that's currently executing, or null if no state is running
        /// </summary>
        public State CurrentState
        {
            get;
            private set;
        }

        /// <summary>
        /// The state that was running before the current one, or null if no previous state exists
        /// </summary>
        public State PreviousState
        {
            get;
            private set;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public StateMachine()
        {
            m_states = new Dictionary<Type, State>();
        }

        /// <summary>
        /// Adds the given state to the state machine
        /// </summary>
        /// <typeparam name="StateType">Type of state to add</typeparam>
        /// <param name="state">The state to add</param>
        public void AddState<StateType>( StateType state ) where StateType : State
        {
            m_states.Add( typeof( StateType ), state );
            state.StateMachine = this;
        }

        /// <summary>
        /// Removes the state of the given type. If multiple states exist with the given type,
        /// the first state of the desired type is removed.
        /// </summary>
        /// <typeparam name="StateType">Type of state to remove</typeparam>
        public void RemoveState<StateType>() where StateType : State
        {
            StateType state = GetState<StateType>();
            state.StateMachine = null;
            m_states.Remove( typeof( StateType ) );
        }

        /// <summary>
        /// Gets the state of the given type. If multiple states exist with the given type,
        /// the first state of the desired type is returned.
        /// </summary>
        /// <typeparam name="StateType">Type of state to get</typeparam>
        /// <returns>The state with the given type</returns>
        public StateType GetState<StateType>() where StateType : State
        {
            State state = m_states[typeof( StateType )];
            return ( StateType )state;
        }

        /// <summary>
        /// Sets the current state to the state of the desired type
        /// </summary>
        /// <typeparam name="StateType">Type of state to change to</typeparam>
        public void SetState<StateType>() where StateType : State
        {
            Type stateType = typeof( StateType );

            try
            {
                ChangeState( m_states[stateType] );
            }
            catch ( KeyNotFoundException e )
            {
                throw new KeyNotFoundException( string.Format( "StateMachine: Couldn't change to state: '{0}.'", stateType.ToString() ), e );
            }
        }

        /// <summary>
        /// Reverts the state machine to the previously running state
        /// </summary>
        public void RevertToPrevState()
        {
            ChangeState( PreviousState );
        }

        /// <summary>
        /// Updates the state machine
        /// </summary>
        public void Tick()
        {
            if ( CurrentState != null )
            {
                // check state transitions
                foreach ( var link in CurrentState.StateLinks )
                {
                    if ( link.IsSatisfied )
                    {
                        ChangeState( link.NextState );
                        break;
                    }
                }

                CurrentState.Tick();
            }
        }
        #endregion public

        #region private
        private Dictionary<Type, State> m_states;

        private void ChangeState( State nextState )
        {
            if ( nextState != CurrentState )
            {
                // exit current state
                if ( CurrentState != null )
                {
                    CurrentState.Exit();
                }

                // swap states
                PreviousState = CurrentState;
                CurrentState = nextState;

                // enter new state
                CurrentState.Enter();
            }
        }
        #endregion private
    }
}
