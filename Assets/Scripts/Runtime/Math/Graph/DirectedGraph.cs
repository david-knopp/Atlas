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

        public IReadOnlyDictionary<int, TNode> Nodes => m_nodes;

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

        public void AddNode( TNode node )
        {
            if ( m_nodes.ContainsKey( node.ID ) )
            {
                throw new ArgumentException( $"A node with ID {node.ID} has already been added to the graph." );
            }

            m_nodes.Add( node.ID, node );
        }

        public bool ContainsNode( int nodeID )
        {
            return m_nodes.ContainsKey( nodeID );
        }

        public bool RemoveNode( int nodeID )
        {
            return m_nodes.Remove( nodeID );
        }

        public bool TryGetNode( int nodeID, out TNode node )
        {
            return m_nodes.TryGetValue( nodeID, out node );
        }

        #endregion nodes

        #region connections

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

        public void AddConnection( int fromNode, int toNode, float weight )
        {
            AddConnection( new TConnection
            {
                FromNodeID = fromNode,
                ToNodeID = toNode,
                Weight = weight
            } );
        }

        public void AddBiDirectionalConnection( int nodeA, int nodeB, float weight )
        {
            AddConnection( nodeA, nodeB, weight );
            AddConnection( nodeB, nodeA, weight );
        }

        public bool HasConnection( int fromNode, int toNode )
        {
            if ( m_outgoingConnections.TryGetValue( fromNode, out var connections ) )
            {
                return connections.Any( x => x.ToNodeID == toNode );
            }

            return false;
        }

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

        public bool TryGetOutgoingConnection( int fromNode, int toNode, out TConnection connection )
        {
            if ( TryGetOutgoingConnections( fromNode, out var connections ) )
            {
                foreach ( TConnection c in connections )
                {
                    if ( c.ToNodeID == toNode )
                    {
                        connection = c;
                        return true;
                    }
                }
            }

            connection = default;
            return false;
        }

        #endregion connections

        #endregion public

        #region private

        private readonly Dictionary<int, TNode> m_nodes = new Dictionary<int, TNode>();
        private readonly Dictionary<int, List<TConnection>> m_outgoingConnections = new Dictionary<int, List<TConnection>>();

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
