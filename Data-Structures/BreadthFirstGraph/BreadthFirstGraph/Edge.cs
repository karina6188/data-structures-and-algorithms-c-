using System;
using System.Collections.Generic;
using System.Text;

namespace BreadthFirstGraph
{
    class Edge<T>
    {
        public int Weight { get; set; }

        public Vertex<T> Vertex { get; set; }
    }
}
