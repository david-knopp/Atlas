namespace Atlas
{
    public interface ICommand
    {
        void Execute();
    }

    public interface ICommand<T>
    {
        void Execute( T arg );
    }

    public interface ICommand<T1, T2>
    {
        void Execute( T1 arg1, T2 arg2 );
    }

    public interface ICommand<T1, T2, T3>
    {
        void Execute( T1 arg1, T2 arg2, T3 arg3 );
    }

    public interface ICommand<T1, T2, T3, T4>
    {
        void Execute( T1 arg1, T2 arg2, T3 arg3, T4 arg4 );
    }
}