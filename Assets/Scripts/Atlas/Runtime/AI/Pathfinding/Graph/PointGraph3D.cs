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

        /// <summary>
        /// Internal class definition to get around Unity's lack of generics serialization
        /// </summary>
        [Serializable]
        private class Vector3Graph : Graph<Vector3> {}

        [SerializeField] Vector3Graph m_graph;

        private void OnDrawGizmosSelected()
        {
            // draw nodes
            for ( int i = 0; i < m_graph.Nodes.Count; i++ )
            {
                Vector3 node = m_graph.Nodes[i];
                
                Gizmos.DrawSphere( node, 2.0f );
            }

            // draw edges
        }
    }
}