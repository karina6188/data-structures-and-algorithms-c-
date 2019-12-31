using System;
using System.Collections.Generic;
using System.Text;

namespace TripRouteMap
{
    class Graph
    {
        /// <summary>
        /// Create a Dictionary that acts like a hashtable with the Key to be Vertex and Value to be a list of Edges (cities)
        /// This creates an Adjacency List
        /// </summary>
        public Dictionary<Vertex, List<Edge>> AdjacencyList { get; set; }

        // Constructor
        public Graph()
        {
            AdjacencyList = new Dictionary<Vertex, List<Edge>>();
        }


    }
}
