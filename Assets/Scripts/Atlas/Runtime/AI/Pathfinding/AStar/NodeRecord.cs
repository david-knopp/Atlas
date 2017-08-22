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

        public GraphEdge m_edge; // The edge that led to this node
        public Status m_status; // nodes status in the current search
        public float m_costSoFar; // actual cost accrued along edges leading to this node
        public float m_totalEstimate; // cost so far + heuristic to the goal node
        public int m_nodeIndex; // index of node on the graph
    }
}