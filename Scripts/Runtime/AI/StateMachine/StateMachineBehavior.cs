using UnityEngine;

namespace Atlas
{
    /// <summary>
    /// The <see cref="MonoBehaviour"/> derivative of a <see cref="StateMachine"/>
    /// </summary>
    /// <seealso cref="StateMachine"/>
    public class StateMachineBehavior : MonoBehaviour, IStateMachine
    {
        #region public
        /// <summary>
        /// The state that's currently executing, or null if no state is running
        /// </summary>
        public State CurrentState
        {
            get { return m_stateMachine.CurrentState; }
        }

        /// <summary>
        /// The state that was running before the current one, or null if no previous state exists
        /// </summary>
        public State PreviousState
        {
            get { return m_stateMachine.PreviousState; }
        }

        /// <summary>
        /// Adds the given state to the state machine
        /// </summary>
        /// <typeparam name="StateType">Type of state to add</typeparam>
        /// <param name="state">The state to add</param>
        public void AddState<StateType>( StateType state ) where StateType : State
        {
            m_stateMachine.AddState( state );
        }

        /// <summary>
        /// Removes the state of the given type. If multiple states exist with the given type,
        /// the first state of the desired type is removed.
        /// </summary>
        /// <typeparam name="StateType">Type of state to remove</typeparam>
        public void RemoveState<StateType>() where StateType : State
        {
            m_stateMachine.RemoveState<StateType>();
        }

        /// <summary>
        /// Gets the state of the given type. If multiple states exist with the given type,
        /// the first state of the desired type is returned.
        /// </summary>
        /// <typeparam name="StateType">Type of state to get</typeparam>
        /// <returns>The state with the given type</returns>
        public StateType GetState<StateType>() where StateType : State
        {
            return m_stateMachine.GetState<StateType>();
        }

        /// <summary>
        /// Sets the current state to the state of the desired type
        /// </summary>
        /// <typeparam name="StateType">Type of state to change to</typeparam>
        public void SetState<StateType>() where StateType : State
        {
            m_stateMachine.SetState<StateType>();
        }

        /// <summary>
        /// Reverts the state machine to the previously running state
        /// </summary>
        public void RevertToPrevState()
        {
            m_stateMachine.RevertToPrevState();
        }

        /// <summary>
        /// Updates the state machine, called in <see cref="Update"/> automatically
        /// </summary>
        public void Tick()
        {
            m_stateMachine.Tick();
        }
        #endregion // public

        #region protected
        /// <summary>
        /// Updates the state machine, called by Unity
        /// </summary>
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
