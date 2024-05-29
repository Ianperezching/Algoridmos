using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeControl : List
{
    public DoubleLinkedList<NodeControl> adjacentNodes;
    void Awake()
    {
        adjacentNodes = new DoubleLinkedList<NodeControl>();
    }
    
    public NodeControl SelecRandomAdjacent()
    {
        int index = Random.Range(0, adjacentNodes.Count);
        return adjacentNodes.GetElementAt(index);
    }
    public class Edge
    {
        public NodeControl Node { get; private set; }
        public float Weight { get; private set; }

        public Edge(NodeControl node, float weight)
        {
            Node = node;
            Weight = weight;
        }
    }
    public void AddAdjacentNode(NodeControl nodes)
    {
        adjacentNodes.InsertAtEnd(nodes);
    }
}
