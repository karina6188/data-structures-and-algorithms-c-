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
        public Dictionary<Vertex, List<Edge>> RouteMap { get; set; }

        // Constructor
        public Graph()
        {
            RouteMap = new Dictionary<Vertex, List<Edge>>();
        }

        /// <summary>
        /// Takes in a string type of data value
        /// Create a new city using the data value from the argument
        /// Call Add() method to add the vertex into the RouteMap
        /// When a new city(key) is added, an empty list of destinations(values) is created
        /// </summary/>
        /// <param name="data"></param>
        /// <returns>the new city that is added</returns>
        public Vertex AddCity(string data)
        {
            Vertex city = new Vertex(data);

            RouteMap.Add(city, new List<Edge>());
            return city;
        }

        /// <summary>
        /// The method takes in two cities, the start city and the destination on the two sides of an edge, and the cost on the edge
        /// First create an edge by specifying the start city in the graph
        /// Then use Add() method to add the destination city with the cost to the new edge
        /// </summary>
        /// <param name="startCity"></param>
        /// <param name="destination"></param>
        /// <param name="cost"></param>
        public void AddDirectedEdge(Vertex startCity, Vertex destination, int cost)
        {
            // create an edge and load it up with cost and a destination city
            // Find the start city in the RouteMap and add the edge to the list

            RouteMap[startCity].Add(
                new Edge
                {
                    Cost = cost,
                    Vertex = destination
                }
            );
        }

        /// <summary>
        /// Similar to AddDirectedEdge() method to add an edge between the two cities and the cost on the edge
        /// Call AddDirectedEdge() method twice so both cities on the two sides of the edge can go to the other city
        /// </summary>
        /// <param name="startCity"></param>
        /// <param name="destination"></param>
        /// <param name="cost"></param>
        public void AddUndirectedEdge(Vertex startCity, Vertex destination, int cost)
        {
            // Attach the start city to destination with cost on edge
            AddDirectedEdge(startCity, destination, cost);
            AddDirectedEdge(destination, startCity, cost);
        }

        /// <summary>
        /// Create an empty list of cities then use foreach to loop through the start cities(keys) in the RouteMap
        /// </summary>
        /// <returns>a list of all the cities on the trip route</returns>
        public List<Vertex> GetAllCities()
        {
            List<Vertex> cities = new List<Vertex>();

            foreach (var city in RouteMap)
            {
                cities.Add(city.Key);
            }
            return cities;
        }

        /// <summary>
        /// It means to get all the destination cities(values) of a start city(key)
        /// Use RouteMap[] to get all the values of a key
        /// </summary>
        /// <param name="city"></param>
        /// <returns>a collection of cities connetected to the given city with costs</returns>
        public List<Edge> GetDirectCities(Vertex city)
        {
            return RouteMap[city];
        }

        public bool IsDirectFlight(Vertex city1, Vertex city2)
        {
            List<Edge> directCities = GetDirectCities(city1);
            foreach (Edge city in directCities)
            {
                if (city.Vertex == city2)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Use the first foreach to loop through the Keys of the AdjacencyList
        /// The second foreach is to get all the Values(edges) of each Key and the edge's cost
        /// </summary>
        public void Print()
        {
            Console.WriteLine("===== Trip Route Map =====");
            foreach (var vertex in RouteMap)
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
