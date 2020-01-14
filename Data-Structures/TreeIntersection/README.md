# data-structures-and-algorithms-c#

## About This Program
Challenge - Tree Intersection

Author: Karina Chen

## Description
This is a daily code challenges. The task is to create a method that takes in two binary trees and return a set of values that are on both trees. A hashtable will need to be created in order to implement this method.
 
## Approach & Efficiency
##### TreeIntersection():
Takes in two binary trees and returns a set of values that are on both trees. This method traverses through both binary trees at the same time. While traversing, use Add() method to add the node values into the hash table. Use Contains() method to check if the node value already exists in the hash table. If no, keep traversing to the next node values. If yes, add the node value into a List that is going to be returned once all the node values have been traversed on both binary trees.

##### Add():
Accepts a key and a value. Then sends the key to Hash() method to generate a hash which is used to determine the index position where the key/value pair is to be stored in the hashtable. After Hash() method calculates the index, it returns an index to Add() method. Add() method then goes to the index position inside the hashtable and stores the key/value pair to the end of the linked list inside the bucket at the index position.

##### Get():
Takes in the key and returns the value from the hashtable. Get() method calls Hash() method and sends over the key to get the index of where the key/value pair is stored then goes to the stored location. Get() method then iterate through the linked list at the index position to find the key. If the key exists, return the value.

##### Contains():
Takes in the key and returns a boolean indicating if the key already exists in the hashtable. Contains() method calls Hash() method to get the index then goes to the index position to check if the key exists.

##### Time and Space Complexity:
Big O Time: O(n); Big O Space: O(n).

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

![Alt app execution capture](/Assets/code32_1.jpg)
![Alt app execution capture](/Assets/code32_2.jpg)


## Resource
https://stackoverflow.com/questions/400733/how-to-get-ascii-value-of-string-in-c-sharp/400738

## Change Log

1.1: Set up the program, add Table of Contents to README. - 2019 Nov 27

1.2: Add desctiptions, approach, and efficiency to README. - 2019 Nov 27

1.3: Add Hashtable and Node classes.