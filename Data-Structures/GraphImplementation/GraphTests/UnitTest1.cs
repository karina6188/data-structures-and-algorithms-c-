using System;
using Xunit;

namespace GraphTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddAVertexToGraph()
        {
            Graph<string> AdjacencyList = new Graph<string>();
            var ML = AdjacencyList.AddVertex("Montlake");
        }
        // Node can be successfully added to the graph
        // An edge can be successfully added to the graph
        // A collection of all nodes can be properly retrieved from the graph
        // All appropriate neighbors can be retrieved from the graph
        // Neighbors are returned with the weight between nodes included
        // The proper size is returned, representing the number of nodes in the graph
        // A graph with only one node and edge can be properly returned
        // An empty graph properly returns null
    }
}
