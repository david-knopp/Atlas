using System;
using System.Collections.Generic;

namespace Atlas
{
    public class AStar<TNode, TConnection>
        where TNode : IGraphNode
        where TConnection : struct, IGraphConnection
    {
        #region public

        public enum Result
        {
            Success = 0,
            Failure = 1
        }

        public delegate float Heuristic( TNode fromNode, TNode toNode );

        public AStar( DirectedGraph<TNode, TConnection> graph, Heuristic heuristic )
        {
            m_graph = graph;
            m_heuristic = heuristic;
            m_openList = new IndexedPriorityQueue<NodeRecord>( graph.Nodes.Count );
        }

        public Result Search( int startNodeID, int endNodeID, List<TConnection> resultPath )
        {
            if ( resultPath == null )
            {
                throw new ArgumentNullException( "resultPath list cannot be null" );
            }

            m_nodes.Clear();
            m_openList.Clear();

            // verify nodes
            if ( m_graph.TryGetNode( startNodeID, out TNode startNode ) == false ||
                 m_graph.TryGetNode( endNodeID, out TNode endNode ) == false )
            {
                // nodes not on graph
                return Result.Failure;
            }

            // create start node
            NodeRecord startRecord = new NodeRecord()
            {
                NodeID = startNodeID,
                CurrentStatus = NodeRecord.Status.Open,
                CostSoFar = 0f,
                TotalCostEstimate = m_heuristic.Invoke( startNode, endNode ),
                Connection = new TConnection
                {
                    FromNodeID = startNodeID,
                    ToNodeID = startNodeID,
                    Weight = 0f
                }
            };

            m_nodes.Add( startNodeID, startRecord );
            m_openList.Insert( startNodeID, startRecord );

            while ( m_openList.Count > 0 )
            {
                NodeRecord parentRecord = m_openList.Pop();
                parentRecord.CurrentStatus = NodeRecord.Status.Closed;

                if ( parentRecord.NodeID == endNodeID )
                {
                    ConstructPath( startNodeID, endNodeID, resultPath );
                    return Result.Success;
                }

                // traverse all outgoing connections
                if ( m_graph.TryGetOutgoingConnections( parentRecord.NodeID, out var connections ) )
                {
                    foreach ( var connection in connections )
                    {
                        int nodeID = connection.ToNodeID;
                        float cost = parentRecord.CostSoFar + connection.Weight;

                        // node has been visited previously
                        if ( m_nodes.TryGetValue( nodeID, out NodeRecord nodeRecord ) )
                        {
                            if ( cost >= nodeRecord.CostSoFar )
                            {
                                // this path isn't as good as a previous iteration's
                                continue;
                            }

                            float heuristic = nodeRecord.TotalCostEstimate - nodeRecord.CostSoFar;

                            // update node record
                            nodeRecord.CostSoFar = cost;
                            nodeRecord.TotalCostEstimate = cost + heuristic;
                            nodeRecord.Connection = connection;

                            if ( nodeRecord.CurrentStatus == NodeRecord.Status.Closed )
                            {
                                nodeRecord.CurrentStatus = NodeRecord.Status.Open;
                                m_openList.Insert( nodeRecord.NodeID, nodeRecord );
                            }
                            else if ( nodeRecord.CurrentStatus == NodeRecord.Status.Open )
                            {
                                m_openList.DecreaseValueAtIndex( nodeID, nodeRecord );
                            }
                        }
                        // first time seeing this node
                        else
                        {
                            nodeRecord = new NodeRecord()
                            {
                                NodeID = nodeID,
                                CurrentStatus = NodeRecord.Status.Open,
                                CostSoFar = cost,
                                TotalCostEstimate = cost + m_heuristic.Invoke( startNode, endNode ),
                                Connection = connection
                            };

                            m_nodes.Add( nodeID, nodeRecord );
                            m_openList.Insert( nodeRecord.NodeID, nodeRecord );
                        }
                    }
                }
            }

            return Result.Failure;
        }

        #endregion public

        #region private

        private sealed class NodeRecord : IComparable<NodeRecord>
        {
            public enum Status
            {
                Unvisited,
                Open,
                Closed
            }

            public TConnection Connection;
            public float CostSoFar;
            public float TotalCostEstimate;
            public Status CurrentStatus;
            public int NodeID;

            public int CompareTo( NodeRecord other )
            {
                return TotalCostEstimate.CompareTo( other.TotalCostEstimate );
            }
        }

        private readonly Dictionary<int, NodeRecord> m_nodes = new Dictionary<int, NodeRecord>();
        private readonly IndexedPriorityQueue<NodeRecord> m_openList;
        private readonly DirectedGraph<TNode, TConnection> m_graph;
        private readonly Heuristic m_heuristic;

        private void ConstructPath( int startNodeID, int endNodeID, List<TConnection> resultPath )
        {
            resultPath.Clear();

            int currentNodeID = endNodeID;

            do
            {
                NodeRecord record = m_nodes[currentNodeID];
                resultPath.Add( record.Connection );
                currentNodeID = record.Connection.FromNodeID;

            } while ( currentNodeID != startNodeID );

            resultPath.Reverse();
        }

        #endregion private
    }
}
