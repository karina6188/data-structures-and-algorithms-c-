# data-structures-and-algorithms-c#

## About This Program
Challenge - Stacks and Quenes

Author: Karina Chen

## Description
This is a daily code challenges. The task is to declare methods for Stack and Queue classes.
Declare methods that allow the stack and queue to push/enqueue a new node, pop/dequeue a node, peek a node, and check if the stack/queue is empty.

## Approach

##### push() method:
Take a value and create a new node with the value. Then points the node.Next to the top of the stack. Point the stack top to the new node.

Big O: O(1)

##### pop() method: 
Get the top node on the stack and reads its value. Point the stack top to the node.Next then deduct the stack count by 1. Return the node value.

Big O: O(1)

##### enqueue() method:
Take a value and create a new node with the value. Then points the node.Next to the front of the queue. Point the queue front to the new node.

Big O: O(1)

##### dequeue() method: 
Get the front node on the queue and reads its value. Point the queue front to the node.Next then deduct the queue count by 1. Return the node value.

Big O: O(1)

##### peek() method:
Get the top node on the stack or the front node of the queue and reads its value. Return the value.

Big O: O(1)

##### isEmpty() method: 
Get the stack or queue count to see if there are anything on the stack or queue. Return true or false.

Big O: O(1)

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

## Resource
https://denisrizov.com/2013/05/26/dynamic-stack-implementation-c/

https://denisrizov.com/2013/05/27/dynamic-queue-implementation-c/

## Visuals

White-Boarding
![Alt whiteboarding capture](/Assets/code10_1.jpg)
![Alt whiteboarding capture](/Assets/code10_2.jpg)
![Alt whiteboarding capture](/Assets/code10_3.jpg)
![Alt whiteboarding capture](/Assets/code10_4.jpg)

Result

![Alt execution capture](/Assets/code10_5.JPG)
![Alt execution capture](/Assets/code10_6.JPG)

## Change Log

1.1: Set up the program, add Table of Contents to README. - 2019 Nov 03

1.2: Add Node, Stack, and Queue classes. Add properties and constructor methods to each class. - 2019 Nov 03

1.3: Add Push() method to Stack class. Add PrintStack() method to print out all the values on the stack. - 2019 Nov 03

1.4: Add Pop() and Peek() method to Stack class. - 2019 Nov 03

1.5: Add isEmpty() method to Stack class. - 2019 Nov 03

1.6: Add another Node class for Queue class with differen construtor method. Add Enqueue() method to Queue class. - 2019 Nov 03

1.7: Add Dequeue() method to Queue class. - 2019 Nov 03

1.8: Add Peek() method to Queue class. - 2019 Nov 03

1.9: Add isEmpty() method to Queue class. - 2019 Nov 03

1.10: Add unit testing. Pass all tests. The program is completed. - 2019 Nov 03

