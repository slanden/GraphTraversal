using UnityEngine;
using System.Collections;

public class Graph : MonoBehaviour
{
    int width, height;

    public struct Node
    {
        Vector2 data;
    }
    public struct Edge
    {
        Node id1, id2;
    }    

    public Node[,] nodes;


    public Node AddNode(Vector2 data)
    {
        Node n = new Node();


        return n;
    }

    int numNodes;
    int maxNodes;

    public Graph(int a_maxNodes, int a_numNodes = 0)
    {
        maxNodes = a_maxNodes;
        numNodes = a_numNodes;
    }

}
