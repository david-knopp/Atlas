using System.Collections.Generic;
using System;

namespace Atlas
{
    /// <summary>
    /// Base signal class that provides a shared listener management for simpler derived signals
    /// </summary>
    /// <typeparam name="TCommandBase">Base type of command listeners to allow</typeparam>
    /// <typeparam name="TAction">Type of callback listeners to allow</typeparam>
    public class SignalBase<TCommandBase, TAction> : ISignal
    {
        #region public
        /// <summary>
        /// Constructor
        /// </summary>
        public SignalBase()
        {
            m_commands = new List<TCommandBase>();
            m_listeners = new List<TAction>();
        }

        /// <summary>
        /// Registers the given command instance as a listener
        /// </summary>
        /// <typeparam name="TCommand">Type of command to add</typeparam>
        /// <param name="command">The command instance to register</param>
        public void AddCommand<TCommand>( TCommand command ) where TCommand : TCommandBase
        {
            m_commands.Add( command );
        }

        /// <summary>
        /// Creates and registeres a command as a listener
        /// </summary>
        /// <typeparam name="TCommand">Type of command to add</typeparam>
        public void AddCommand<TCommand>() where TCommand : TCommandBase
        {
            TCommand command = Activator.CreateInstance<TCommand>();
            m_commands.Add( command );
        }

        /// <summary>
        /// Removes all command instances of the given type
        /// </summary>
        /// <typeparam name="TCommand">Type of commands to remove</typeparam>
        public void RemoveCommand<TCommand>() where TCommand : TCommandBase
        {
            m_commands.RemoveAll( ( TCommandBase command ) =>
            {
                return command is TCommand;
            } );
        }

        /// <summary>
        /// Registers the given callback as a listener
        /// </summary>
        /// <param name="listener">Listener instance to register</param>
        public void AddListener( TAction listener )
        {
            m_listeners.Add( listener );
        }

        /// <summary>
        /// Unregisters the given callback as a listener
        /// </summary>
        /// <param name="listener">The callback to unregister</param>
        public void RemoveListener( TAction listener )
        {
            m_listeners.Remove( listener );
        }
        #endregion public

        #region protected
        protected List<TCommandBase> m_commands;
        protected List<TAction> m_listeners; 
        #endregion protected
    }
}
