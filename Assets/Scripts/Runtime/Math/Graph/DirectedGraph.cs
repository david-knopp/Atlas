using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Atlas
{
    /// <summary>
    /// A graph of nodes connected by directed edges with associated edge weights
    /// </summary>
    public class DirectedGraph<TNode>
        where TNode : IGraphNode
    {
        public readonly struct Edge
        {
            public Edge( int fromNode, int toNode, float weight )
            {
                FromNode = fromNode;
                ToNode = toNode;
                Weight = weight;
            }

            public readonly int FromNode;
            public readonly int ToNode;
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

        public void AddEdge( Edge edge )
        {
            if ( m_outgoingEdges.TryGetValue( edge.FromNode, out var edges ) == false )
            {
                edges = new List<Edge>();
                m_outgoingEdges[edge.FromNode] = edges;
            }

            edges.Add( edge );
        }

        public void AddEdge( int fromNode, int toNode, float weight )
        {
            AddEdge( new Edge( fromNode, toNode, weight ) );
        }

        public void AddBiDirectionalEdge( int nodeA, int nodeB, float weight )
        {
            AddEdge( nodeA, nodeB, weight );
            AddEdge( nodeB, nodeA, weight );
        }

        public bool TryGetOutgoingEdges( int fromNode, out IReadOnlyList<Edge> edges )
        {
            if ( m_outgoingEdges.TryGetValue( fromNode, out var outgoingEdges ) )
            {
                edges = outgoingEdges;
                return true;
            }

            edges = default;
            return false;
        }

        private readonly Dictionary<int, TNode> m_nodes = new Dictionary<int, TNode>();
        private readonly Dictionary<int, List<Edge>> m_outgoingEdges = new Dictionary<int, List<Edge>>();
    } 
}
