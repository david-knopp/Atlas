namespace Atlas
{
    /// <summary>
    /// Interface for objects that represent links between <see cref="State"/>s in a <see cref="StateMachine"/>
    /// </summary>
    public interface IStateLink
    {
        /// <summary>
        /// The state to transition to after the current state
        /// </summary>
        State NextState { get; }

        /// <summary>
        /// Whether or not this link's transition condition is satisifed. This should return true when
        /// a transition is desired, and false otherwise.
        /// </summary>
        bool IsSatisfied { get; }
    }
}
