using System;
using System.Collections.Generic;
using System.Text;

namespace GraphImplementation
{
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
