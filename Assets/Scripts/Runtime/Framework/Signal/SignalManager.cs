using System;
using System.Collections.Generic;

namespace Atlas
{
    /// <summary>
    /// A simple signal container meant to make dispatching and managing signal listeners across
    /// various systems easier
    /// </summary>
    /// <typeparam name="TKey">Type of key to use for identifying signals</typeparam>
    public class SignalManager<TKey>
    {
        #region public
        /// <summary>
        /// Constructor
        /// </summary>
        public SignalManager()
        {
            m_signals = new Dictionary<TKey, ISignal>();
        }

        #region listeners
        /// <summary>
        /// Adds a zero-argument callback to the signal with the given key
        /// </summary>
        /// <param name="signalKey">Key for the desired signal</param>
        /// <param name="listener">Callback to register as a listener</param>
        /// <exception cref="InvalidOperationException">Thrown when there is an argument mismatch between the listener and the signal</exception>
        public void AddListener( TKey signalKey, Action listener )
        {
            ISignal signal;
            Signal typedSignal;

            // get signal
            if ( m_signals.TryGetValue( signalKey, out signal ) )
            {
                typedSignal = signal as Signal;
                if ( typedSignal == null )
                {
                    throw new InvalidOperationException( string.Format( "SignalManager.AddListener: Argument mismatch when attempting to listen to signal {0} ({1} given, {2} expected)", 
                                                                        signalKey.ToString(), 
                                                                        listener.GetType().ToString(), 
                                                                        signal.GetType().ToString() ) );
                }
            }
            // add new signal
            else
            {
                typedSignal = new Signal();
                m_signals.Add( signalKey, typedSignal );
            }

            // add listener
            typedSignal.AddListener( listener );
        }

        /// <summary>
        /// Adds a single-argument callback to the signal with the given key
        /// </summary>
        /// <typeparam name="T">Type of the signal's argument</typeparam>
        /// <param name="signalKey">Key for the desired signal</param>
        /// <param name="listener">Callback to register as a listener</param>
        /// <exception cref="InvalidOperationException">Thrown when there is an argument mismatch between the listener and the signal</exception>
        public void AddListener<T>( TKey signalKey, Action<T> listener )
        {
            ISignal signal;
            Signal<T> typedSignal;

            // get signal
            if ( m_signals.TryGetValue( signalKey, out signal ) )
            {
                typedSignal = signal as Signal<T>;
                if ( typedSignal == null )
                {
                    throw new InvalidOperationException( string.Format( "SignalManager.AddListener: Argument mismatch when attempting to listen to signal {0} ({1} given, {2} expected)", 
                                                                        signalKey.ToString(), 
                                                                        listener.GetType().ToString(), 
                                                                        signal.GetType().ToString() ) );
                }
            }
            // add new signal
            else
            {
                typedSignal = new Signal<T>();
                m_signals.Add( signalKey, typedSignal );
            }

            // add listener
            typedSignal.AddListener( listener );
        }

        /// <summary>
        /// Adds a two-argument callback to the signal with the given key
        /// </summary>
        /// <typeparam name="T1">Type of the signal's first argument</typeparam>
        /// <typeparam name="T2">Type of the signal's second argument</typeparam>
        /// <param name="signalKey">Key for the desired signal</param>
        /// <param name="listener">Callback to register as a listener</param>
        /// <exception cref="InvalidOperationException">Thrown when there is an argument mismatch between the listener and the signal</exception>
        public void AddListener<T1, T2>( TKey signalKey, Action<T1, T2> listener )
        {
            ISignal signal;
            Signal<T1, T2> typedSignal;

            // get signal
            if ( m_signals.TryGetValue( signalKey, out signal ) )
            {
                typedSignal = signal as Signal<T1, T2>;
                if ( typedSignal == null )
                {
                    throw new InvalidOperationException( string.Format( "SignalManager.AddListener: Argument mismatch when attempting to listen to signal {0} ({1} given, {2} expected)", 
                                                                        signalKey.ToString(), 
                                                                        listener.GetType().ToString(), 
                                                                        signal.GetType().ToString() ) );
                }
            }
            // add new signal
            else
            {
                typedSignal = new Signal<T1, T2>();
                m_signals.Add( signalKey, typedSignal );
            }

            // add listener
            typedSignal.AddListener( listener );
        }

