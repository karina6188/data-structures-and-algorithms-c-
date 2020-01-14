using System;
using System.Collections.Generic;
using System.Text;

namespace TripRouteMap
{
    /// <summary>
    /// Create a Vertex class with a string data type
    /// </summary>
    class Vertex
    {
        public string City {get; set;}

        // Constructor
        public Vertex(string city)
        {
            City = city;
        }
    }
}
