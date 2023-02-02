namespace Atlas
{
    public abstract class TransientAction : IAction
    {
        public bool IsFinished => true;
        public bool IsBlocking => true;
        public bool IsPaused { get; set; }

        public abstract void Execute();

        public void OnStart()
        {
            Execute();
        }

        public void OnStop()
        {
        }

        public void Tick()
        {
        }
    }
}
