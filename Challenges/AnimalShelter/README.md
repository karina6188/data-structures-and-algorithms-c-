# data-structures-and-algorithms-c#

## About This Program
Challenges - Animal Shelter

Author: Karina Chen

## Description
This is a daily code challenges. The task is to implement first-in, first-out method to enqueue and dequeue values from stacks.

## Approach
enqueue(value) method: First, pop all the values from stack1 and push them into stack2. Then, enqueue the new value into stack1. Pop all the values from stack2 and push all back to stack1. Return all the values in stack1. If the stack is empty, only the new value is enqueued into stack1 and returned.

dequeue() method: this method removes the last value from stack1. Use peek() method to know the what the last value on stack1 is, then pop it out from stack1. Return the dequeued value.

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
![Alt whiteboarding capture](/Assets/code12_1.jpg)
![Alt whiteboarding capture](/Assets/code12_2.jpg)

Result
![Alt whiteboarding capture](/Assets/code12_3.JPG)

## Change Log

1.1: Set up the program, add Table of Contents to README. - 2019 Oct 29

1.2: Add enqueue(animal) method. - 2019 Oct 29

1.3: Add dequeue(pref) method. - 2019 Oct 29

1.4: 