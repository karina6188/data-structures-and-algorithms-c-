using GraphImplementation;
using System.Collections.Generic;
using Xunit;

namespace GraphTests
{
    public class UnitTest1
    {

        [Fact]
        public void CanAddAVertexToGraph()
        {
            Graph<string> AdjacencyList = new Graph<string>();

            Vertex<string> montlake = new Vertex<string>("Montlake");
            Assert.Equal(montlake.Data, AdjacencyList.AddVertex("Montlake").Data);
        }

        [Fact]
        public void CanAddEdgesToAVertex()
        {
            Graph<string> AdjacencyList = new Graph<string>();

            var MD = AdjacencyList.AddVertex("Madrona");
            var FM = AdjacencyList.AddVertex("Fremont");
            var QA = AdjacencyList.AddVertex("Queen Anne");

            AdjacencyList.AddDirectedEdge(MD, FM, 13);
            AdjacencyList.AddDirectedEdge(MD, QA, 9);

            List<Vertex<string>> plannedDestinations = new List<Vertex<string>>
            {
                FM,
                QA
            };

            List<Edge<string>> actualRoutes = AdjacencyList.GetNeighbors(MD);

            List<Vertex<string>> destinations = new List<Vertex<string>>();
            foreach (var destination in actualRoutes)
            {
                destinations.Add(destination.Vertex);
            }

            Assert.Equal(plannedDestinations, destinations);
        }

        [Fact]
        public void CanGetOneNeighborhood()
        {

        }

        [Fact]
        public void CanGetAllNeighborhoods()
        {
            
        }

        [Fact]
        public void CanGetEmptyNeighborhood()
        {

        }

        [Fact]
        public void CanGetNumbersOfNeighborhoods()
        {

        }

        [Fact]
        public void CanGetRideFaresBetweenNeighborhoods()
        {

        }
    }
}
