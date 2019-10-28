# data-structures-and-algorithms-c#

## About This Program
Data Structure and Algorithm

Author: Karina Chen

## Description - Singly Linked List
This is a data structure and algorithm challenge associated with Linked List Implementation.

Three methods are demonstrated in this program:

insert(): takes any value as an argument and adds a new node with that value to the head of the list with an O(1) Time performance.

includes(): takes any value as an argument and returns a boolean result depending on whether that value exists as a Node’s value somewhere within the list.

toString(): takes in no arguments and returns a string representing all the values in the Linked List.

## Approach
insert(): check if the linked list is empty. If yes, add the new node to the Head of the linked list. If the linked list has nodes with values, assign a temporary node to the Head of the linked list. Then assign the Head to be the new node and Head.Next to be the temporary node (which is the original Head of the linked list). Big O: O(1).

includes(): check if the linked list is empty. If yes, return false. If the linked list has nodes with values, use while loop to traverse the nodes and if the node data is equal to the value. If found, return true, otherwise return false. Big O: O(n).

toString(): check if the linked list is empty. If yes, return a string says the linked list is empty. If the linked list has nodes with values, use while loop to traverse through the nodes. Declare a string variable to store all the node values. For every single node, add the node value to the string variable. Once the end of the linked list is reached, return the string variable which contains all the node values from the first node to the last node. Big O: O(n).

## Getting Started
Clone this repository to your local machine.

$ git clone [https://github.com/karina6188/data-structures-and-algorithms-c-.git]

To run the program from Visual Studio:
Select File -> Open -> Project/Solution

Next navigate to the location you cloned the repository.

Double click on the data-structure-and-algorithm directory.

Then select and open the LinkedList-Extended folder to view this program.

## To Run This Program
Open the program using Visual Studio and click "Start" button to run this program.

## Visuals

insert():

![Alt whiteboarding capture](/Assets/code05_1.JPG)

includes():

![Alt whiteboarding capture](/Assets/code05_2.JPG)

toString():

![Alt whiteboarding capture](/Assets/code05_3.JPG)

## Change Log

1.1: Set up the program. - 2019 Oct 27

1.2: Add insert() method. - 2019 Oct 27

1.3: Add includes() method. - 2019 Oct 27

1.4: Add toString() method. - 2019 Oct 27

1.5: Add unit testing. Pass all tests. The program is completed. - 2019 Oct 27