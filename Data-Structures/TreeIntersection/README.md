# data-structures-and-algorithms-c#

## About This Program
Challenge - Tree Intersection

Author: Karina Chen

## Description
This is a daily code challenges. The task is to create a method that takes in two binary trees and return a set of values that are on both trees. A Node class and a BinaryTree class are created to support this method.
 
## Approach & Efficiency
##### TreeIntersection():
Takes in two binary trees and returns a set of values that are on both trees. This method traverses through both binary trees at the same time. While traversing, use Add() method to add the node values into the hash table. Then use Contains() method to check if the node value already exists in the hash table. If no, keep traversing to the next node values. If yes, add the node value into a List that is going to be returned once all the node values have been traversed on both binary trees. If the node value has alreay been added into the List, do not add it again if more than one time the value is found on the binary trees.

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

1.1: Set up the program, add Table of Contents to README.

1.2: Add desctiptions, approach, and efficiency to README.

1.3: Add BinaryTree and Node classes.