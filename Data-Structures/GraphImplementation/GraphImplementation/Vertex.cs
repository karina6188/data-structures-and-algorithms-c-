using System;
using System.Collections.Generic;
using System.Text;

namespace GraphImplementation
{
    /// <summary>
    /// Create a vertex class with a generic data type
    /// </summary>
    class Vertex<T>
    {
        public T Data { get; set; }

        // Constructor
        public Vertex(T data)
        {
            Data = data;
        }
    }
}
