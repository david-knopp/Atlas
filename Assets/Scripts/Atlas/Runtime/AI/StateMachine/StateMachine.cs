using System;
using System.Collections.Generic;

namespace Atlas
{
    public class StateMachine : IStateMachine
    {
        #region public
        public State CurrentState { get; private set; }
        public State PreviousState { get; private set; }

        public StateMachine()
        {
            m_states = new Dictionary<Type, State>();
        }

        public void AddState<StateType>( StateType state ) where StateType : State
        {
            m_states.Add( typeof( StateType ), state );
            state.StateMachine = this;
        }

        public void RemoveState<StateType>() where StateType : State
        {
            StateType state = GetState<StateType>();
            state.StateMachine = null;
            m_states.Remove( typeof( StateType ) );
        }

        public StateType GetState<StateType>() where StateType : State
        {
            State state = m_states[typeof( StateType )];
            return ( StateType )state;
        }

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

        public void RevertToPrevState()
        {
            ChangeState( PreviousState );
        }

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
        #endregion // public

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
        #endregion // private
    }
}