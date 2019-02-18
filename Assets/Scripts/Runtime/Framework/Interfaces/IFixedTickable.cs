namespace Atlas
{
    /// <summary>
    /// A helper for providing a shared interface for updating objects in Unity's FixedUpdate
    /// </summary>
    public interface IFixedTickable
    {
        /// <summary>
        /// Intended to be called every fixed update cycle
        /// </summary>
        void FixedTick();
    }
}
