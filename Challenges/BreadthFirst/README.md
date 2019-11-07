# data-structures-and-algorithms-c#

## About This Program
Challenge - Trees

Author: Karina Chen

## Description
This is a daily code challenges. The task is to traverse through a binary tree using pre-order, in-order, and post-order traversals to return an array of values. Create a method to add values to a binary search tree and write another method to return a boolean if a value is in the tree.

## Approach & Efficiency
##### PreOrder():
Create a List to store values from nodes in the tree. Call PreOrder method to recursively traverse to node and add the node value. Then check if the node has a left child. If yes, get the value. Keep doing this until there is no left child then go back to the previous node to check if it has a right child. If yes, get the value. Keep doing this until all the nodes are traversed.

Big O Time: O(n); Big O Space: O(w) width of the tree.

##### InOrder():
Create a List to store values from nodes in the tree. Call InOrder method to recursively traverse to nodes and check if the node has a left child. If yes, get the left child's node value. Keep doing this until there is no left child then go back to the previous node and add the previous node value. Then go check if the node has a right child. If yes, get the value. Keep doing this until all the nodes are traversed.

Big O Time: O(n); Big O Space: O(w) width of the tree.

##### PostOrder():
Create a List to store values from nodes. Call PostOrder method to recursively traverse to nodes and check if the node has a left child. If yes, get the left child's node value. Keep doing this until there is no left child then go back to the previous node to check the node's right child. If the node has a right child, get the right child's node value. Then go back to the previous node and add the node's value.

Big O Time: O(n); Big O Space: O(w) width of the tree.

##### add():
Take in the root node of the tree and the value that is going to be added to the tree. Check if the tree has a node. If not, assign the root node to be the new node with the value. Otherwise, compare the value to the root node's value. If value is less than the root node's value, go to the node's left child and recursively call the method until it reaches to the leaf node then add the new node to be the leaf node's left child. If value is greater than the root node's value, go to the node's right child and recursively call the method until it reaches to the leaf node then add the new node to be the leaf node's right child. If value is equal to a node's value just return the node without adding a new node.

Big O Time: O(log n); Big O Space: O(h) height of the tree.

##### traverseBinarySearch():
Create an empty List to store node values on the tree. Create an empty queue and enqueue the root node on to the queue. While there are nodes on the queue, keep dequeueing the nodes and add the node's value to the List. As long as the node has children, enqueue the node's children and dequeue the node. Everytime when a node is dequeued from the queue, add the node's value to the List. Keep doing this until all the nodes are traversed and no nodes are left on the queue. Return the List with all the node values.

Big O Time: O(n); Big O Space: O(n).

##### contains():
Take the tree's root node and the value that is to be searched then use Contains() method to check if the List contains the value.

Big O Time: O(n); Big O Space: O(n).

## Getting Started
Clone this repository to your local machine.

$ git clone [https://github.com/karina6188/data-structures-and-algorithms-c-.git]

To run the program from Visual Studio:
Select File -> Open -> Project/Solution

Next navigate to the location you cloned the Repository.

Double click on the challenges directory.

Then select and open the challenges that you want to view.

## To Run This Program
Open the program using Visual Studio and click "Start" button to run this program.

## Visuals

Result

![Alt app execution capture](/Assets/code15_1.JPG)

## Change Log

1.1: Set up the program, add Table of Contents to README. - 2019 Nov 06

1.2: Create a Node class. - 2019 Nov 06

1.3: Create a BinaryTree class. - 2019 Nov 06

1.4: Add PreOrder(), InOrder(), and PostOrder() methods. - 2019 Nov 06

1.5: Create a TraverseBinaryTree() method. - 2019 Nov 06

1.6: Add BinarySearchTree class. - 2019 Nov 06

1.7: Create a traverseBinarySearch() method to traverse each node in the binary search tree using breadth first traversal. - 2019 Nov 06

1.8: Add add() method to add a new node with a value to the correct position on the tree. - 2019 Nov 06

1.9: Add contains() method to check if a value exists on the tree. - 2019 Nov 06