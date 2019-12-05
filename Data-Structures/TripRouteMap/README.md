# data-structures-and-algorithms-c#

## About This Program
Challenge - Trip Route Map

Author: Karina Chen

## Description
This is a daily code challenges. The task is to write a method called GetEdge() that takes in a graph and an array of cities and check if the trip is possible with direct flights. If yes, return how much total cost would be. If direct flight is impossible, return total cost to be zero.
 
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

Whiteboarding

![Alt app execution capture](/Assets/code37_1.jpg)
![Alt app execution capture](/Assets/code37_2.jpg)

## Change Log

1.1: Set up the program, add Table of Contents to README. - 2019 Dec 05

1.2: Add desctiptions, approach, and efficiency to README. - 2019 Dec 05
