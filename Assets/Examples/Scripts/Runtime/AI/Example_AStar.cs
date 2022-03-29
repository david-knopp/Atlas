using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Atlas.Examples
{
    public class Example_AStar : MonoBehaviour
    {
        [SerializeField]
        private List<Example_GraphNode> m_nodes;

        [SerializeField]
        private Example_GraphNode m_startNode;

        [SerializeField]
        private Example_GraphNode m_endNode;

        private DirectedGraph<Example_GraphNode, GraphConnection> m_graph =
            new DirectedGraph<Example_GraphNode, GraphConnection>();
        private List<GraphConnection> m_path = new List<GraphConnection>();

        [InspectorButton]
        private void Search()
        {
            if ( m_startNode == null ||
                 m_endNode == null )
            {
                return;
            }

            AStar<Example_GraphNode, GraphConnection> search =
                new AStar<Example_GraphNode, GraphConnection>( m_graph, heuristic: EuclidianDistance );

            DateTime startTime = DateTime.UtcNow;
            var status = search.Search( m_startNode.ID, m_endNode.ID, m_path );
            TimeSpan searchLength = DateTime.UtcNow - startTime;

            Debug.Log( $"Search took {searchLength}, finished with status: {status}" );
        }

        private void Start()
        {
            foreach ( var node in m_nodes )
            {
                m_graph.AddNode( node );

                foreach ( var connection in node.ConnectedNodes )
                {
                    m_graph.AddConnection( node.ID, connection.ID, Vector3.Distance( node.Position, connection.Position ) );
                }
            }

            Search();
        }

        private void OnDrawGizmos()
        {
            if ( Application.isPlaying )
            {
                if ( m_graph == null )
                {
                    return;
                }

                foreach ( var nodePair in m_graph.Nodes )
                {
                    var node = nodePair.Value;
                    //Gizmos.DrawSphere( node.Position, 3f );

                    if ( m_graph.TryGetOutgoingConnections( node.ID, out var connections ) )
                    {
                        foreach ( var connection in connections )
                        {
                            if ( m_graph.TryGetNode( connection.ToNodeID, out var connectedNode ) )
                            {
                                Gizmos.DrawLine( node.Position, connectedNode.Position );
                            }
                        }
                    }
                }

                Gizmos.color = Color.green;

                foreach ( var connection in m_path )
                {
                    if ( m_graph.TryGetNode( connection.ToNodeID, out var toNode ) && 
                         m_graph.TryGetNode( connection.FromNodeID, out var fromNode ) )
                    {
                        Gizmos.DrawLine( toNode.Position, fromNode.Position );
                    }
                }
            }
            else
            {
                foreach ( var node in m_nodes )
                {
                    foreach ( var connectedNode in node.ConnectedNodes )
                    {
                        if ( connectedNode.ConnectedNodes.Contains( node ) == false )
                        {
                            Gizmos.color = Color.red;
                        }
                        else
                        {
                            Gizmos.color = Color.white;
                        }
                        Gizmos.DrawLine( node.Position, connectedNode.Position );
                    }
                }
            }
        }

        private static float EuclidianDistance( Example_GraphNode a, Example_GraphNode b )
        {
            return Vector3.Distance( a.Position, b.Position );
        }
    }
}
