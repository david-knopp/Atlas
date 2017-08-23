using UnityEngine.Assertions;
using System.Collections.Generic;
using System;
using UnityEngine;

namespace Atlas
{
    // TODO: Expose GraphEdge type as a generic param, certain games
    // might want to have special information associated with edges (i.e. edges that require jumps)
    /* A bi-directional graph of nodes and edges */
    [Serializable]
    public class Graph<NodeType> : IGraph<NodeType>
    {
        #region public
        public Graph()
        {
            m_nodes = new List<NodeType>();
            m_edges = new List<List<GraphEdge>>();
        }

        #region nodes
        public List<NodeType> Nodes
        {
            get { return m_nodes; }
            set { m_nodes = value; }
        }
        #endregion // nodes

        #region edges
        public List<List<GraphEdge>> Edges
        {
            get { return m_edges; }
            set { m_edges = value; }
        }

        public List<GraphEdge> GetEdges( int startNodeIndex )
        {
            Assert.IsTrue( startNodeIndex >= 0 && startNodeIndex < m_edges.Count, 
                           string.Format( "Graph.GetEdges: No edges exist for node index '{0}'", startNodeIndex ) );

            return m_edges[startNodeIndex];
        }
        #endregion // edges

        public void Clear()
        {
            m_nodes.Clear();
            m_edges.Clear();
        }
        #endregion // public

        #region private
        [SerializeField] private List<NodeType> m_nodes;
        [SerializeField] private List<List<GraphEdge>> m_edges;
        #endregion // private
    }
}