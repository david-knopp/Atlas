using System;
using System.Collections.Generic;
using System.Linq;

namespace Atlas
{
    /// <summary>
    /// A graph of nodes connected by directed connections with associated connection weights
    /// </summary>
    public class DirectedGraph<TNode, TConnection>
        where TNode : IGraphNode
        where TConnection : struct, IGraphConnection
    {
        #region public

        #region nodes

        /// <summary>
        /// The nodes of the graph by ID
        /// </summary>
        public IReadOnlyDictionary<int, TNode> Nodes => m_nodes;

        /// <summary>
        /// Fetches the node in the graph with the given ID
        /// </summary>
        /// <param name="nodeID">The ID of the node to fetch</param>
        /// <returns>The node with the given ID</returns>
        /// <exception cref="KeyNotFoundException">Thrown if there's no node with the given ID</exception>
        public TNode this[int nodeID]
        {
            get
            {
                if ( TryGetNode( nodeID, out var node ) )
                {
                    return node;
                }

                throw new KeyNotFoundException(
                    $"Graph doesn't contain a node with ID `{nodeID}`" );
            }

            set
            {
                m_nodes[nodeID] = value;
            }
        }

        /// <summary>
        /// Adds the node to the graph
        /// </summary>
        /// <param name="node">The node to add</param>
        /// <exception cref="ArgumentException">Thrown if a node with the same ID as the given node's is already present in the graph</exception>
        public void AddNode( TNode node )
        {
            if ( m_nodes.ContainsKey( node.ID ) )
            {
                throw new ArgumentException( $"A node with ID {node.ID} has already been added to the graph." );
            }

            m_nodes.Add( node.ID, node );
        }

        /// <summary>
        /// Determines whether or not a node with the given ID exists in the graph
        /// </summary>
        /// <param name="nodeID">The ID of the node to look for</param>
        /// <returns>True if a node with the given ID is present, false otherwise</returns>
        public bool ContainsNode( int nodeID )
        {
            return m_nodes.ContainsKey( nodeID );
        }

        /// <summary>
        /// Removes the node with the given ID
        /// </summary>
        /// <param name="nodeID">The ID of the node to remove</param>
        /// <returns>True if a node was removed, false otherwise</returns>
        public bool RemoveNode( int nodeID )
        {
            return m_nodes.Remove( nodeID );
        }

        /// <summary>
        /// Attempts to fetch the node with the given ID
        /// </summary>
        /// <param name="nodeID">The ID of the node to get</param>
        /// <param name="node">The found node, if successful</param>
        /// <returns>True if a node was found, false otherwise</returns>
        public bool TryGetNode( int nodeID, out TNode node )
        {
            return m_nodes.TryGetValue( nodeID, out node );
        }

        #endregion nodes

        #region connections

        /// <summary>
        /// accessors for the outgoing connection from <paramref name="fromNodeID"/> to <paramref name="toNodeID"/>
        /// </summary>
        /// <param name="fromNodeID">The ID of the connection's start node</param>
        /// <param name="toNodeID">The ID of the connection's end node</param>
        /// <returns>The connection from <paramref name="fromNodeID"/> to <paramref name="toNodeID"/></returns>
        /// <exception cref="KeyNotFoundException">Thrown if either of the given IDs doesn't exist in the graph</exception>
        public TConnection this[int fromNodeID, int toNodeID]
        {
            get
            {
                if ( TryGetConnection( fromNodeID, toNodeID, out var connection ) )
                {
                    return connection;
                }

                throw new KeyNotFoundException(
                    $"Graph doesn't contain a connection from node `{fromNodeID}` to node `{toNodeID}`" );
            }

            set
            {
                var connections = GetOrAddOutgoingConnections( fromNodeID );

                int currentIndex = connections.FindIndex( x => x.ToNodeID == toNodeID );
                if ( currentIndex >= 0 )
                {
                    connections[currentIndex] = value;
                }
                else
                {
                    connections.Add( value );
                }
            }
        }

        /// <summary>
        /// Adds the given connection to the graph
        /// </summary>
        /// <param name="connection">Connection to add</param>
        /// <exception cref="InvalidOperationException">Thrown if a connection with the same start & end is already present</exception>
        public void AddConnection( TConnection connection )
        {
            var connections = GetOrAddOutgoingConnections( connection.FromNodeID );

            if ( connections.Any( x => x.ToNodeID == connection.ToNodeID ) )
            {
                throw new InvalidOperationException(
                    $"A connection from node `{connection.FromNodeID}` to node `{connection.ToNodeID}` already exists in the graph" );
            }
            else
            {
                connections.Add( connection );
            }
        }

        /// <summary>
        /// Adds a connection between the given nodes, with the given weight
        /// </summary>
        /// <param name="fromNode">ID of the starting node for the connection</param>
        /// <param name="toNode">ID of the ending node for the connection</param>
        /// <param name="weight">Cost for traversing this connection</param>
        public void AddConnection( int fromNode, int toNode, float weight )
        {
            AddConnection( new TConnection
            {
                FromNodeID = fromNode,
                ToNodeID = toNode,
                Weight = weight
            } );
        }

        /// <summary>
        /// Adds a connection going in both directions between the given nodes.
        /// This is the same as adding a connection both 
        /// from <paramref name="nodeA"/> to <paramref name="nodeB"/>, and a connection
        /// from <paramref name="nodeB"/> to <paramref name="nodeA"/>, and is simply
        /// for convenience
        /// </summary>
        /// <param name="nodeA">The ID of the first node</param>
        /// <param name="nodeB">The ID of the second node</param>
        /// <param name="weight">Cost for traversing either connection</param>
        public void AddBiDirectionalConnection( int nodeA, int nodeB, float weight )
        {
            AddConnection( nodeA, nodeB, weight );
            AddConnection( nodeB, nodeA, weight );
        }

        /// <summary>
        /// Whether or not the graph has a connection from <paramref name="fromNode"/> to <paramref name="toNode"/>
        /// </summary>
        /// <param name="fromNode">The ID of the starting node</param>
        /// <param name="toNode">The ID of the ending node</param>
        /// <returns>True if a connection exists, false otherwise</returns>
        public bool HasConnection( int fromNode, int toNode )
        {
            if ( m_outgoingConnections.TryGetValue( fromNode, out var connections ) )
            {
                return connections.Any( x => x.ToNodeID == toNode );
            }

            return false;
        }

        /// <summary>
        /// Attempts to get a connection from <paramref name="fromNode"/> to <paramref name="toNode"/>, if it exists
        /// </summary>
        /// <param name="fromNode">The ID of the starting node</param>
        /// <param name="toNode">The ID of the ending node</param>
        /// <param name="connection">The connection, if found</param>
        /// <returns>True if a connection was found, false otherwise</returns>
        public bool TryGetConnection( int fromNode, int toNode, out TConnection connection )
        {
            if ( m_outgoingConnections.TryGetValue( fromNode, out var connections ) )
            {
                int connectionIndex = connections.FindIndex( x => x.ToNodeID == toNode );
                if ( connectionIndex >= 0 )
                {
                    connection = connections[connectionIndex];
                    return true;
                }
            }

            connection = default;
            return false;
        }

        /// <summary>
        /// Attempts to get all connections that start at the given node
        /// </summary>
        /// <param name="fromNode">The starting node</param>
        /// <param name="connections">All connections originating from <paramref name="fromNode"/></param>
        /// <returns>True if any connections were found, false otherwise</returns>
        public bool TryGetOutgoingConnections( int fromNode, out IReadOnlyList<TConnection> connections )
        {
            if ( m_outgoingConnections.TryGetValue( fromNode, out var outgoingConnections ) )
            {
                connections = outgoingConnections;
                return true;
            }

            connections = default;
            return false;
        }

        #endregion connections

        #endregion public

        #region private

        private readonly Dictionary<int, TNode> m_nodes = new Dictionary<int, TNode>();
        private readonly Dictionary<int, List<TConnection>> m_outgoingConnections =
            new Dictionary<int, List<TConnection>>();

        private List<TConnection> GetOrAddOutgoingConnections( int fromNodeID )
        {
            if ( m_outgoingConnections.TryGetValue( fromNodeID, out var connections ) == false )
            {
                connections = new List<TConnection>();
                m_outgoingConnections[fromNodeID] = connections;
            }

            return connections;
        }

        #endregion private
    }
}
