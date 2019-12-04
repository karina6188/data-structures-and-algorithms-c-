using System;
using System.Collections.Generic;
using System.Text;

namespace BreadthFirstGraph
{
    class Graph<T>
    {
        public Dictionary<Vertex<T>, List<Edge<T>>> AdjacencyList { get; set; }

        private int _size;

        public Graph()
        {
            AdjacencyList = new Dictionary<Vertex<T>, List<Edge<T>>>();
        }

        // AddVertex(value of vertex)
        public Vertex<T> AddVertex(T data)
        {
            Vertex<T> vertex = new Vertex<T>(data);

            AdjacencyList.Add(vertex, new List<Edge<T>>());
            _size++;
            return vertex;
        }

        // Size() -> returns the total number of vertices in the graph
        public int Size()
        {
            return _size;
        }

        //AddEdge(Vertex A, Vertex B) -> adds a new edge between vertices. The edge should have weight and on both vertices
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

        public void AddUndirectedEdge(Vertex<T> source, Vertex<T> destination, int weight)
        {
            // Attach source to destination with weight on edge
            AddDirectedEdge(source, destination, weight);
            AddDirectedEdge(destination, source, weight);
        }

        // GetVertex() -> returns a list of all the vertices
        public List<Vertex<T>> GetAllVertices()
        {
            List<Vertex<T>> vertices = new List<Vertex<T>>();

            foreach (var vertex in AdjacencyList)
            {
                vertices.Add(vertex.Key);
            }
            return vertices;
        }

        //GetNeightbors(Vertex A) -> returns a collection of vertices connetected to the given vertex with weights.
        public List<Edge<T>> GetNeighbors(Vertex<T> vertex)
        {
            return AdjacencyList[vertex];
        }

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
