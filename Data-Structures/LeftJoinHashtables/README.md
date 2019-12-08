# data-structures-and-algorithms-c#

## About This Program
Challenge - Left Join Hash Tables

Author: Karina Chen

## Description
This is a daily code challenges. The task is to create a method called LeftJoin() that takes in 2 hash tables and join the data together as one single hash table according to Left Join logic. The first parameter is a hash table that has word strings as keys, and a synonym of the key as values. The second parameter is a hash table that has word strings as keys, and antonyms of the key as values. The method combines the key and the corresponding values into a new data structure according to Left Join logic.

That means all the values in the first hash table are returned, and if values esitst in the second hash table, the values are appended together and show in the result table. If the values from the first hash table do not exist in the second hash table, null would be appended to the values.
 
## Approach & Efficiency
##### LeftJoin():
Takes in two data tables then creates a result table with the same numbers of table 1's buckets. Loop through the table 1's buckets to add all the nodes key/values into the result table. Then loop through the result table to find if table 2 has the keys that result table has. Using Contains method to check. If table 2 has keys that the result table has, Contains method returns the index position of the bucket where the key is found. If the key that result table has but table 2 does not have, Contains method returns -1 to indicate that the key is not found in any index position of the buckets. Then add "null" to the result table's value where the key is not found in table 2. If the key is found, go to the index position of the buckets and get the node's value then add it to the result's table where the keys are matched. The method outputs the result table with all the key/value pairs from table 1 and table 2 if table 2 has the same keys with table 1.

##### AddNode():
Takes in a key and a value of string type then loop through the total number of buckets in a hash table. If the bucket is empty, add the key/value pair into the bucket. Otherwise, move to the next available bucket then add the new node into the bucket.

##### Contains():
Takes in a key then loop through all the buckets. If the bucket is empty, return -1 to indicate the key is not found. If the bucket has a node, check if the node's key matches with the finding key. If yes, return the current index position of the bucket where the key is found. The index position of the buckets where the key is found. If not found, return -1.

##### PrintTable();
Takes in a hash table and console write how many data rows are in the table. Loop through the buckets of the table to print out each row of key/value pair. If the bucket is empty, console write "empty row" then exit the method. If the bucket has a node, console write the node's key and value.

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

![Alt app execution capture](/Assets/code33_1.JPG)

## Change Log

1.1: Set up the program, add Table of Contents to README. - 2019 Dec 08

1.2: Add desctiptions, approach, and efficiency to README. - 2019 Dec 08

1.3: Add a HashTable class and scaffold methods. - 2019 Dec 08

1.4: Add a Node class. - 2019 Dec 08

1.5. Add a HashTable class. - 2019 Dec 08

1.6: Add AddNode() and Contains() methods. - 2019 Dec 08

1.7: Add LeftJoin() and PrintTable() methods. - 2019 Dec 08

1.8: Add unit testing. Pass all tests. The program is completed. - 2019 Dec 08