using System;
using System.Collections.Generic;

namespace Atlas
{
    /// <summary>
    /// Represents an A* path search algorithm on a <see cref="DirectedGraph{TNode, TConnection}"/>
    /// </summary>
    /// <typeparam name="TNode">Type of the graph's nodes</typeparam>
    /// <typeparam name="TConnection">Type of connections between nodes</typeparam>
    public class AStar<TNode, TConnection>
        where TNode : IGraphNode
        where TConnection : struct, IGraphConnection
    {
        #region public

        /// <summary>
        /// Search result
        /// </summary>
        public enum Result
        {
            Success = 0,
            Failure = 1
        }

        /// <summary>
        /// Heuristic definition used to estimate the cost of the
        /// cheapest path between nodes
        /// </summary>
        /// <param name="fromNode">The start node to estimate the path from</param>
        /// <param name="toNode">The goal node to estimate the path to</param>
        /// <returns>Estimated cost of the path between the given nodes</returns>
        public delegate float Heuristic( TNode fromNode, TNode toNode );

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="graph">The graph on which to perform searches</param>
        /// <param name="heuristic">The heuristic used to estimate path costs</param>
        public AStar( DirectedGraph<TNode, TConnection> graph, Heuristic heuristic )
        {
            m_graph = graph;
            m_heuristic = heuristic;
            m_openList = new IndexedPriorityQueue<NodeRecord>( graph.Nodes.Count );
        }

        /// <summary>
        /// Finds a path between the given nodes
        /// </summary>
        /// <param name="startNodeID">The node to start the path search from</param>
        /// <param name="endNodeID">The desired goal node</param>
        /// <param name="resultPath">The shortest path between the given nodes, if successful</param>
        /// <returns>Result of the search</returns>
        /// <exception cref="ArgumentNullException">Thrown when the provided <paramref name="resultPath"/> list is null</exception>
        public Result Search( int startNodeID, int endNodeID, List<TConnection> resultPath )
        {
            if ( resultPath == null )
            {
                throw new ArgumentNullException( "resultPath list cannot be null" );
            }

            m_nodes.Clear();
            m_openList.Clear();
            m_nextNodeIndex = 0;

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
                NodeIndex = m_nextNodeIndex++,
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
            m_openList.Insert( startRecord.NodeIndex, startRecord );

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
                                m_openList.Insert( nodeRecord.NodeIndex, nodeRecord );
                            }
                            else if ( nodeRecord.CurrentStatus == NodeRecord.Status.Open )
                            {
                                m_openList.DecreaseValueAtIndex( nodeRecord.NodeIndex, nodeRecord );
                            }
                        }
                        // first time seeing this node
                        else
                        {
                            nodeRecord = new NodeRecord()
                            {
                                NodeID = nodeID,
                                NodeIndex = m_nextNodeIndex++,
                                CurrentStatus = NodeRecord.Status.Open,
                                CostSoFar = cost,
                                TotalCostEstimate = cost + m_heuristic.Invoke( startNode, endNode ),
                                Connection = connection
                            };

                            m_nodes.Add( nodeID, nodeRecord );
                            m_openList.Insert( nodeRecord.NodeIndex, nodeRecord );
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
            public int NodeIndex;

            public int CompareTo( NodeRecord other )
            {
                return TotalCostEstimate.CompareTo( other.TotalCostEstimate );
            }
        }

        private readonly Dictionary<int, NodeRecord> m_nodes = new Dictionary<int, NodeRecord>();
        private readonly IndexedPriorityQueue<NodeRecord> m_openList;
        private readonly DirectedGraph<TNode, TConnection> m_graph;
        private readonly Heuristic m_heuristic;
        private int m_nextNodeIndex = 0;

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
