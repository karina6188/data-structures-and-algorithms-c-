using System;
using System.Collections.Generic;

namespace TripRouteMap
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph RouteMap = new Graph();

            var Pandora = RouteMap.AddCity("Pandora");
            var Arendelle = RouteMap.AddCity("Arendelle");
            var Metroville = RouteMap.AddCity("Metroville");
            var Narnia = RouteMap.AddCity("Narnia");
            var Naboo = RouteMap.AddCity("Naboo");
            var Monstropolis = RouteMap.AddCity("Monstropolis");

            RouteMap.AddUndirectedEdge(Pandora, Arendelle, 150);
            RouteMap.AddUndirectedEdge(Pandora, Metroville, 82);
            RouteMap.AddUndirectedEdge(Arendelle, Metroville, 99);
            RouteMap.AddUndirectedEdge(Arendelle, Monstropolis, 42);
            RouteMap.AddUndirectedEdge(Metroville, Narnia, 37);
            RouteMap.AddUndirectedEdge(Metroville, Naboo, 26);
            RouteMap.AddUndirectedEdge(Metroville, Monstropolis, 105);
            RouteMap.AddUndirectedEdge(Monstropolis, Naboo, 73);
            RouteMap.AddUndirectedEdge(Narnia, Naboo, 250);

            Vertex[] trip = new Vertex[] { Metroville, Monstropolis, Naboo };

            List<Edge> trip0 = RouteMap.GetDirectCities(trip[0]);
            foreach (var city in trip0)
            {
                Console.Write($"{city.Vertex.City} -> ");
            }
            Console.Write("null");

            //Console.WriteLine(GetEdge(RouteMap, trip));
        }

        static string GetEdge(Graph map, Vertex[] cities)
        {
            int totalCost = 0;

            if (map.GetDirectCities(cities[0]) != null)
            {
                for (int x = 0; x < cities.Length - 1; x++)
                {
                    Vertex startCity = new Vertex(cities[x].City);
                    List<Edge> route = map.GetDirectCities(startCity);

                    Vertex nextCity = new Vertex(cities[x+1].City);

                    if (map.IsDirectFlight(startCity, nextCity) == true)
                    {
                        foreach (var city in route)
                        {
                            if (city.Vertex == nextCity)
                            {
                                totalCost += city.Cost;
                            }
                        }
                    }
                    else return "False, $0";
                }
                return $"True, ${totalCost}";
            }
            else return "False, $0";
        }
    }
}
