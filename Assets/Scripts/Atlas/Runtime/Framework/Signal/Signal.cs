using System.Collections.Generic;
using System;

namespace Atlas
{
    public interface ISignal
    {
    }

    public class BaseSignal<TBaseCommand, TAction> : ISignal
    {
        public BaseSignal()
        {
            m_commands = new List<TBaseCommand>();
            m_listeners = new List<TAction>();
        }

        public void AddCommand<CommandType>( CommandType command ) where CommandType : TBaseCommand
        {
            m_commands.Add( command );
        }

        public void AddCommand<CommandType>() where CommandType : TBaseCommand
        {
            CommandType command = Activator.CreateInstance<CommandType>();
            m_commands.Add( command );
        }

        public void RemoveCommand<CommandType>() where CommandType : TBaseCommand
        {
            m_commands.RemoveAll( ( TBaseCommand command ) => 
            {
                return command is CommandType;
            } );
        }

        public void AddListener( TAction listener )
        {
            m_listeners.Add( listener );
        }

        public void RemoveListener( TAction listener )
        {
            m_listeners.Remove( listener );
        }

        protected List<TBaseCommand> m_commands;
        protected List<TAction> m_listeners;
    }

    public class Signal : BaseSignal<ICommand, Action>
    {
        public void Dispatch()
        {
            for ( int i = 0; i < m_commands.Count; i++ )
            {
                m_commands[i].Execute();
            }

            for ( int i = 0; i < m_listeners.Count; i++ )
            {
                m_listeners[i].Invoke();
            }
        }
    }

    public class Signal<T> : BaseSignal<ICommand<T>, Action<T>>
    {
        public void Dispatch( T arg )
        {
            for ( int i = 0; i < m_commands.Count; i++ )
            {
                m_commands[i].Execute( arg );
            }

            for ( int i = 0; i < m_listeners.Count; i++ )
            {
                m_listeners[i].Invoke( arg );
            }
        }
    }

    public class Signal<T1, T2> : BaseSignal<ICommand<T1, T2>, Action<T1, T2>>
    {
        public void Dispatch( T1 arg1, T2 arg2 )
        {
            for ( int i = 0; i < m_commands.Count; i++ )
            {
                m_commands[i].Execute( arg1, arg2 );
            }

            for ( int i = 0; i < m_listeners.Count; i++ )
            {
                m_listeners[i].Invoke( arg1, arg2 );
            }
        }
    }

    public class Signal<T1, T2, T3> : BaseSignal<ICommand<T1, T2, T3>, Action<T1, T2, T3>>
    {
        public void Dispatch( T1 arg1, T2 arg2, T3 arg3 )
        {
            for ( int i = 0; i < m_commands.Count; i++ )
            {
                m_commands[i].Execute( arg1, arg2, arg3 );
            }

            for ( int i = 0; i < m_listeners.Count; i++ )
            {
                m_listeners[i].Invoke( arg1, arg2, arg3 );
            }
        }
    }

    public class Signal<T1, T2, T3, T4> : BaseSignal<ICommand<T1, T2, T3, T4>, Action<T1, T2, T3, T4>>
    {
        public void Dispatch( T1 arg1, T2 arg2, T3 arg3, T4 arg4 )
        {
            for ( int i = 0; i < m_commands.Count; i++ )
            {
                m_commands[i].Execute( arg1, arg2, arg3, arg4 );
            }

            for ( int i = 0; i < m_listeners.Count; i++ )
            {
                m_listeners[i].Invoke( arg1, arg2, arg3, arg4 );
            }
        }
    }
}