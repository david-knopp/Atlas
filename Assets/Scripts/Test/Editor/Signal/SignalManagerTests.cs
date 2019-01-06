using NUnit.Framework;
using System;

namespace Atlas.Test
{
    public sealed class SignalManagerTests
    {
        [Test]
        public void AddListener()
        {
            SignalManager<int> signalManager = new SignalManager<int>();
            signalManager.AddListener( 0, () => { } );
        }

        [Test]
        public void AddListenerInvalid()
        {
            SignalManager<int> signalManager = new SignalManager<int>();
            signalManager.AddListener( 0, () => { } );
            Assert.That( () => signalManager.AddListener( 0, ( int i ) => { } ), Throws.InvalidOperationException );
        }

        [Test]
        public void Dispatch()
        {
            bool called = false;
            Action listener = () => { called = true; };

            SignalManager<int> signalManager = new SignalManager<int>();
            signalManager.AddListener( 0, listener );
            signalManager.Dispatch( 0 );

            Assert.IsTrue( called == true );
        }

        [Test]
        public void DispatchInvalid()
        {
            SignalManager<int> signalManager = new SignalManager<int>();
            signalManager.AddListener( 0, () => { } );
            Assert.That( () => signalManager.Dispatch( 0, 7 ), Throws.InvalidOperationException );
        }

        [Test, TestCase( 3 )]
        public void Dispatch1Arg( int value )
        {
            int arg = 0;
            Action<int> listener = ( int i ) => { arg = i; };

            SignalManager<int> signalManager = new SignalManager<int>();
            signalManager.AddListener( 0, listener );
            signalManager.Dispatch( 0, 3 );

            Assert.IsTrue( arg == value );
        }

        [Test]
        public void RemoveListener()
        {
            bool called = false;
            Action listener = () => { called = true; };

            SignalManager<int> signalManager = new SignalManager<int>();
            signalManager.AddListener( 0, listener );
            signalManager.RemoveListener( 0, listener );
            signalManager.Dispatch( 0 );

            Assert.IsTrue( called == false );
        }
    }
}
