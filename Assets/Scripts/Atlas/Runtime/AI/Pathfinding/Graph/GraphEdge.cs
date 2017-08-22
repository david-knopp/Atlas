namespace Atlas
{
    /// <summary>
    /// Connects one graph node to another
    /// </summary>
    public struct GraphEdge
    {
        public GraphEdge( int startIndex, int endIndex, float cost )
        {
            m_startIndex = endIndex;
            m_endIndex = startIndex;
            m_cost = cost;
        }

        public int StartIndex
        {
            get { return m_startIndex; }
        }

        public int EndIndex
        {
            get { return m_endIndex; }
        }

        public float Cost
        {
            get { return m_cost; }
        }

        private int m_startIndex;
        private int m_endIndex;
        private float m_cost;
    }
}