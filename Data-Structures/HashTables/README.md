# data-structures-and-algorithms-c#

## About This Program
Challenge - Hash Tables

Author: Karina Chen

## Description
This is a daily code challenges. The task is to create a hash table and multitple methods to store the key and value pairs into the hash table. A hash table is a data structure that stores key/value pairs inside a hash map. Data is converted into a value for security or other purposes, then the key is used to generate a hash that determines the index position of where the key/value pair is to be stored at inside the hash table.

Hashtable - stores the keys to access hashed data. The keys here are the index positions of the array.

Buckets - like a container that contains a key and a value. It can potentially contain multiple pairs of key and values when collisions occur. A hash map can have many buckets. The less buckets inside a hash map, the more collisions occur.

Collisions - when more than one key gets hashed to the same index position of the hashtable, this is called collisions.

The hashtable should set up each bucket to be a LinkedList so if a collision occurs, the new pair of key/value does not override the previous data.

The key and the value must be stored together in the same bucket because if there are more than one pair of key/value stored in the same bucket, you will need the key to tell you which value to get from that bucket.


To store key/value pair into a hash table, first Add() method accepts a key and a value. Then it sends the key to Hash() method to generate an integer which is the index position where the key/value pair is to be stored in the hash table. After calculating the index, Hash() method returns an index and Add() method goes to the index position inside the hash table and store the key/value pair to the end of the linked list inside the bucket. To access the key/value from a hash table, Get() method takes in the key and calls Hash() to find the corresponding index. Then goes to the index position to find if the linked list contains the key or not. If yes, use the key to find the key/value pair and returns the value.
 
## Approach & Efficiency
##### PreOrder():
Create a List to store values from nodes in the tree. Call PreOrder method to recursively traverse to node and add the node value. Then check if the node has a left child. If yes, get the value. Keep doing this until there is no left child then go back to the previous node to check if it has a right child. If yes, get the value. Keep doing this until all the nodes are traversed.

Big O Time: O(n); Big O Space: O(w) width of the tree.

##### Add():
Take in the root node of the tree and the value that is going to be added to the tree. Check if the tree has a node. If not, assign the root node to be the new node with the value. Otherwise, compare the value to the root node's value. If value is less than the root node's value, go to the node's left child and recursively call the method until it reaches to the leaf node then add the new node to be the leaf node's left child. If value is greater than the root node's value, go to the node's right child and recursively call the method until it reaches to the leaf node then add the new node to be the leaf node's right child. If value is equal to a node's value just return the node without adding a new node.

Big O Time: O(log n); Big O Space: O(h) height of the tree.

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

1.10: Add try and catch blocks. - 2019 Nov 06

1.11: Add unit testing. Pass all the tests. The program is completed. - 2019 Nov 06