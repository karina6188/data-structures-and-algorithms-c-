using System;
using System.Collections.Generic;

namespace GraphImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph<string> AdjacencyList = new Graph<string>();

            var ML = AdjacencyList.AddVertex("Montlake");
            var MN = AdjacencyList.AddVertex("Magnolia");
            var BT = AdjacencyList.AddVertex("Belltown");
            var BL = AdjacencyList.AddVertex("Ballard ");
            var DT = AdjacencyList.AddVertex("Downtown");
            var FM = AdjacencyList.AddVertex("Fremont ");

            AdjacencyList.AddUndirectedEdge(FM, BL, 10);
            AdjacencyList.AddUndirectedEdge(FM, BT, 10);
            AdjacencyList.AddDirectedEdge(FM, ML, 11);
            AdjacencyList.AddUndirectedEdge(ML, BT, 12);
            AdjacencyList.AddDirectedEdge(ML, DT, 14);
            AdjacencyList.AddUndirectedEdge(BT, DT, 7);
            AdjacencyList.AddDirectedEdge(BT, MN, 12);
            AdjacencyList.AddDirectedEdge(MN, FM, 13);

            AdjacencyList.Print();

            var listOfEdges = AdjacencyList.GetNeighbors(FM);
            Console.WriteLine("===== Get all destinations for Fremont ======");
            foreach (var destinations in listOfEdges)
            {
                Console.WriteLine(destinations.Vertex.Data);
            }
            Console.WriteLine();

            Console.WriteLine("===== All the neighborhoods =====");
            var listOfVertices = AdjacencyList.GetAllVertices();
            foreach (var neighborhood in listOfVertices)
            {
                Console.WriteLine(neighborhood.Data);
            }
        }
    }
}
