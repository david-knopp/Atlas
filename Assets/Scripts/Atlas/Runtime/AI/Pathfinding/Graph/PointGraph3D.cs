using System;
using System.Collections.Generic;
using UnityEngine;

namespace Atlas
{
    public class PointGraph3D : MonoBehaviour, IGraph<Vector3>
    {
        public List<Vector3> Nodes
        {
            get { return m_graph.Nodes; }
            set { m_graph.Nodes = value; }
        }

        public List<GraphEdge> GetEdges( int startNodeIndex )
        {
            return m_graph.GetEdges( startNodeIndex );
        }

        public List<Graph<Vector3>.EdgeList> GetAllEdges()
        {
            return m_graph.Edges;
        }

        /// <summary>
        /// Internal class definition to get around Unity's lack of generics serialization
        /// </summary>
        [Serializable]
        private class Vector3Graph : Graph<Vector3> {}

        [SerializeField] Vector3Graph m_graph;

        private void OnDrawGizmos()
        {
            // draw nodes
            for ( int i = 0; i < m_graph.Nodes.Count; i++ )
            {
                Vector3 node = m_graph.Nodes[i];

                Gizmos.DrawSphere( node, 2.0f );
            }

            // draw edges
            for ( int i = 0; i < m_graph.Edges.Count; i++ )
            {
                var edgeList = m_graph.Edges[i].m_edges;

                for ( int j = 0; j < edgeList.Count; j++ )
                {
                    var edge = edgeList[j];
                    if ( edge.StartIndex >= 0 &&
                         edge.StartIndex < m_graph.Nodes.Count &&
                         edge.EndIndex >= 0 &&
                         edge.EndIndex < m_graph.Nodes.Count )
                    {
                        Vector3 start = m_graph.Nodes[edge.StartIndex];
                        Vector3 end = m_graph.Nodes[edge.EndIndex];
                        Gizmos.DrawLine( start, end );
                    }
                }
            }
        }

        private void OnDrawGizmosSelected()
        {
            OnDrawGizmos();
        }
    }
}