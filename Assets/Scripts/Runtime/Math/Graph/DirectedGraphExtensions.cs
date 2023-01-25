using System;
using System.Collections.Generic;

namespace Atlas
{
    public static class DirectedGraphExtensions
    {
        /// <summary>
        /// Traverses a graph starting at the given node, visiting neighbor nodes before
        /// moving onto next-level neighbors
        /// </summary>
        /// <typeparam name="TNode">Type of the graph's nodes</typeparam>
        /// <typeparam name="TConnection">Type of the graph's connections</typeparam>
        /// <param name="graph">Graph to traverse</param>
        /// <param name="startNode">ID of the node to begin the search at</param>
        /// <returns>Each node visited, along with its parent that was traversed first</returns>
        public static IEnumerable<( TNode node, TNode parent )> BreadthFirstSearch<TNode, TConnection>(
            this DirectedGraph<TNode, TConnection> graph,
            TNode startNode )
            where TNode : IGraphNode
            where TConnection : struct, IGraphConnection
        {
            return BreadthFirstSearch( graph, startNode, shouldVisitNodePredicate: _ => true );
        }

        /// <summary>
        /// Traverses a graph starting at the given node, visiting neighbor nodes before
        /// moving onto next-level neighbors
        /// </summary>
        /// <typeparam name="TNode">Type of the graph's nodes</typeparam>
        /// <typeparam name="TConnection">Type of the graph's connections</typeparam>
        /// <param name="graph">Graph to traverse</param>
        /// <param name="startNode">ID of the node to begin the search at</param>
        /// <param name="shouldVisitNodePredicate">A callback to determine whether or not the given node should be visited</param>
        /// <returns>Each node visited, along with its parent that was traversed first</returns>
        public static IEnumerable<( TNode node, TNode parent )> BreadthFirstSearch<TNode, TConnection>(
            this DirectedGraph<TNode, TConnection> graph,
            TNode startNode,
            Predicate<TNode> shouldVisitNodePredicate )
            where TNode : IGraphNode
            where TConnection : struct, IGraphConnection
        {
            var nodeQueue = new Queue<( TNode node, TNode parent )>();
            nodeQueue.Enqueue( ( node: startNode, parent: default ) );

            HashSet<int> visitedNodeIDs = new HashSet<int>();

            while ( nodeQueue.Count > 0 )
            {
                ( TNode node, TNode parent ) = nodeQueue.Dequeue();

                if ( visitedNodeIDs.Contains( node.ID ) ||
                     shouldVisitNodePredicate.Invoke( node ) == false )
                {
                    continue;
                }

                yield return ( node, parent );

                visitedNodeIDs.Add( node.ID );

                // enqueue node's neighbors
                if ( graph.TryGetOutgoingConnections( node.ID, out var neighborConnections ) )
                {
                    foreach ( var connection in neighborConnections )
                    {
                        int neighborID = connection.ToNodeID;
                        if ( visitedNodeIDs.Contains( neighborID ) == false &&
                             graph.TryGetNode( neighborID, out TNode neighbor ) )
                        {
                            nodeQueue.Enqueue( (neighbor, node) );
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Traverses a graph starting at the given node, visiting neighbor nodes before
        /// moving onto next-level neighbors
        /// </summary>
        /// <typeparam name="TNode">Type of the graph's nodes</typeparam>
        /// <typeparam name="TConnection">Type of the graph's connections</typeparam>
        /// <param name="graph">Graph to traverse</param>
        /// <param name="startNode">ID of the node to begin the search at</param>
        /// <param name="maxNodeDepth">The maximum allowable depth of nodes to visit before ending traversal</param>
        /// <returns>Each node visited, along with its parent that was traversed first</returns>
        public static IEnumerable<( TNode node, TNode parent )> BreadthFirstSearch<TNode, TConnection>(
            this DirectedGraph<TNode, TConnection> graph,
            TNode startNode,
            int maxNodeDepth )
            where TNode : IGraphNode
            where TConnection : struct, IGraphConnection
        {
            var nodeQueue = new Queue<( TNode node, TNode parent, int depth )>();
            nodeQueue.Enqueue( ( node: startNode, parent: default, depth: 0 ) );

            HashSet<int> visitedNodeIDs = new HashSet<int>();

            while ( nodeQueue.Count > 0 )
            {
                ( TNode node, TNode parent, int depth ) = nodeQueue.Dequeue();

                if ( visitedNodeIDs.Contains( node.ID ) ||
                     depth > maxNodeDepth )
                {
                    continue;
                }

                yield return ( node, parent );

                visitedNodeIDs.Add( node.ID );

                // enqueue node's neighbors
                if ( graph.TryGetOutgoingConnections( node.ID, out var neighborConnections ) )
                {
                    foreach ( var connection in neighborConnections )
                    {
                        int neighborID = connection.ToNodeID;
                        if ( visitedNodeIDs.Contains( neighborID ) == false &&
                             graph.TryGetNode( neighborID, out TNode neighbor ) )
                        {
                            nodeQueue.Enqueue( ( neighbor, node, depth + 1 ) );
                        }
                    }
                }
            }
        }
    }
}
