namespace Atlas
{
    public interface IStateMachine
    {
        State CurrentState { get; }
        State PreviousState { get; }

        void AddState<StateType>( StateType state ) where StateType : State;
        void RemoveState<StateType>() where StateType : State;
        StateType GetState<StateType>() where StateType : State;
        void SetState<StateType>() where StateType : State;
        void RevertToPrevState();
    }
}
