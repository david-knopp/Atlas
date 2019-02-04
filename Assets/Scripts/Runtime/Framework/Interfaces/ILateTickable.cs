namespace Atlas
{
    /// <summary>
    /// A helper for providing a shared interface for updating objects in Unity's LateUpdate
    /// </summary>
    public interface ILateTickable
    {
        /// <summary>
        /// Intended to be called every late update cycle
        /// </summary>
        void LateTick();
    }
}