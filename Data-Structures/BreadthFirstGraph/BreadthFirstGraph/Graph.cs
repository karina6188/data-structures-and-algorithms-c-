using System;
using System.Collections.Generic;
using System.Text;

namespace BreadthFirstGraph
{
    class Graph<T>
    {
        /// <summary>
        /// Create a Dictionary that acts like a hashtable with the Key to be Vertex<T> and Value to be a list of edges List<Edge<T>>
        /// This creates an Adjacency List
        /// </summary>
        public Dictionary<Vertex<T>, List<Edge<T>>> AdjacencyList { get; set; }

        // A private variable called _size to store how many vertices are there in the graph
        private int _size;

        // Constructor
        public Graph()
        {
            AdjacencyList = new Dictionary<Vertex<T>, List<Edge<T>>>();
        }

        /// <summary>
        /// Takes in a generic type of data value
        /// Create a new vertex using the data value from the argument
        /// Call Add() method to add the vertex into the AdjacencyList
        /// When a new vertex(key) is added, an empty list of edges(values) is created
        /// Increase the size of the total vertices in the graph by 1
        /// </summary/>
        /// <param name="data"></param>
        /// <returns>the new vertex that is added</returns>
        public Vertex<T> AddVertex(T data)
        {
            Vertex<T> vertex = new Vertex<T>(data);

            AdjacencyList.Add(vertex, new List<Edge<T>>());
            _size++;
            return vertex;
        }

        /// <summary>
        //  To get the number from _size variable that indicates how many vertices are in the graph now
        /// </summary>
        /// <returns>the total number of vertices in the graph</returns>
        public int Size()
        {
            return _size;
        }

        /// <summary>
        /// The method takes in two vertices, the source and the destination on the two sides of an edge, and the weight on the edge
        /// First create an edge by specifying the source vertex in the graph
        /// Then use Add() method to add the destination vertex with the weight to the new edge
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <param name="weight"></param>
        public void AddDirectedEdge(Vertex<T> source, Vertex<T> destination, int weight)
        {
            // create an edge and load it up with weight and a destination
            // Find the source in the AdjacencyList and add the edge to the list

            AdjacencyList[source].Add(
                new Edge<T>
                {
                    Weight = weight,
                    Vertex = destination
                }
            );
        }

        /// <summary>
        /// Similar to AddDirectedEdge() method to add an edge between the two vertices and the weight on the edge
        /// Call AddDirectedEdge() method twice so both vertices on the two sides of the edge can go to the other vertex
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <param name="weight"></param>
        public void AddUndirectedEdge(Vertex<T> source, Vertex<T> destination, int weight)
        {
            // Attach source to destination with weight on edge
            AddDirectedEdge(source, destination, weight);
            AddDirectedEdge(destination, source, weight);
        }

        /// <summary>
        /// Create an empty list of Vertex<T> then use foreach to loop through the Keys(vertices) in the AdjacencyList
        /// </summary>
        /// <returns>a list of all the vertices</returns>
        public List<Vertex<T>> GetAllVertices()
        {
            List<Vertex<T>> vertices = new List<Vertex<T>>();

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
        public List<Edge<T>> GetNeighbors(Vertex<T> vertex)
        {
            return AdjacencyList[vertex];
        }

        /// <summary>
        /// Use the first foreach to loop through the Keys of the AdjacencyList
        /// The second foreach is to get all the Values(edges) of each Key and the edge's weight
        /// </summary>
        public void Print()
        {
            foreach (var vertex in AdjacencyList)
            {
                Console.WriteLine($"Vertex: {vertex.Key.Data} -> ");
                foreach (var edge in vertex.Value)
                {
                    Console.WriteLine($"{edge.Vertex.Data}, {edge.Weight} -> ");
                }
                Console.WriteLine("null");
            }
        }
    }
}
