namespace Atlas
{
    /// <summary>
    /// Interface for creating object-based method callbacks 
    /// </summary>
    /// <seealso cref="Signal"/>
    public interface ICommand
    {
        /// <summary>
        /// Executes the object. When registered with a <see cref="Signal"/>, this will get called upon <see cref="Signal.Dispatch"/>
        /// </summary>
        void Execute();
    }

    /// <summary>
    /// Interface for creating object-based method callbacks with a single argument
    /// </summary>
    /// <seealso cref="Signal{T}"/>
    public interface ICommand<T>
    {
        /// <summary>
        /// Executes the object. When registered with a <see cref="Signal{T}"/>, this will get called upon <see cref="Signal{T}.Dispatch"/>
        /// </summary>
        void Execute( T arg );
    }

    /// <summary>
    /// Interface for creating object-based method callbacks with two argument
    /// </summary>
    /// <seealso cref="Signal{T1, T2}"/>
    public interface ICommand<T1, T2>
    {
        /// <summary>
        /// Executes the object. When registered with a <see cref="Signal{T1, T2}"/>, this will get called upon <see cref="Signal{T1, T2}.Dispatch"/>
        /// </summary>
        void Execute( T1 arg1, T2 arg2 );
    }

    /// <summary>
    /// Interface for creating object-based method callbacks with three argument
    /// </summary>
    /// <seealso cref="Signal{T1, T2, T3}"/>
    public interface ICommand<T1, T2, T3>
    {
        /// <summary>
        /// Executes the object. When registered with a <see cref="Signal{T1, T2, T3}"/>, this will get called upon <see cref="Signal{T1, T2, T3}.Dispatch"/>
        /// </summary>
        void Execute( T1 arg1, T2 arg2, T3 arg3 );
    }

    /// <summary>
    /// Interface for creating object-based method callbacks with four argument
    /// </summary>
    /// <seealso cref="Signal{T1, T2, T3, T4}"/>
    public interface ICommand<T1, T2, T3, T4>
    {
        /// <summary>
        /// Executes the object. When registered with a <see cref="Signal{T1, T2, T3, T4}"/>, this will get called upon <see cref="Signal{T1, T2, T3, T4}.Dispatch"/>
        /// </summary>
        void Execute( T1 arg1, T2 arg2, T3 arg3, T4 arg4 );
    }
}