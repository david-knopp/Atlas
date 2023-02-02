namespace Atlas
{
    /// <summary>
    /// The atomic units of <see cref="DirectedGraph{TNode, TConnection}"/>s
    /// </summary>
    public interface IGraphNode
    {
        /// <summary>
        /// Unique identifier for the node
        /// </summary>
        int ID { get; }
    }
}
