using System;
using System.Collections.Generic;

namespace Atlas
{
    public class SignalManager<TKey>
    {
        #region public
        public SignalManager()
        {
            m_signals = new Dictionary<TKey, ISignal>();
        }

        #region listeners
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
                    throw new InvalidOperationException( string.Format( "SignalManager.AddListener: Argument mismatch when attempting to listen to signal {0} ({1} given, {2} expected)", signalKey.ToString(), listener.GetType().ToString(), signal.GetType().ToString() ) );
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
                    throw new InvalidOperationException( string.Format( "SignalManager.AddListener: Argument mismatch when attempting to listen to signal {0} ({1} given, {2} expected)", signalKey.ToString(), listener.GetType().ToString(), signal.GetType().ToString() ) );
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
                    throw new InvalidOperationException( string.Format( "SignalManager.AddListener: Argument mismatch when attempting to listen to signal {0} ({1} given, {2} expected)", signalKey.ToString(), listener.GetType().ToString(), signal.GetType().ToString() ) );
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
                    throw new InvalidOperationException( string.Format( "SignalManager.AddListener: Argument mismatch when attempting to listen to signal {0} ({1} given, {2} expected)", signalKey.ToString(), listener.GetType().ToString(), signal.GetType().ToString() ) );
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
                    throw new InvalidOperationException( string.Format( "SignalManager.AddListener: Argument mismatch when attempting to listen to signal {0} ({1} given, {2} expected)", signalKey.ToString(), listener.GetType().ToString(), signal.GetType().ToString() ) );
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

        public void RemoveListener( TKey signalKey, Action listener )
        {
            ISignal signal;
            Signal typedSignal;

            // get signal
            if ( m_signals.TryGetValue( signalKey, out signal ) )
            {
                typedSignal = signal as Signal;
                if ( typedSignal == null )
                {
                    throw new InvalidOperationException( string.Format( "SignalManager.RemoveListener: Argument mismatch when attempting to remove listener from signal {0} ({1} given, {2} expected)", signalKey.ToString(), listener.GetType().ToString(), signal.GetType().ToString() ) );
                }

                typedSignal.RemoveListener( listener );
            }
        }

        public void RemoveListener<T>( TKey signalKey, Action<T> listener )
        {
            ISignal signal;

            // get signal
            if ( m_signals.TryGetValue( signalKey, out signal ) )
            {
                Signal<T> typedSignal = signal as Signal<T>;
                if ( typedSignal == null )
                {
                    throw new InvalidOperationException( string.Format( "SignalManager.RemoveListener: Argument mismatch when attempting to remove listener from signal {0} ({1} given, {2} expected)", signalKey.ToString(), listener.GetType().ToString(), signal.GetType().ToString() ) );
                }

                typedSignal.RemoveListener( listener );
            }
        }

        public void RemoveListener<T1, T2>( TKey signalKey, Action<T1, T2> listener )
        {
            ISignal signal;

            // get signal
            if ( m_signals.TryGetValue( signalKey, out signal ) )
            {
                Signal<T1, T2> typedSignal = signal as Signal<T1, T2>;
                if ( typedSignal == null )
                {
                    throw new InvalidOperationException( string.Format( "SignalManager.RemoveListener: Argument mismatch when attempting to remove listener from signal {0} ({1} given, {2} expected)", signalKey.ToString(), listener.GetType().ToString(), signal.GetType().ToString() ) );
                }

                typedSignal.RemoveListener( listener );
            }
        }

        public void RemoveListener<T1, T2, T3>( TKey signalKey, Action<T1, T2, T3> listener )
        {
            ISignal signal;

            // get signal
            if ( m_signals.TryGetValue( signalKey, out signal ) )
            {
                Signal<T1, T2, T3> typedSignal = signal as Signal<T1, T2, T3>;
                if ( typedSignal == null )
                {
                    throw new InvalidOperationException( string.Format( "SignalManager.RemoveListener: Argument mismatch when attempting to remove listener from signal {0} ({1} given, {2} expected)", signalKey.ToString(), listener.GetType().ToString(), signal.GetType().ToString() ) );
                }

                typedSignal.RemoveListener( listener );
            }
        }

