using System.Collections.Generic;

namespace Atlas
{
    /// <summary>
    /// A data structure representing a list of actions that are executed sequentially in parallel,
    /// or in series depending on each action's <see cref="IsBlocking"/> property
    /// </summary>
    public class ActionList : IAction
    {
        #region public
        /// <summary>
        /// Whether or not the actions have finished
        /// </summary>
        public bool IsFinished => m_actionList.Count == 0;

        /// <summary>
        /// Whether or not the ActionList will block other actions,
        /// if it's in an ActionList itself
        /// </summary>
        public bool IsBlocking { get; set; } = true;

        /// <summary>
        /// Whether or not the ActionList has paused execution
        /// </summary>
        public bool IsPaused { get; set; }

        /// <summary>
        /// Adds the given action to the front of the list
        /// </summary>
        /// <param name="action">The action to add</param>
        public void AddFirst( IAction action )
        {
            m_actionList.AddFirst( new ActionMetadata( action ) );
        }

        /// <summary>
        /// Adds an action to the back of the list
        /// </summary>
        /// <param name="action">The action to add</param>
        public void AddLast( IAction action )
        {
            m_actionList.AddLast( new ActionMetadata( action ) );
        }

        /// <summary>
        /// Removes all actions from the list
        /// </summary>
        public void Clear()
        {
            m_actionList.Clear();
        }

        public void OnStart()
        {
        }

        public void OnStop()
        {
        }

        /// <summary>
        /// Updates the <see cref="IAction"/>s in the list
        /// </summary>
        public void Tick()
        {
            for ( var node = m_actionList.First; node != null; )
            {
                var nextNode = node.Next;
                var actionMetadata = node.Value;
                var action = actionMetadata.Action;
                bool isActionFinished = false;

                if ( action.IsPaused == false )
                {
                    // start action
                    if ( actionMetadata.HasStarted == false )
                    {
                        action.OnStart();
                        actionMetadata.HasStarted = true;
                        node.Value = actionMetadata;
                    }

                    action.Tick();

                    // finish action
                    if ( action.IsFinished )
                    {
                        action.OnStop();
                        m_actionList.Remove( node );
                        isActionFinished = true;
                    }
                }

                if ( isActionFinished == false &&
                     action.IsBlocking )
                {
                    break;
                }

                node = nextNode;
            }
        } 
        #endregion public

        #region private
        private struct ActionMetadata
        {
            public ActionMetadata( IAction action )
            {
                Action = action;
                HasStarted = false;
            }

            public IAction Action;
            public bool HasStarted;
        }

        private readonly LinkedList<ActionMetadata> m_actionList = new LinkedList<ActionMetadata>();
        #endregion private
    }
}
