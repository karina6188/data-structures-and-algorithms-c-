using System;
using System.Collections.Generic;

namespace GraphImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph<int> AdjacencyList = new Graph<int>();
            AdjacencyList.AddVertex(5);
            AdjacencyList.AddVertex(9);
            AdjacencyList.AddVertex(7);
            AdjacencyList.AddVertex(3);
            AdjacencyList.AddVertex(6);
            AdjacencyList.AddVertex(2);


            //Dictionary<Vertex<int>, List<Edge<int>>> AdjacencyList = new Dictionary<Vertex<int>, List<Edge<int>>>();

        }
    }
}
