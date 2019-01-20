namespace Atlas
{
    public interface IStateLink
    {
        State NextState { get; }
        bool IsSatisfied { get; }
    }
}