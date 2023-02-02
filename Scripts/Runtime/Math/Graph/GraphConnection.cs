namespace Atlas
{
    /// <summary>
    /// Represents a connection between two nodes on a <see cref="DirectedGraph{TNode, TConnection}"/>
    /// </summary>
    public struct GraphConnection : IGraphConnection
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="fromNodeID">Starting node ID</param>
        /// <param name="toNodeID">Ending node ID</param>
        /// <param name="weight">Cost to traverse this connection</param>
        public GraphConnection( int fromNodeID, int toNodeID, float weight )
        {
            FromNodeID = fromNodeID;
            ToNodeID = toNodeID;
            Weight = weight;
        }

        /// <summary>
        /// Starting node ID
        /// </summary>
        public int FromNodeID { get; set; }

        /// <summary>
        /// Ending node ID
        /// </summary>
        public int ToNodeID { get; set; }

        /// <summary>
        /// Cost to traverse this connection
        /// </summary>
        public float Weight { get; set; }

        /// <summary>
        /// Creates a connection going in the opposite direction of this connection
        /// </summary>
        public GraphConnection Reversed
        {
            get => new GraphConnection( ToNodeID, FromNodeID, Weight );
        }

        /// <summary>
        /// Flips the direction of the connection
        /// </summary>
        public void Reverse()
        {
            int originalFromID = FromNodeID;
            FromNodeID = ToNodeID;
            ToNodeID = originalFromID;
        }
    }
}
