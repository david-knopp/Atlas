namespace Atlas
{
    public struct GraphConnection : IGraphConnection
    {
        public GraphConnection( int fromNodeID, int toNodeID, float weight )
        {
            FromNodeID = fromNodeID;
            ToNodeID = toNodeID;
            Weight = weight;
        }

        public int FromNodeID { get; set; }
        public int ToNodeID { get; set; }
        public float Weight { get; set; }

        public GraphConnection Reversed
        {
            get => new GraphConnection( ToNodeID, FromNodeID, Weight );
        }

        public void Reverse()
        {
            int originalFromID = FromNodeID;
            FromNodeID = ToNodeID;
            ToNodeID = originalFromID;
        }
    }
}
