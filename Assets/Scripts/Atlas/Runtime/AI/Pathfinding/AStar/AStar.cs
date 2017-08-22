using System.Collections.Generic;
using UnityEngine.Assertions;

namespace Atlas
{
    public class AStar<NodeType>
    {
        #region public
        public enum SearchStatus
        {
            Success,
            Failure
        }

        public delegate float Heuristic( NodeType a, NodeType b );

        public AStar( Heuristic heuristic, Graph<NodeType> graph )
        {
            m_openList = new IndexedPriorityQueue<NodeRecord>();
            m_nodes = new Dictionary<int, NodeRecord>();
            m_heuristic = heuristic;
            m_graph = graph;
        }

        public Graph<NodeType> Graph
        {
            get { return m_graph; }
            set { m_graph = value; }
        }

        public SearchStatus Search( int startIndex, int endIndex, ref List<GraphEdge> path )
        {
            // asserts
            Assert.IsTrue( startIndex != NodeRecord.InvalidID, "AStar.Search: Invalid start index given" );
            Assert.IsTrue( endIndex != NodeRecord.InvalidID, "AStar.Search: Invalid end index given" );
            Assert.IsTrue( m_graph != null, "AStar.Search: graph is null" );
            Assert.IsTrue( path != null, "AStar.Search: output path is null" );

            // init search
            Initialize( startIndex, endIndex );
            NodeType goalNode = m_graph.Nodes[endIndex];
            SearchStatus status = SearchStatus.Failure;

            // perform search
            while ( m_openList.Count > 0 )
            {
                // get next best node
                NodeRecord nodeRecord = m_openList.Pop();
                nodeRecord.m_status = NodeRecord.Status.Closed;

                // stop if at end
                if ( nodeRecord.m_nodeIndex == endIndex )
                {
                    status = SearchStatus.Success;

                    // build path
                    int nodeIndex = endIndex;
                    do
                    {
                        NodeRecord record = m_nodes[nodeIndex];
                        path.Add( record.m_edge );
                        nodeIndex = record.m_edge.StartIndex;
                    } while ( nodeIndex != startIndex );

                    path.Reverse();
                    break;
                }

                // visit neighbors
                List<GraphEdge> edges = m_graph.GetEdges( nodeRecord.m_nodeIndex );
                for ( int i = 0; i < edges.Count; ++i )
                {
                    GraphEdge edge = edges[i];
                    TraverseEdge( edge, nodeRecord, goalNode );
                }
            }

            return status;
        }
        #endregion // public

        #region private
        private IndexedPriorityQueue<NodeRecord> m_openList;
        private Dictionary<int, NodeRecord> m_nodes;
        private Graph<NodeType> m_graph;
        private Heuristic m_heuristic;

        private void Initialize( int startIndex, int endIndex )
        {
            m_nodes.Clear();
            m_openList.Clear();

            m_openList.Resize( m_graph.Nodes.Count );

            // create initial record
            NodeRecord startRecord = new NodeRecord()
            {
                m_edge = new GraphEdge( startIndex, startIndex, 0.0f ),
                m_status = NodeRecord.Status.Open,
                m_costSoFar = 0.0f,
                m_totalEstimate = m_heuristic( m_graph.Nodes[startIndex], m_graph.Nodes[endIndex] ),
                m_nodeIndex = startIndex
            };

            // add record
            m_nodes.Add( startIndex, startRecord );
            m_openList.Insert( startIndex, startRecord );
        }

        private void TraverseEdge( GraphEdge edge, NodeRecord parent, NodeType goalNode )
        {
            int endNodeIndex = edge.EndIndex;
            float cost = parent.m_costSoFar + edge.Cost;

            NodeRecord nodeRecord;

            // record already exists
            if ( m_nodes.TryGetValue( endNodeIndex, out nodeRecord ) )
            {
                // update record if this path is better
                if ( nodeRecord.m_status == NodeRecord.Status.Open &&
                     cost < nodeRecord.m_costSoFar )
                {
                    float heuristicCost = nodeRecord.m_totalEstimate - nodeRecord.m_costSoFar;

                    nodeRecord.m_costSoFar = cost;
                    nodeRecord.m_totalEstimate = cost + heuristicCost;
                    nodeRecord.m_nodeIndex = endNodeIndex;
                    nodeRecord.m_edge = edge;

                    m_openList.DecreaseIndex( endNodeIndex, nodeRecord );
                }
            }
            // add new record
            else
            {
                NodeRecord record = new NodeRecord()
                {
                    m_edge = edge,
                    m_status = NodeRecord.Status.Open,
                    m_costSoFar = cost,
                    m_totalEstimate = cost + m_heuristic( m_graph.Nodes[endNodeIndex], goalNode ),
                    m_nodeIndex = endNodeIndex
                };

                m_nodes.Add( endNodeIndex, record );
                m_openList.Insert( endNodeIndex, record );
            }
        }
        #endregion // private
    }
}
