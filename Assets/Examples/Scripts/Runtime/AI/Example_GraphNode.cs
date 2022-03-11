using System.Collections.Generic;
using UnityEngine;

namespace Atlas.Examples
{
    public sealed class Example_GraphNode : MonoBehaviour, IGraphNode
    {
        [field: SerializeField]
        public int ID { get; private set;  }

        public Vector3 Position => transform.position;

        public IReadOnlyList<Example_GraphNode> ConnectedNodes => m_connectedNodes;

        [SerializeField]
        private List<Example_GraphNode> m_connectedNodes;
    }
}
