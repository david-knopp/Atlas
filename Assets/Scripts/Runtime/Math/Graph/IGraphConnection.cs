namespace Atlas
{
    /// <summary>
    /// Represents a connection between two nodes on a <see cref="DirectedGraph{TNode, TConnection}"/>
    /// </summary>
    public interface IGraphConnection
    {
        /// <summary>
        /// Starting node ID
        /// </summary>
        int FromNodeID { get; set; }

        /// <summary>
        /// Ending node ID
        /// </summary>
        int ToNodeID { get; set; }

        /// <summary>
        /// Cost to traverse this connection
        /// </summary>
        float Weight { get; set; }
    }
}
