using System;

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
            AdjacencyList.AddUndirectedEdge(Arendelle, Metroville, 99);
            AdjacencyList.AddUndirectedEdge(FM, BT, 10);
            AdjacencyList.AddUndirectedEdge(ML, BT, 12);
        }
    }
}
