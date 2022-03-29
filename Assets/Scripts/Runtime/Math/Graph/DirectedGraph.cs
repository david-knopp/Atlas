using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Atlas
{
    /// <summary>
    /// A graph of nodes connected by directed connections with associated connection weights
    /// </summary>
    public class DirectedGraph<TNode, TConnection>
        where TNode : IGraphNode
        where TConnection : IGraphConnection, new()
    {
        public IReadOnlyDictionary<int, TNode> Nodes => m_nodes;

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

        public void AddConnection( TConnection connection )
        {
            if ( m_outgoingConnections.TryGetValue( connection.FromNodeID, out var connections ) == false )
            {
                connections = new List<TConnection>();
                m_outgoingConnections[connection.FromNodeID] = connections;
            }

            int currentIndex = connections.FindIndex( x => x.ToNodeID == connection.ToNodeID );
            if ( currentIndex >= 0 )
            {
                connections[currentIndex] = connection;
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

        private readonly Dictionary<int, TNode> m_nodes = new Dictionary<int, TNode>();
        private readonly Dictionary<int, List<TConnection>> m_outgoingConnections = new Dictionary<int, List<TConnection>>();
    }
}