        /// <summary>
        /// Adds a three-argument callback to the signal with the given key
        /// </summary>
        /// <typeparam name="T1">Type of the signal's first argument</typeparam>
        /// <typeparam name="T2">Type of the signal's second argument</typeparam>
        /// <typeparam name="T3">Type of the signal's third argument</typeparam>
        /// <param name="signalKey">Key for the desired signal</param>
        /// <param name="listener">Callback to register as a listener</param>
        /// <exception cref="InvalidOperationException">Thrown when there is an argument mismatch between the listener and the signal</exception>
        public void AddListener<T1, T2, T3>( TKey signalKey, Action<T1, T2, T3> listener )
        {
            ISignal signal;
            Signal<T1, T2, T3> typedSignal;

            // get signal
            if ( m_signals.TryGetValue( signalKey, out signal ) )
            {
                typedSignal = signal as Signal<T1, T2, T3>;
                if ( typedSignal == null )
                {
                    throw new InvalidOperationException( string.Format( "SignalManager.AddListener: Argument mismatch when attempting to listen to signal {0} ({1} given, {2} expected)", 
                                                                        signalKey.ToString(), 
                                                                        listener.GetType().ToString(), 
                                                                        signal.GetType().ToString() ) );
                }
            }
            // add new signal
            else
            {
                typedSignal = new Signal<T1, T2, T3>();
                m_signals.Add( signalKey, typedSignal );
            }

            // add listener
            typedSignal.AddListener( listener );
        }

        /// <summary>
        /// Adds a four-argument callback to the signal with the given key
        /// </summary>
        /// <typeparam name="T1">Type of the signal's first argument</typeparam>
        /// <typeparam name="T2">Type of the signal's second argument</typeparam>
        /// <typeparam name="T3">Type of the signal's third argument</typeparam>
        /// <typeparam name="T4">Type of the signal's fourth argument</typeparam>
        /// <param name="signalKey">Key for the desired signal</param>
        /// <param name="listener">Callback to register as a listener</param>
        /// <exception cref="InvalidOperationException">Thrown when there is an argument mismatch between the listener and the signal</exception>
        public void AddListener<T1, T2, T3, T4>( TKey signalKey, Action<T1, T2, T3, T4> listener )
        {
            ISignal signal;
            Signal<T1, T2, T3, T4> typedSignal;

            // get signal
            if ( m_signals.TryGetValue( signalKey, out signal ) )
            {
                typedSignal = signal as Signal<T1, T2, T3, T4>;
                if ( typedSignal == null )
                {
                    throw new InvalidOperationException( string.Format( "SignalManager.AddListener: Argument mismatch when attempting to listen to signal {0} ({1} given, {2} expected)", 
                                                                        signalKey.ToString(), 
                                                                        listener.GetType().ToString(), 
                                                                        signal.GetType().ToString() ) );
                }
            }
            // add new signal
            else
            {
                typedSignal = new Signal<T1, T2, T3, T4>();
                m_signals.Add( signalKey, typedSignal );
            }

            // add listener
            typedSignal.AddListener( listener );
        }
        
        /// <summary>
        /// Removes a zero-argument callback from the signal with the given key
        /// </summary>
        /// <param name="signalKey">Key for the desired signal</param>
        /// <param name="listener">Callback to unregister</param>
        /// <exception cref="InvalidOperationException">Thrown when there is an argument mismatch between the listener and the signal</exception>
        public void RemoveListener( TKey signalKey, Action listener )
        {
            ISignal signal;

            // get signal
            if ( m_signals.TryGetValue( signalKey, out signal ) )
            {
                Signal typedSignal = signal as Signal;
                if ( typedSignal == null )
                {
                    throw new InvalidOperationException( string.Format( "SignalManager.RemoveListener: Argument mismatch when attempting to remove listener from signal {0} ({1} given, {2} expected)", 
                                                                        signalKey.ToString(), 
                                                                        listener.GetType().ToString(), 
                                                                        signal.GetType().ToString() ) );
                }

                typedSignal.RemoveListener( listener );
            }
        }

