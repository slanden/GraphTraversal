using UnityEngine;
using System.Collections;

public class Graph : MonoBehaviour
{
    struct Node
    {
        Vector2 data;
    }
    struct Edge
    {
        Vector2 id1, id2;
    }

    Node AddNode(Vector2 data)
    {
        Node n = new Node();
        

        return n;
    }
    
    int numNodes;
    int maxNodes;

    public Graph(int a_maxNodes, int a_numNodes = 0)
    {
        maxNodes = a_maxNodes;
    }

}
