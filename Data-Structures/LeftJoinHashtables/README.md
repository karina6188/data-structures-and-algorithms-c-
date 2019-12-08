# data-structures-and-algorithms-c#

## About This Program
Challenge - Left Join Hash Tables

Author: Karina Chen

## Description
This is a daily code challenges. The task is to create a method called LeftJoin() that takes in 2 hash tables and join the data together as one single hash table according to Left Join logic. The first parameter is a hash table that has word strings as keys, and a synonym of the key as values. The second parameter is a hash table that has word strings as keys, and antonyms of the key as values. The method combines the key and the corresponding values into a new data structure according to Left Join logic.

That means all the values in the first hash table are returned, and if values esitst in the second hash table, the values are appended together and show in the result table. If the values from the first hash table do not exist in the second hash table, null would be appended to the values.
 
## Approach & Efficiency
##### LeftJoin():


##### Add():
Accepts a key and a value. Then sends the key to Hash() method to generate a hash which is used to determine the index position where the key/value pair is to be stored in the hashtable. After Hash() method calculates the index, it returns an index to Add() method. Add() method then goes to the index position inside the hashtable and stores the key/value pair to the end of the linked list inside the bucket at the index position.

##### Get():
Takes in the key and returns the value from the hashtable. Get() method calls Hash() method and sends over the key to get the index of where the key/value pair is stored then goes to the stored location. Get() method then iterate through the linked list at the index position to find the key. If the key exists, return the value.

##### Contains():
Takes in the key and returns a boolean indicating if the key already exists in the hashtable. Contains() method calls Hash() method to get the index then goes to the index position to check if the key exists.

##### Hash():
Takes in a key and returns an index position of a hashtable. Hash() method uses the key to generate a hash. The hash is calculated and the result of it will be an integer that is smaller than the array size of the hashtable. The integer represents an index of the hashtable and is returned to the previous call stack.

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

Whiteboarding

![Alt app execution capture](/Assets/.jpg)

![Alt app execution capture](/Assets/.jpg)

Result

![Alt app execution capture](/Assets/.JPG)

## Change Log

1.1: Set up the program, add Table of Contents to README. - 2019 Dec 08

1.2: Add desctiptions, approach, and efficiency to README. - 2019 Dec 08

1.3: Add a HashTable class and scaffold methods. - 2019 Dec 08

1.4: Add a Node class. - 2019 Dec 08

1.5. 