        /// <summary>
        /// Removes a single-argument callback from the signal with the given key
        /// </summary>
        /// <typeparam name="T">Type of the signal's argument</typeparam>
        /// <param name="signalKey">Key for the desired signal</param>
        /// <param name="listener">Callback to unregister</param>
        /// <exception cref="InvalidOperationException">Thrown when there is an argument mismatch between the listener and the signal</exception>
        public void RemoveListener<T>( TKey signalKey, Action<T> listener )
        {
            ISignal signal;

            // get signal
            if ( m_signals.TryGetValue( signalKey, out signal ) )
            {
                Signal<T> typedSignal = signal as Signal<T>;
                if ( typedSignal == null )
                {
                    throw new InvalidOperationException( string.Format( "SignalManager.RemoveListener: Argument mismatch when attempting to remove listener from signal {0} ({1} given, {2} expected)", 
                                                                        signalKey.ToString(), 
                                                                        listener.GetType().ToString(), 
                                                                        signal.GetType().ToString() ) );
                }

                typedSignal.RemoveListener( listener );
            }
        }

        /// <summary>
        /// Removes a two-argument callback from the signal with the given key
        /// </summary>
        /// <typeparam name="T1">Type of the signal's first argument</typeparam>
        /// <typeparam name="T2">Type of the signal's second argument</typeparam>
        /// <param name="signalKey">Key for the desired signal</param>
        /// <param name="listener">Callback to unregister</param>
        /// <exception cref="InvalidOperationException">Thrown when there is an argument mismatch between the listener and the signal</exception>
        public void RemoveListener<T1, T2>( TKey signalKey, Action<T1, T2> listener )
        {
            ISignal signal;

            // get signal
            if ( m_signals.TryGetValue( signalKey, out signal ) )
            {
                Signal<T1, T2> typedSignal = signal as Signal<T1, T2>;
                if ( typedSignal == null )
                {
                    throw new InvalidOperationException( string.Format( "SignalManager.RemoveListener: Argument mismatch when attempting to remove listener from signal {0} ({1} given, {2} expected)", 
                                                                        signalKey.ToString(), 
                                                                        listener.GetType().ToString(), 
                                                                        signal.GetType().ToString() ) );
                }

                typedSignal.RemoveListener( listener );
            }
        }

        /// <summary>
        /// Removes a three-argument callback from the signal with the given key
        /// </summary>
        /// <typeparam name="T1">Type of the signal's first argument</typeparam>
        /// <typeparam name="T2">Type of the signal's second argument</typeparam>
        /// <typeparam name="T3">Type of the signal's third argument</typeparam>
        /// <param name="signalKey">Key for the desired signal</param>
        /// <param name="listener">Callback to unregister</param>
        /// <exception cref="InvalidOperationException">Thrown when there is an argument mismatch between the listener and the signal</exception>
        public void RemoveListener<T1, T2, T3>( TKey signalKey, Action<T1, T2, T3> listener )
        {
            ISignal signal;

            // get signal
            if ( m_signals.TryGetValue( signalKey, out signal ) )
            {
                Signal<T1, T2, T3> typedSignal = signal as Signal<T1, T2, T3>;
                if ( typedSignal == null )
                {
                    throw new InvalidOperationException( string.Format( "SignalManager.RemoveListener: Argument mismatch when attempting to remove listener from signal {0} ({1} given, {2} expected)", 
                                                                        signalKey.ToString(), 
                                                                        listener.GetType().ToString(), 
                                                                        signal.GetType().ToString() ) );
                }

                typedSignal.RemoveListener( listener );
            }
        }

