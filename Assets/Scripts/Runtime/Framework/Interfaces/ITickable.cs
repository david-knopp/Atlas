namespace Atlas
{
    /// <summary>
    /// A helper for providing a shared interface for updating objects
    /// </summary>
    public interface ITickable
    {
        /// <summary>
        /// Intended to be called every update cycle
        /// </summary>
        void Tick();
    }
}