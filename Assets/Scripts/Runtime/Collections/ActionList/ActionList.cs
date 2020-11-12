using System.Collections.Generic;
using UnityEngine;

namespace Atlas
{
    public class ActionList : IAction
    {
        public bool IsRunning { get; private set; }
        public bool IsFinished => IsRunning && m_actionList.Count == 0;
        public bool IsBlocking { get; set; } = true;
        public bool IsPaused { get; set; }

        public void AddFirst( IAction action )
        {
            m_actionList.AddFirst( action );
        }

        public void AddLast( IAction action )
        {
            m_actionList.AddLast( action );
        }

        public void Clear()
        {
            m_actionList.Clear();
        }

        public void Start()
        {
            IsRunning = true;
        }

        public void Stop()
        {
            foreach ( var action in m_actionList )
            {
                if ( action.IsRunning )
                {
                    action.Stop();
                }
            }

            IsRunning = false;
        }

        public void Tick()
        {
            for ( var node = m_actionList.First; node != null; )
            {
                var nextNode = node.Next;
                IAction action = node.Value;

                // start action
                if ( action.IsRunning == false )
                {
                    action.Start();
                }

                action.Tick();

                // finish action
                if ( action.IsFinished )
                {
                    action.Stop();
                    m_actionList.Remove( node );
                }
                else if ( action.IsBlocking )
                {
                    break;
                }

                node = nextNode;
            }
        }

        private readonly LinkedList<IAction> m_actionList = new LinkedList<IAction>();
    }
}
