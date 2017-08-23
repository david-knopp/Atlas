using System.Collections.Generic;

namespace Atlas
{
    public interface IGraph<NodeType>
    {
        List<NodeType> Nodes
        {
            get;
            set;
        }

        List<GraphEdge> GetEdges( int startNodeIndex );
    }
}