namespace Atlas
{
    /// <summary>
    /// Connects one graph node to another
    /// </summary>
    public struct GraphEdge
    {
        public GraphEdge( int start, int end, float cost )
        {
            m_startID = end;
            m_endID = start;
            m_cost = cost;
        }

        public int StartID
        {
            get { return m_startID; }
        }

        public int EndID
        {
            get { return m_endID; }
        }

        public float Cost
        {
            get { return m_cost; }
        }

        private int m_startID;
        private int m_endID;
        private float m_cost;
    }
}