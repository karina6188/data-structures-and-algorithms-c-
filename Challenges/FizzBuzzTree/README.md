# data-structures-and-algorithms-c#

## About This Program
Challenge - Fizz Buzz Tree

Author: Karina Chen

## Description
This is a daily code challenges. The task is to traverse through a binary tree and if a node's value is divisible by 3, 5, or both, replace the value with "Fizz", "Buzz", and "FizzBuzz". At the end, return the tree with its new values.

## Approach & Efficiency
##### FizzBuzzTree():
Take in a tree and create an empty List to store the nodes values on the tree. Call PreOrder() method to traverse throught the nodes. PreOrder() method traverses throught the nodes and count how many nodes are on the tree. While traversing, check if the node's value is divisible by 3, 5, or 15. If yes, replace the values to be "Fizz", "Buzz", and "FizzBuzz" before saving the value to List. Keep doing this if the node has children and keep checking, replacing, and saving values to List.

Big O Time: O(n) ; Big O Space: O(w) width of the tree.

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

White-Boarding

![Alt white-boarding capture](/Assets/code16_2.jpg)
![Alt white-boarding capture](/Assets/code16_3.jpg)
![Alt white-boarding capture](/Assets/code16_4.jpg)
![Alt white-boarding capture](/Assets/code16_5.jpg)

Result

![Alt app execution capture](/Assets/code16_1.JPG)

## Change Log

1.1: Set up the program, add Table of Contents to README. - 2019 Nov 06

1.2: Create Node class. - 2019 Nov 07

1.3: Create Tree class. - 2019 Nov 07

1.4: Scaffold FizzBuzzTree() method. - 2019 Nov 07

1.5: Create PreOrder() method to traverse throught the nodes on the tree. - 2019 Nov 07

1.6: Add codes to PreOrder() method and replace values to be "Fizz", "Buzz", and "FizzBuzz" if the value is divisible by 3, 5, or 15. - 2019 Nov 07

1.7: Add unit testing. Pass all the tests. The program is completed. - 2019 Nov 07