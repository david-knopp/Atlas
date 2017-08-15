namespace Atlas
{
    /// <summary>
    /// Connects one graph node to another
    /// </summary>
    public struct GraphEdge
    {
        public GraphEdge( int from, int to, float cost )
        {
            m_to = to;
            m_from = from;
            m_cost = cost;
        }

        public int To
        {
            get { return m_to; }
        }

        public int From
        {
            get { return m_from; }
        }

        public float Cost
        {
            get { return m_cost; }
        }

        private int m_to;
        private int m_from;
        private float m_cost;
    }
}