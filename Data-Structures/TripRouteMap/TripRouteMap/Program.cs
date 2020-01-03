using System;
using System.Collections.Generic;

namespace TripRouteMap
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph AdjacencyList = new Graph();

            var Pandora = AdjacencyList.AddCity("Pandora");
            var Arendelle = AdjacencyList.AddCity("Arendelle");
            var Metroville = AdjacencyList.AddCity("Metroville");
            var Narnia = AdjacencyList.AddCity("Narnia");
            var Naboo = AdjacencyList.AddCity("Naboo");
            var Monstropolis = AdjacencyList.AddCity("Monstropolis");

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

            if (graph.GetDirectCities(start) != null)
            {
                for
                // get all the direct cities of the first city
                List<Edge> route = graph.GetDirectCities(start);

                // if the next city inside the array exists in the above direct cities, get the cost then move to the next city and get its direct cities
                // keep doing this until reaching to the end of the array

                foreach (string city in cities)
                {

                }



                //for (int i = 0; i < route.Length;  e city in route)
                //{
                //    totalCost += city.Cost;
                //}
                return totalCost;
            }
            else
            {
                return totalCost;
            }
        }
    }
}
