using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Atlas
{
    /// <summary>
    /// A graph of nodes connected by directed connections with associated connection weights
    /// </summary>
    public class DirectedGraph<TNode>
        where TNode : IGraphNode
    {
        public readonly struct Connection
        {
            public Connection( int fromNodeID, int toNodeID, float weight )
            {
                FromNodeID = fromNodeID;
                ToNodeID = toNodeID;
                Weight = weight;
            }

            public readonly int FromNodeID;
            public readonly int ToNodeID;
            public readonly float Weight;
        }

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

        public void AddConnection( Connection connection )
        {
            if ( m_outgoingConnections.TryGetValue( connection.FromNodeID, out var connections ) == false )
            {
                connections = new List<Connection>();
                m_outgoingConnections[connection.FromNodeID] = connections;
            }

            connections.Add( connection );
        }

        public void AddConnection( int fromNode, int toNode, float weight )
        {
            AddConnection( new Connection( fromNode, toNode, weight ) );
        }

        public void AddBiDirectionalConnection( int nodeA, int nodeB, float weight )
        {
            AddConnection( nodeA, nodeB, weight );
            AddConnection( nodeB, nodeA, weight );
        }

        public bool TryGetOutgoingConnections( int fromNode, out IReadOnlyList<Connection> connections )
        {
            if ( m_outgoingConnections.TryGetValue( fromNode, out var outgoingConnections ) )
            {
                connections = outgoingConnections;
                return true;
            }

            connections = default;
            return false;
        }

        private readonly Dictionary<int, TNode> m_nodes = new Dictionary<int, TNode>();
        private readonly Dictionary<int, List<Connection>> m_outgoingConnections = new Dictionary<int, List<Connection>>();
    } 
}
