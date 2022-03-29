namespace Atlas
{
    public interface IGraphConnection
    {
        int FromNodeID { get; set; }
        int ToNodeID { get; set; }
        float Weight { get; set; }
    }
}
