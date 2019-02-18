namespace Atlas
{
    /// <summary>
    /// Interface for tasks used when scheduling execution
    /// </summary>
    /// <seealso cref="TaskScheduler"/>
    public interface IScheduledTask
    {
        void ScheduledTick();
    }
}
