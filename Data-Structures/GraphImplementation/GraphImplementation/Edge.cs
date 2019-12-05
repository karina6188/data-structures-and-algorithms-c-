using System;
using System.Collections.Generic;
using System.Text;

namespace GraphImplementation
{
    /// <summary>
    /// Create an Edge class that takes a generic data type
    /// This class contains a Vertex class and a int Weight property
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Edge<T>
    {
        public int Weight { get; set; }

        public Vertex<T> Vertex { get; set; }
    }
}
