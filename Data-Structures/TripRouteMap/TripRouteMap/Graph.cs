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

        /// <summary>
        /// Takes in a string type of data value
        /// Create a new vertex using the data value from the argument
        /// Call Add() method to add the vertex into the AdjacencyList
        /// When a new vertex(key) is added, an empty list of edges(values) is created
        /// </summary/>
        /// <param name="data"></param>
        /// <returns>the new vertex that is added</returns>
        public Vertex AddVertex(string data)
        {
            Vertex vertex = new Vertex(data);

            AdjacencyList.Add(vertex, new List<Edge>());
            return vertex;
        }

        /// <summary>
        /// The method takes in two vertices, the source and the destination on the two sides of an edge, and the cost on the edge
        /// First create an edge by specifying the source vertex in the graph
        /// Then use Add() method to add the destination vertex with the cost to the new edge
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <param name="weight"></param>
        public void AddDirectedEdge(Vertex source, Vertex destination, int cost)
        {
            // create an edge and load it up with weight and a destination
            // Find the source in the AdjacencyList and add the edge to the list

            AdjacencyList[source].Add(
                new Edge
                {
                    Cost = cost,
                    Vertex = destination
                }
            );
        }

        /// <summary>
        /// Similar to AddDirectedEdge() method to add an edge between the two vertices and the cost on the edge
        /// Call AddDirectedEdge() method twice so both vertices on the two sides of the edge can go to the other vertex
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <param name="weight"></param>
        public void AddUndirectedEdge(Vertex source, Vertex destination, int cost)
        {
            // Attach source to destination with cost on edge
            AddDirectedEdge(source, destination, cost);
            AddDirectedEdge(destination, source, cost);
        }

        /// <summary>
        /// Create an empty list of Vertex then use foreach to loop through the Keys(vertices) in the AdjacencyList
        /// </summary>
        /// <returns>a list of all the vertices</returns>
        public List<Vertex> GetAllVertices()
        {
            List<Vertex> vertices = new List<Vertex>();

            foreach (var vertex in AdjacencyList)
            {
                vertices.Add(vertex.Key);
            }
            return vertices;
        }

        /// <summary>
        /// It means to get all the edges(values) of a vertex(key)
        /// Use AdjacencyList[] to get all the values of a key
        /// </summary>
        /// <param name="vertex"></param>
        /// <returns>a collection of vertices connetected to the given vertex with weights</returns>
        public List<Edge> GetNeighbors(Vertex vertex)
        {
            return AdjacencyList[vertex];
        }

        /// <summary>
        /// Use the first foreach to loop through the Keys of the AdjacencyList
        /// The second foreach is to get all the Values(edges) of each Key and the edge's cost
        /// </summary>
        public void Print()
        {
            Console.WriteLine("===== Trip Route Map =====");
            foreach (var vertex in AdjacencyList)
            {
                Console.Write($"{vertex.Key.City} | ");
                foreach (var edge in vertex.Value)
                {
                    Console.Write($"{edge.Vertex.City}, ${edge.Cost} -> ");
                }
                Console.WriteLine("null");
            }
            Console.WriteLine();
        }
    }
}
