using System;
using System.Collections.Generic;
using System.Text;

namespace TripRouteMap
{
    /// <summary>
    /// Create an Edge class that takes a int data type
    /// This class contains a Vertex class and an int Cost property
    /// </summary>
    class Edge
    {
        public int Cost { get; set; }

        public Vertex Vertex { get; set; }
    }
}