        public void RemoveListener<T1, T2, T3, T4>( TKey signalKey, Action<T1, T2, T3, T4> listener )
        {
            ISignal signal;

            // get signal
            if ( m_signals.TryGetValue( signalKey, out signal ) )
            {
                Signal<T1, T2, T3, T4> typedSignal = signal as Signal<T1, T2, T3, T4>;
                if ( typedSignal == null )
                {
                    throw new InvalidOperationException( string.Format( "SignalManager.RemoveListener: Argument mismatch when attempting to remove listener from signal {0} ({1} given, {2} expected)", signalKey.ToString(), listener.GetType().ToString(), signal.GetType().ToString() ) );
                }

                typedSignal.RemoveListener( listener );
            }
        }
        #endregion // listeners

        public void Dispatch( TKey signalKey )
        {
            ISignal signal;

            if ( m_signals.TryGetValue( signalKey, out signal ) )
            {
                Signal typedSignal = signal as Signal;
                if ( typedSignal == null )
                {
                    throw new InvalidOperationException( string.Format( "SignalManager.Dispatch: Argument mismatch when attempting to dispatch signal {0} (0 arguments given, {1} expected)", signalKey.ToString(), signal.GetType().ToString() ) );
                }

                typedSignal.Dispatch();
            }
        }

        public void Dispatch<T>( TKey signalKey, T arg )
        {
            ISignal signal;

            if ( m_signals.TryGetValue( signalKey, out signal ) )
            {
                Signal<T> typedSignal = signal as Signal<T>;
                if ( typedSignal == null )
                {
                    throw new InvalidOperationException( string.Format( "SignalManager.Dispatch: Argument mismatch when attempting to dispatch signal {0} ({1} given, {2} expected)", 
                                                         signalKey.ToString(), typeof( T ).ToString(), signal.GetType().ToString() ) );
                }

                typedSignal.Dispatch( arg );
            }
        }

        public void Dispatch<T1, T2>( TKey signalKey, T1 arg1, T2 arg2 )
        {
            ISignal signal;

            if ( m_signals.TryGetValue( signalKey, out signal ) )
            {
                Signal<T1, T2> typedSignal = signal as Signal<T1, T2>;
                if ( typedSignal == null )
                {
                    throw new InvalidOperationException( string.Format( "SignalManager.Dispatch: Argument mismatch when attempting to dispatch signal {0} ({1}, {2} given, {3} expected)", 
                                                                        signalKey.ToString(), typeof( T1 ).ToString(), typeof( T2 ).ToString(), signal.GetType().ToString() ) );
                }

                typedSignal.Dispatch( arg1, arg2 );
            }
        }

        public void Dispatch<T1, T2, T3>( TKey signalKey, T1 arg1, T2 arg2, T3 arg3 )
        {
            ISignal signal;

            if ( m_signals.TryGetValue( signalKey, out signal ) )
            {
                Signal<T1, T2, T3> typedSignal = signal as Signal<T1, T2, T3>;
                if ( typedSignal == null )
                {
                    throw new InvalidOperationException( string.Format( "SignalManager.Dispatch: Argument mismatch when attempting to dispatch signal {0} ({1}, {2}, {3} given, {4} expected)", 
                                                                        signalKey.ToString(), typeof( T1 ).ToString(), typeof( T2 ).ToString(), typeof( T3 ).ToString(), signal.GetType().ToString() ) );
                }

                typedSignal.Dispatch( arg1, arg2, arg3 );
            }
        }

        public void Dispatch<T1, T2, T3, T4>( TKey signalKey, T1 arg1, T2 arg2, T3 arg3, T4 arg4 )
        {
            ISignal signal;

            if ( m_signals.TryGetValue( signalKey, out signal ) )
            {
                Signal<T1, T2, T3, T4> typedSignal = signal as Signal<T1, T2, T3, T4>;
                if ( typedSignal == null )
                {
                    throw new InvalidOperationException( string.Format( "SignalManager.Dispatch: Argument mismatch when attempting to dispatch signal {0} ({1}, {2}, {3}, {4} given, {5} expected)", 
                                                                        signalKey.ToString(), typeof( T1 ).ToString(), typeof( T2 ).ToString(), typeof( T3 ).ToString(), typeof( T4 ).ToString(), signal.GetType().ToString() ) );
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