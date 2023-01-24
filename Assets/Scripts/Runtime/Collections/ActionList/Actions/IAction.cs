namespace Atlas
{
    /// <summary>
    /// Action interface, representing an action that can be executed
    /// over the course of many frames
    /// </summary>
    public interface IAction
    {
        /// <summary>
        /// Whether or not this action has completed.
        /// When it finishes, it will automatically be removed from the <see cref="ActionList"/>
        /// </summary>
        bool IsFinished { get; }

        /// <summary>
        /// Whether or not this action will block the execution of subsequent actions
        /// until it has finished running
        /// </summary>
        bool IsBlocking { get; }

        /// <summary>
        /// Whether or not the execution of this action is paused
        /// </summary>
        bool IsPaused { get; set; }

        /// <summary>
        /// Called when the node begins execution from an <see cref="ActionList"/>
        /// </summary>
        void OnStart();

        /// <summary>
        /// Called when the node finishes execution from an <see cref="ActionList"/>
        /// </summary>
        void OnStop();

        /// <summary>
        /// Called by the action's parent <see cref="ActionList"/> when it's updated
        /// </summary>
        void Tick();
    }
}
