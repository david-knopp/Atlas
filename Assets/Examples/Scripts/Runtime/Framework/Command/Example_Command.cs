namespace Atlas.Examples
{
    public sealed class Example_Command
    {
        // command declaration
        public struct ExampleCommand : ICommand<float>
        {
            public void Execute( float value )
            {
                UnityEngine.Debug.LogFormat( "Command executed with value of {0}", value );
            }
        }

        public void OnInjectDependencies( Signal<float> exampleSignal )
        {
            // instantiate a command object
            ExampleCommand command = new ExampleCommand();

            // register a command as a listener of the signal
            exampleSignal.AddCommand( command );

            // ...
            // further calls to exampleSignal.Dispatch( float value ) will also
            // invoke command.Execute( float value )
        }
    }
}