        /// <summary>
        /// Removes a four-argument callback from the signal with the given key
        /// </summary>
        /// <typeparam name="T1">Type of the signal's first argument</typeparam>
        /// <typeparam name="T2">Type of the signal's second argument</typeparam>
        /// <typeparam name="T3">Type of the signal's third argument</typeparam>
        /// <typeparam name="T4">Type of the signal's fourth argument</typeparam>
        /// <param name="signalKey">Key for the desired signal</param>
        /// <param name="listener">Callback to unregister</param>
        /// <exception cref="InvalidOperationException">Thrown when there is an argument mismatch between the listener and the signal</exception>
        public void RemoveListener<T1, T2, T3, T4>( TKey signalKey, Action<T1, T2, T3, T4> listener )
        {
            ISignal signal;

            // get signal
            if ( m_signals.TryGetValue( signalKey, out signal ) )
            {
                Signal<T1, T2, T3, T4> typedSignal = signal as Signal<T1, T2, T3, T4>;
                if ( typedSignal == null )
                {
                    throw new InvalidOperationException( string.Format( "SignalManager.RemoveListener: Argument mismatch when attempting to remove listener from signal {0} ({1} given, {2} expected)", 
                                                                        signalKey.ToString(), 
                                                                        listener.GetType().ToString(),
                                                                        signal.GetType().ToString() ) );
                }

                typedSignal.RemoveListener( listener );
            }
        }
        #endregion // listeners

        /// <summary>
        /// Dispatches the signal with the given key
        /// </summary>
        /// <param name="signalKey">Key of the signal to dispatch</param>
        /// <exception cref="InvalidOperationException">Thrown when there is an argument mismatch with the signal instance associated with the given key</exception>
        public void Dispatch( TKey signalKey )
        {
            ISignal signal;

            if ( m_signals.TryGetValue( signalKey, out signal ) )
            {
                Signal typedSignal = signal as Signal;
                if ( typedSignal == null )
                {
                    throw new InvalidOperationException( string.Format( "SignalManager.Dispatch: Argument mismatch when attempting to dispatch signal {0} (0 arguments given, {1} expected)", 
                                                                        signalKey.ToString(), 
                                                                        signal.GetType().ToString() ) );
                }

                typedSignal.Dispatch();
            }
        }

        /// <summary>
        /// Dispatches the signal with the given key
        /// </summary>
        /// <typeparam name="T">Type of the signal's argument</typeparam>
        /// <param name="signalKey">Key of the signal to dispatch</param>
        /// <param name="arg">Argument to dispatch the signal with</param>
        /// <exception cref="InvalidOperationException">Thrown when there is an argument mismatch with the signal instance associated with the given key</exception>
        public void Dispatch<T>( TKey signalKey, T arg )
        {
            ISignal signal;

            if ( m_signals.TryGetValue( signalKey, out signal ) )
            {
                Signal<T> typedSignal = signal as Signal<T>;
                if ( typedSignal == null )
                {
                    throw new InvalidOperationException( string.Format( "SignalManager.Dispatch: Argument mismatch when attempting to dispatch signal {0} ({1} given, {2} expected)", 
                                                                        signalKey.ToString(), 
                                                                        typeof( T ).ToString(), 
                                                                        signal.GetType().ToString() ) );
                }

                typedSignal.Dispatch( arg );
            }
        }

        /// <summary>
        /// Dispatches the signal with the given key
        /// </summary>
        /// <typeparam name="T1">Type of the signal's first argument</typeparam>
        /// <typeparam name="T2">Type of the signal's second argument</typeparam>
        /// <param name="signalKey">Key of the signal to dispatch</param>
        /// <param name="arg1">First argument to dispatch the signal with</param>
        /// <param name="arg2">Second argument to dispatch the signal with</param>
        /// <exception cref="InvalidOperationException">Thrown when there is an argument mismatch with the signal instance associated with the given key</exception>
        public void Dispatch<T1, T2>( TKey signalKey, T1 arg1, T2 arg2 )
        {
            ISignal signal;

            if ( m_signals.TryGetValue( signalKey, out signal ) )
            {
                Signal<T1, T2> typedSignal = signal as Signal<T1, T2>;
                if ( typedSignal == null )
                {
                    throw new InvalidOperationException( string.Format( "SignalManager.Dispatch: Argument mismatch when attempting to dispatch signal {0} ({1}, {2} given, {3} expected)", 
                                                                        signalKey.ToString(), 
                                                                        typeof( T1 ).ToString(), 
                                                                        typeof( T2 ).ToString(), 
                                                                        signal.GetType().ToString() ) );
                }

                typedSignal.Dispatch( arg1, arg2 );
            }
        }

