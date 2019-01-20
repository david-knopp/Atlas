using UnityEngine;

namespace Atlas
{
    public class StateMachineBehavior : MonoBehaviour, IStateMachine
    {
        #region public
        public State CurrentState { get { return m_stateMachine.CurrentState; } }
        public State PreviousState { get { return m_stateMachine.PreviousState; } }

        public void AddState<StateType>( StateType state ) where StateType : State
        {
            m_stateMachine.AddState( state );
        }

        public void RemoveState<StateType>() where StateType : State
        {
            m_stateMachine.RemoveState<StateType>();
        }

        public StateType GetState<StateType>() where StateType : State
        {
            return m_stateMachine.GetState<StateType>();
        }

        public void SetState<StateType>() where StateType : State
        {
            m_stateMachine.SetState<StateType>();
        }

        public void RevertToPrevState()
        {
            m_stateMachine.RevertToPrevState();
        }

        public void Tick()
        {
            m_stateMachine.Tick();
        }
        #endregion // public

        #region protected
        protected virtual void Update()
        {
            Tick();
        }
        #endregion // protected

        #region private
        private StateMachine m_stateMachine = new StateMachine();
        #endregion
    }
}