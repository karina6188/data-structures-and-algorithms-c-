using System;
using System.Collections.Generic;

namespace TripRouteMap
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph AdjacencyList = new Graph();

            var Pandora = AdjacencyList.AddVertex("Pandora");
            var Arendelle = AdjacencyList.AddVertex("Arendelle");
            var Metroville = AdjacencyList.AddVertex("Metroville");
            var Narnia = AdjacencyList.AddVertex("Narnia");
            var Naboo = AdjacencyList.AddVertex("Naboo");
            var Monstropolis = AdjacencyList.AddVertex("Monstropolis");

            AdjacencyList.AddUndirectedEdge(Pandora, Arendelle, 150);
            AdjacencyList.AddUndirectedEdge(Pandora, Metroville, 82);
            AdjacencyList.AddUndirectedEdge(Arendelle, Metroville, 99);
            AdjacencyList.AddUndirectedEdge(Arendelle, Monstropolis, 42);
            AdjacencyList.AddUndirectedEdge(Metroville, Narnia, 37);
            AdjacencyList.AddUndirectedEdge(Metroville, Naboo, 26);
            AdjacencyList.AddUndirectedEdge(Metroville, Monstropolis, 105);
            AdjacencyList.AddUndirectedEdge(Monstropolis, Naboo, 73);
            AdjacencyList.AddUndirectedEdge(Narnia, Naboo, 250);
        }

        public int GetEdge(Graph graph, string[] cities)
        {
            int totalCost = 0;
            Vertex start = new Vertex(cities[0]);

            if (graph.GetNeighbors(start) != null)
            {
                List<Edge> route = graph.GetNeighbors(start);
                foreach (Edge city in route)
                {
                    totalCost += city.Cost;
                }
                return totalCost;
            }
            else
            {
                return totalCost;
            }
        }
    }
}