        /// <summary>
        /// Dispatches the signal with the given key
        /// </summary>
        /// <typeparam name="T1">Type of the signal's first argument</typeparam>
        /// <typeparam name="T2">Type of the signal's second argument</typeparam>
        /// <typeparam name="T3">Type of the signal's third argument</typeparam>
        /// <param name="signalKey">Key of the signal to dispatch</param>
        /// <param name="arg1">First argument to dispatch the signal with</param>
        /// <param name="arg2">Second argument to dispatch the signal with</param>
        /// <param name="arg3">Third argument to dispatch the signal with</param>
        /// <exception cref="InvalidOperationException">Thrown when there is an argument mismatch with the signal instance associated with the given key</exception>
        public void Dispatch<T1, T2, T3>( TKey signalKey, T1 arg1, T2 arg2, T3 arg3 )
        {
            ISignal signal;

            if ( m_signals.TryGetValue( signalKey, out signal ) )
            {
                Signal<T1, T2, T3> typedSignal = signal as Signal<T1, T2, T3>;
                if ( typedSignal == null )
                {
                    throw new InvalidOperationException( string.Format( "SignalManager.Dispatch: Argument mismatch when attempting to dispatch signal {0} ({1}, {2}, {3} given, {4} expected)", 
                                                                        signalKey.ToString(), 
                                                                        typeof( T1 ).ToString(), 
                                                                        typeof( T2 ).ToString(), 
                                                                        typeof( T3 ).ToString(), 
                                                                        signal.GetType().ToString() ) );
                }

                typedSignal.Dispatch( arg1, arg2, arg3 );
            }
        }

        /// <summary>
        /// Dispatches the signal with the given key
        /// </summary>
        /// <typeparam name="T1">Type of the signal's first argument</typeparam>
        /// <typeparam name="T2">Type of the signal's second argument</typeparam>
        /// <typeparam name="T3">Type of the signal's third argument</typeparam>
        /// <typeparam name="T4">Type of the signal's fourth argument</typeparam>
        /// <param name="signalKey">Key of the signal to dispatch</param>
        /// <param name="arg1">First argument to dispatch the signal with</param>
        /// <param name="arg2">Second argument to dispatch the signal with</param>
        /// <param name="arg3">Third argument to dispatch the signal with</param>
        /// <param name="arg4">Fourth argument to dispatch the signal with</param>
        /// <exception cref="InvalidOperationException">Thrown when there is an argument mismatch with the signal instance associated with the given key</exception>
        public void Dispatch<T1, T2, T3, T4>( TKey signalKey, T1 arg1, T2 arg2, T3 arg3, T4 arg4 )
        {
            ISignal signal;

            if ( m_signals.TryGetValue( signalKey, out signal ) )
            {
                Signal<T1, T2, T3, T4> typedSignal = signal as Signal<T1, T2, T3, T4>;
                if ( typedSignal == null )
                {
                    throw new InvalidOperationException( string.Format( "SignalManager.Dispatch: Argument mismatch when attempting to dispatch signal {0} ({1}, {2}, {3}, {4} given, {5} expected)", 
                                                                        signalKey.ToString(), 
                                                                        typeof( T1 ).ToString(), 
                                                                        typeof( T2 ).ToString(), 
                                                                        typeof( T3 ).ToString(), 
                                                                        typeof( T4 ).ToString(), 
                                                                        signal.GetType().ToString() ) );
                }

                typedSignal.Dispatch( arg1, arg2, arg3, arg4 );
            }
        }
        #endregion // public

        #region private
        private Dictionary<TKey, ISignal> m_signals; 
        #endregion // private
    }
}