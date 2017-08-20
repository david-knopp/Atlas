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

        public SearchStatus Search( int startID, int endID, ref List<GraphEdge> path )
        {
            Assert.IsTrue( startID != NodeRecord.InvalidID, "AStar.Search: Invalid start ID given" );
            Assert.IsTrue( endID != NodeRecord.InvalidID, "AStar.Search: Invalid end ID given" );
            Assert.IsTrue( m_graph != null, "AStar.Search: graph is null" );
            Assert.IsTrue( path != null, "AStar.Search: output path is null" );

            Initialize( startID, endID );
            NodeType goalNode = m_graph.GetNode( endID );

            SearchStatus status = SearchStatus.Failure;

            while ( m_openList.Count > 0 )
            {
                // get next best node
                NodeRecord nodeRecord = m_openList.Pop();
                nodeRecord.m_status = NodeRecord.Status.Closed;

                // stop if at end
                if ( nodeRecord.m_nodeID == endID )
                {
                    status = SearchStatus.Success;

                    // build path
                    int nodeID = endID;
                    do
                    {
                        NodeRecord record = m_nodes[nodeID];
                        path.Add( record.m_edge );
                        nodeID = record.m_edge.StartID;
                    } while ( nodeID != startID );

                    path.Reverse();
                    break;
                }

                // visit neighbors
                List<GraphEdge> edges = m_graph.GetEdges( nodeRecord.m_nodeID );
                for ( int i = 0; i < edges.Count; ++i )
                {
                    GraphEdge edge = edges[i];
                    VisitNode( edge, nodeRecord, goalNode );
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

        private void Initialize( int startID, int endID )
        {
            m_nodes.Clear();
            m_openList.Clear();

            m_openList.Resize( m_graph.NodeCount );

            // create initial record
            NodeRecord startRecord = new NodeRecord()
            {
                m_edge = new GraphEdge( startID, startID, 0.0f ),
                m_status = NodeRecord.Status.Open,
                m_costSoFar = 0.0f,
                m_totalEstimate = m_heuristic( m_graph.GetNode( startID ), m_graph.GetNode( endID ) ),
                m_nodeID = startID
            };

            // add record
            m_nodes.Add( startID, startRecord );
            m_openList.Insert( startID, startRecord );
        }

        private void VisitNode( GraphEdge edge, NodeRecord parent, NodeType goalNode )
        {
            int nodeID = edge.StartID;
            float cost = parent.m_costSoFar + edge.Cost;

            NodeRecord nodeRecord;

            // record already exists
            if ( m_nodes.TryGetValue( nodeID, out nodeRecord ) )
            {

                // update record if this path is better
                if ( nodeRecord.m_status == NodeRecord.Status.Open &&
                     cost < nodeRecord.m_costSoFar )
                {
                    float heuristicCost = nodeRecord.m_totalEstimate - nodeRecord.m_costSoFar;

                    nodeRecord.m_costSoFar = cost;
                    nodeRecord.m_totalEstimate = cost + heuristicCost;
                    nodeRecord.m_nodeID = nodeID;
                    nodeRecord.m_edge = edge;

                    m_openList.DecreaseIndex( nodeID, nodeRecord );
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
                    m_totalEstimate = cost + m_heuristic( m_graph.GetNode( nodeID ), goalNode ),
                    m_nodeID = nodeID
                };

                m_nodes.Add( nodeID, record );
                // TODO: This requires that IDs be sequential, but isn't communicated to the user
                // Maybe the graph could manage node id assignment (i.e. an index within an array -- is lookup by id needed for graphs?)
                m_openList.Insert( nodeID, record );
            }
        }
        #endregion // private
    }
}
