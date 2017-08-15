using System;
using System.Collections.Generic;

namespace Atlas
{
    /// <summary>
    /// Keeps record of a node for A*
    /// </summary>
    public struct NodeRecord : IComparable<NodeRecord>
    {
        public const int InvalidID = -1;

        public enum Status
        {
            None,
            Open,
            Closed
        }

        public int CompareTo( NodeRecord other )
        {
            return Comparer<float>.Default.Compare( m_totalEstimate, other.m_totalEstimate );
        }

        public GraphEdge m_edge;
        public Status m_status;
        public float m_costSoFar;
        public float m_totalEstimate;
        public int m_nodeID;
    }
}