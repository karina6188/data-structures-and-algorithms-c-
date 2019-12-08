# data-structures-and-algorithms-c#

## About This Program
Challenge - Graph Implementation

Author: Karina Chen

## Description
This is a daily code challenges. The task is to create multiple methods and implement a graph. Inside the graph, there should be vertices containing values. The vertices are connected with each other directly or undirected with weight on each edge.
 
## Approach & Efficiency
##### AddVertex():
Takes in a generic type of data value then create a new vertex using the data value from the argument. The method calls Add() method to add the vertex into the AdjacencyList. When a new vertex(key) is added, an empty list of edges(values) is created and be ready to store values later. When every time a Vertex is added into the AdjacencyList, increase the size of the total vertices in the graph by 1. The method returns the new vertex that is added.

##### Size():
This method gets the number from the private variable _size that indicates how many vertices are in the graph now then returns the total number of vertices in the graph as an integer.

##### AddDirectedEdge():
This method takes in two vertices, the source and the destination on the two sides of an edge, and the weight on the edge. First, create an edge by specifying the source vertex in the graph then use Add() method to add the destination vertex with the weight to the new edge.

##### AddUndirectedEdge():
Similar to AddDirectedEdge() method to add an edge between the two vertices and the weight on the edge. This method calls AddDirectedEdge() method twice so both vertices on the two sides of the edge can go to the other vertex thus an undirected edge is created.

##### GetAllVertices():
Create an empty list of Vertex< T > then use foreach to loop through the Keys(vertices) in the adjacency list (graph). The method returns a list of all the vertices.

##### GetNeighbors():
This method gets all the edges(values) of a vertex(key) and returns a collection of vertices connetected to the given vertex with weights.

##### Print():
Use a nested foreach loop to print out all the vertices in the grapg. The first foreach loop loops through the keys of the adjacency list and the second foreach loop is to get all the values(edges) of each key and each key's edge weight.

##### Time and Space Complexity:
O(V+E): all the vertices in the graph and each vertex's edges

## Getting Started
Clone this repository to your local machine.

$ git clone [https://github.com/karina6188/data-structures-and-algorithms-c-.git]

To run the program from Visual Studio:
Select File -> Open -> Project/Solution

Next navigate to the location you cloned the Repository.

Double click on the Data Structure directory.

Then select and open the project you want to view.

## To Run This Program
Open the program using Visual Studio and click "Start" button to run this program.

## Visuals

Result

![Alt app execution capture](/Assets/.JPG)

## Change Log

1.1: Set up the program, add Table of Contents to README. - 2019 Dec 03

1.2: Add desctiptions, approach, and efficiency to README. - 2019 Dec 03

1.3: Add Graph class, Edge Class, Vertex class, and scaffold methods. - 2019 Dec 03

1.4: Add methods and summary comments. - 2019 Dec 04

1.5: Add method implementations to Main(). - 2019 Dec 07

1.6: Add unit testing. - 2019 Dec 07