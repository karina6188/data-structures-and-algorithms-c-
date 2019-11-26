# data-structures-and-algorithms-c#

## About This Program
Challenge - Repeated Word

Author: Karina Chen

## Description
This is a daily code challenges. The task is to create a method that takes in a lengthy string and returns the first repeated word in the string. If all of the words in the string are unique without any repetitions, return "no repeated word is found". A hashtable will need to be creeated in order to implement this method. A node class is also required to store data into the linked list for each of the bucket in the hashtable.
 
## Approach & Efficiency
##### RepeatedWord():
Takes in a lengthy string and returns the first repeated word or "no repeated word is found". The method first uses spaces or punctuations to split the in-take string into a string array contains all the individual words. Then the method loops through the string array and for every iteration and uses Contains() method to check if the word exists in the hashtable. If yes, return the word and exits the method. If not, use Add() method to add the word into the hashtable then move on to the next word. If all the words in the string array are looped through and no any repeated word is found, return "no repeated word is found".

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

Result

![Alt app execution capture](/Assets/.JPG)

## Resource
https://stackoverflow.com/questions/400733/how-to-get-ascii-value-of-string-in-c-sharp/400738

## Change Log

1.1: Set up the program, add Table of Contents to README. - 2019 Nov 25

1.2: Add desctiptions, approach, and efficiency to README. - 2019 Nov 25

1.3: Add Hashtable class and scaffold methods. - 2019 Nov 25

1.4: 