# data-structures-and-algorithms-c#

## About This Program
Challenge - Multi-Bracket Validation

Author: Karina Chen

## Description
This is a daily code challenges. The task is to create a method called MultiBracketValidation() that takes a string as its parameter and validate if the brackets inside the string are balanced.

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
![Alt whiteboarding capture](/Assets/code13_1.jpg)
![Alt whiteboarding capture](/Assets/code13_2.jpg)

App Execution

![Alt app execution capture](/Assets/code13_3.JPG)
![Alt app execution capture](/Assets/code13_4.JPG)

## Change Log

1.1: Set up the program, add Table of Contents to README. - 2019 Oct 30

1.2: Add codes to split the input string into characters and loop through characters to find opening brackets. - 2019 Oct 30

1.3: Add codes to method MultiBracketValidation(input) if find opening brackets in characters, push the opening brackets into the stack. When find closing brackets in the characters, compare if the last item in the stack matches the closing bracket. If not, the string does not have balanced brackets and return false. If yes, pop the matching opening bracket from the stack and move on to the next character. - 2019 Oct 30

1.4: After all the characters have been looped through, check if there is any opening brackets left in the stack. If yes, return false. If no, return true. - 2019 Oct 30

1.5: Add unit testing. Pass all tests. The program is completed. - 2019 Oct 30

