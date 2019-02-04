using System;

namespace Atlas
{
    /// <summary>
    /// Zero-argument signal
    /// </summary>
    public class Signal : SignalBase<ICommand, Action>
    {
        /// <summary>
        /// Invokes the signal, calling all registered callback methods/commands
        /// </summary>
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

    /// <summary>
    /// Single-argument signal
    /// </summary>
    /// <typeparam name="T">Type of the signal's argument</typeparam>
    public class Signal<T> : SignalBase<ICommand<T>, Action<T>>
    {
        /// <summary>
        /// Invokes the signal, calling all registered callback methods/commands
        /// </summary>
        /// <param name="arg">Argument to pass to the callbacks</param>
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

    /// <summary>
    /// Two-argument signal
    /// </summary>
    /// <typeparam name="T1">First argument type</typeparam>
    /// <typeparam name="T2">Second argument type</typeparam>
    public class Signal<T1, T2> : SignalBase<ICommand<T1, T2>, Action<T1, T2>>
    {
        /// <summary>
        /// Invokes the signal, calling all registered callback methods/commands
        /// </summary>
        /// <param name="arg1">First argument to pass to the callbacks</param>
        /// <param name="arg2">Second argument to pass to the callbacks</param>
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

    /// <summary>
    /// Three-argument signal
    /// </summary>
    /// <typeparam name="T1">First argument type</typeparam>
    /// <typeparam name="T2">Second argument type</typeparam>
    /// <typeparam name="T3">Third argument type</typeparam>
    public class Signal<T1, T2, T3> : SignalBase<ICommand<T1, T2, T3>, Action<T1, T2, T3>>
    {
        /// <summary>
        /// Invokes the signal, calling all registered callback methods/commands
        /// </summary>
        /// <param name="arg1">First argument to pass to the callbacks</param>
        /// <param name="arg2">Second argument to pass to the callbacks</param>
        /// <param name="arg3">Third argument to pass to the callbacks</param>
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

    /// <summary>
    /// Four-argument signal
    /// </summary>
    /// <typeparam name="T1">First argument type</typeparam>
    /// <typeparam name="T2">Second argument type</typeparam>
    /// <typeparam name="T3">Third argument type</typeparam>
    /// <typeparam name="T4">Fourth argument</typeparam>
    public class Signal<T1, T2, T3, T4> : SignalBase<ICommand<T1, T2, T3, T4>, Action<T1, T2, T3, T4>>
    {
        /// <summary>
        /// Invokes the signal, calling all registered callback methods/commands
        /// </summary>
        /// <param name="arg1">First argument to pass to the callbacks</param>
        /// <param name="arg2">Second argument to pass to the callbacks</param>
        /// <param name="arg3">Third argument to pass to the callbacks</param>
        /// <param name="arg4">Fourth argument to pass to the callbacks</param>
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