using System.Collections.Generic;
using UnityEngine;

namespace Atlas
{
    public class ActionList : IAction
    {
        public bool IsFinished => m_actionList.Count == 0;
        public bool IsBlocking { get; set; } = true;
        public bool IsPaused { get; set; }

        public void AddFirst( IAction action )
        {
            m_actionList.AddFirst( new ActionMetadata( action ) );
        }

        public void AddLast( IAction action )
        {
            m_actionList.AddLast( new ActionMetadata( action ) );
        }

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
    }
}
