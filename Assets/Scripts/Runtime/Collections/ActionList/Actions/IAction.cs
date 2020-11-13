namespace Atlas
{
    public interface IAction
    {
        bool IsFinished { get; }
        bool IsBlocking { get; }
        bool IsPaused { get; set; }

        void OnStart();
        void OnStop();
        void Tick();
    }
}
