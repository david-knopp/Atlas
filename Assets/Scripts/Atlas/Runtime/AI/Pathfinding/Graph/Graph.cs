using UnityEngine.Assertions;
using System.Collections.Generic;

namespace Atlas
{
    /* A bi-directional graph of nodes and edges */
    public class Graph<NodeType>
    {
        #region public
        public Graph()
        {
            m_nodes = new Dictionary<int, NodeType>();
            m_edges = new Dictionary<int, List<GraphEdge>>();
        }

        #region nodes
        public int NodeCount
        {
            get { return m_nodes.Count; }
        }

        public Dictionary<int, NodeType> Nodes
        {
            get { return m_nodes; }
        }

        public void AddNode( NodeType node, int id )
        {
            m_nodes.Add( id, node );
        }

        public void RemoveNode( int id )
        {
            m_nodes.Remove( id );
        }

        public bool ContainsNode( int id )
        {
            return m_nodes.ContainsKey( id );
        }

        public NodeType GetNode( int id )
        {
            return m_nodes[id];
        }
        #endregion // nodes

        #region edges
        public int EdgeCount
        {
            get { return m_edges.Count; }
        }

        public List<GraphEdge> GetEdges( int id )
        {

            return m_edges[id];
        }

        public void AddEdge( GraphEdge edge )
        {
            // create new list
            if ( !m_edges.ContainsKey( edge.From ) )
                m_edges.Add( edge.From, new List<GraphEdge>() );

            // add to edges
            m_edges[edge.From].Add( edge );
        }

        public void AddEdge( int from, int to, float cost )
        {
            AddEdge( new GraphEdge( from, to, cost ) );
        }

        public void AddBiDirectionalEdge( int nodeA, int nodeB, float cost )
        {
            AddEdge( nodeA, nodeB, cost );
            AddEdge( nodeB, nodeA, cost );
        }
        #endregion // edges

        public void Clear()
        {
            m_nodes.Clear();
            m_edges.Clear();
        }
        #endregion // public

        #region protected
        protected Dictionary<int, NodeType> m_nodes;
        protected Dictionary<int, List<GraphEdge>> m_edges;
        #endregion // protected
    }
}