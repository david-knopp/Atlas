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

        private short fart;

        public AStar( Heuristic heuristic )
        {
            m_openList = new IndexedPriorityQueue<NodeRecord>();
            m_nodes = new Dictionary<int, NodeRecord>();
            m_heuristic = heuristic;
        }

        public SearchStatus Search( Graph<NodeType> graph, int startID, int endID, ref List<GraphEdge> path )
        {
            Assert.IsTrue( startID != NodeRecord.InvalidID, "AStar.Search: Invalid start ID given" );
            Assert.IsTrue( endID != NodeRecord.InvalidID, "AStar.Search: Invalid end ID given" );
            Assert.IsTrue( graph != null, "AStar.Search: graph is null" );
            Assert.IsTrue( path != null, "AStar.Search: output path is null" );

            Initialize( graph, startID, endID );

            SearchStatus status = SearchStatus.Failure;

            while ( m_openList.Count > 0 )
            {
                // get next best node
                NodeRecord curNode = m_openList.Pop();
                curNode.m_status = NodeRecord.Status.Closed;

                // stop if at end
                if ( curNode.m_nodeID == endID )
                {
                    status = SearchStatus.Success;
                    break;
                }

                // visit neighbors
                List<GraphEdge> edges = graph.GetEdges( curNode.m_nodeID );
                for ( int i = 0; i < edges.Count; ++i )
                {

                }
            }

            return status;
        }
        #endregion // public

        #region private
        private IndexedPriorityQueue<NodeRecord> m_openList;
        private Dictionary<int, NodeRecord> m_nodes;
        private Heuristic m_heuristic;

        private void Initialize( Graph<NodeType> graph, int startID, int endID )
        {
            m_openList.Resize( graph.NodeCount );

            // create initial record
            NodeRecord startRecord = new NodeRecord()
            {
                m_edge = new GraphEdge( startID, startID, 0.0f ),
                m_status = NodeRecord.Status.Open,
                m_costSoFar = 0.0f,
                m_totalEstimate = m_heuristic( graph.GetNode( startID ), graph.GetNode( endID ) ),
                m_nodeID = startID
            };

            // add record
            m_nodes.Add( startID, startRecord );
            m_openList.Insert( startID, startRecord );
        }

        private void VisitNode( Graph<NodeType> graph, GraphEdge edge, NodeRecord parent )
        {
            int nodeID = edge.To;
            float cost = parent.m_costSoFar + edge.Cost;

            // node already has record
            if ( m_nodes.ContainsKey( nodeID ) )
            {
                NodeRecord record = m_nodes[nodeID];

                // update record if this path is better
                if ( record.m_status == NodeRecord.Status.Open &&
                     cost < record.m_costSoFar )
                {
                    float heuristicCost = record.m_totalEstimate - record.m_costSoFar;

                    record.m_costSoFar = cost;
                    record.m_totalEstimate = cost + heuristicCost;
                    record.m_nodeID = nodeID;
                    record.m_edge = edge;

                    m_openList.DecreaseIndex( nodeID, record );
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
                    //m_totalEstimate = cost + m_heuristic( graph.GetNode( nodeID ), graph.GetNode( endID ) ),
                    //m_nodeID = startID
                };
            }
        }
        #endregion // private
    }
}