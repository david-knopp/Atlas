namespace Atlas
{
    public interface IPoolable
    {
        /// <summary>
        /// Called when the object is instantiated from its pool
        /// </summary>
        void OnPoolInstantiate();

        /// <summary>
        /// Called when the object is destroyed and returned to its pool
        /// </summary>
        void OnPoolDestroy();
    }
}
