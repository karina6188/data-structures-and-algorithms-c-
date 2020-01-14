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
            Graph<string> AdjacencyList = new Graph<string>();

            var CH = AdjacencyList.AddVertex("Capitol Hill");

            List<Vertex<string>> oneNeighborhood = new List<Vertex<string>>
            {
                CH
            };

            Assert.Equal(oneNeighborhood, AdjacencyList.GetAllVertices());
        }

        [Fact]
        public void CanGetAllNeighborhoods()
        {
            Graph<string> AdjacencyList = new Graph<string>();

            var CH = AdjacencyList.AddVertex("Capitol Hill");
            var NG = AdjacencyList.AddVertex("Northgate");
            var GL = AdjacencyList.AddVertex("Green Lake");

            List<Vertex<string>> oneNeighborhood = new List<Vertex<string>>
            {
                CH,
                NG,
                GL
            };

            Assert.Equal(oneNeighborhood, AdjacencyList.GetAllVertices());
        }

        [Fact]
        public void CanGetEmptyNeighborhood()
        {
            Graph<string> AdjacencyList = new Graph<string>();

            List<Vertex<string>> emptyNeighborhood = new List<Vertex<string>>();

            Assert.Equal(emptyNeighborhood, AdjacencyList.GetAllVertices());
        }

        [Fact]
        public void CanGetNumbersOfNeighborhoods()
        {
            Graph<string> AdjacencyList = new Graph<string>();

            var CH = AdjacencyList.AddVertex("Capitol Hill");
            var NG = AdjacencyList.AddVertex("Northgate");
            var GL = AdjacencyList.AddVertex("Green Lake");
            var QA = AdjacencyList.AddVertex("Queen Anne");
            var WL = AdjacencyList.AddVertex("Westlake");

            List<Vertex<string>> AllNeighborhoods = new List<Vertex<string>>
            {
                CH,
                NG,
                GL,
                QA,
                WL
            };

            Assert.Equal(5, AdjacencyList.Size());
        }

        [Fact]
        public void CanGetRideFaresBetweenNeighborhoods()
        {
            Graph<string> AdjacencyList = new Graph<string>();

            var MD = AdjacencyList.AddVertex("Madrona");
            var FM = AdjacencyList.AddVertex("Fremont");
            var QA = AdjacencyList.AddVertex("Queen Anne");

            AdjacencyList.AddDirectedEdge(MD, FM, 13);
            AdjacencyList.AddDirectedEdge(FM, QA, 9);

            Edge<string> dest1 = AdjacencyList.GetNeighbors(MD)[0];
            Edge<string> dest2 = AdjacencyList.GetNeighbors(FM)[0];

            List<Edge<string>> actualRoutes = new List<Edge<string>>
            {
                dest1,
                dest2
            };

            int totalFare = 0;
            foreach (var destination in actualRoutes)
            {
                totalFare += destination.Weight;
            }

            Assert.Equal(22, totalFare);
        }
    }
}
