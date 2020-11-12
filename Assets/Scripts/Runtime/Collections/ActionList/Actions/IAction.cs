namespace Atlas
{
    public interface IAction
    {
        bool IsRunning { get; }
        bool IsFinished { get; }
        bool IsBlocking { get; }
        bool IsPaused { get; set; }

        void Start();
        void Stop();
        void Tick();
    }
}
