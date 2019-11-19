# data-structures-and-algorithms-c#

## About This Program
Challenge - Insertion Sort

Author: Karina Chen

## Description
This is a daily code challenges. The task is to create a method that takes in a number array then sort the array using insertion sort. The method is to sort the array to have the numbers sorted from smallest value to the largest value.

## Insertion Sort
Insertion sort is a simple sorting algorithm that sort an array by comparing two adjacent elements at a time.This sorting algorithm is easy to implement and efficient for sorting small data sets.

## Result
![Alt app execution capture](/Assets/code26_2.JPG)

## Pseudocode
```
InsertionSort(int[] arr)
  
    FOR i = 1 to arr.length
    
      int j <-- i - 1
      int temp <-- arr[i]
      
      WHILE j >= 0 AND temp < arr[j]
        arr[j + 1] <-- arr[j]
        j <-- j - 1
        
      arr[j + 1] <-- temp
```
## Trace
Sample Array:
[8,4,23,42,16,15]


**Progress:**
![Alt app execution capture](/Assets/code26_1.jpg)

**Pass 1:**

In the first pass of the insertion sort, the method evaluates if there are any number that is smaller then the current number at index position 0. A variable named "temp" is used to store the number that is at the next index position. For the first pass, temp is the second number in the array that is going to be compared with the first number in the array. If temp number is smaller than the current number, the two numbers swap their index positions.

 In the first pass, temp value (index position 1, number 4) is smaller than the current value (index position 0, number 8), the two numbers swap their index positions.

Array after 1st pass:

[_**4**_, _**8**_, 23, 42, 16, 15]


**Pass 2:**

For the second pass, the current index becomes 1 (number 8) and the temp becomes 23 which is at index position 2. The method compares number 8 with 23. Since temp value (23) is not smaller than the current value (8), no swap occurs at the second pass. 

Array after 2nd pass:

[4, 8, 23, 42, 16, 15]


**Pass 3:**

For the third pass, the current index becomes 2 (number 23) and the temp becomes 42 which is at index position 3. The method compares number 23 with 42. Since temp value (42) is not smaller than the current value (23), no swap occurs at the third pass. 

Array after 2nd pass:

[4, 8, 23, 42, 16, 15]


**Pass 4:**

For the fourth pass, the current index is now 3, which is number 42. The temp becomes 16, which is at index position 4. The method compares number 42 with 16. The temp value (16) is smaller than the current value (42), the two numbers are swapped. 

At this point the array becomes this:

[4, 8, 23, _**16**_, _**42**_, 15]


Inside the method, the while loop is still comparing the numbers. The temp value now becomes the number at index position 3, which is number 16. The current value now becomes the number at index position 2. Compare the two numbers together. The temp value (16) is smaller than the current value (23), so another swap occurs. 

Array after 4th pass:

[4, 8, _**16**_, _**23**_, 42, 15]


**Pass 5:**

For the fifth pass, the current index is 4, which is number 42. The temp becomes 15, which is at index position 5. The method compares number 15 with 16. The temp value (15) is smaller than the current value (42), the two numbers are swapped. 

At this point the array becomes this:

[4, 8, 16, 23, _**15**_, _**42**_]


Inside the method, the while loop is still comparing the numbers. The temp value now becomes the number at index position 4, which is number 15. The current value now becomes the number at index position 3. Compare the two numbers together. The temp value (15) is smaller than the current value (23), so another swap occurs. 

At this point the array becomes this:

[4, 8, 16, _**15**_, _**23**_, 42]


The while loop then changes the temp to be the value at index position 3, which is number 15. The current value now becomes the number at index position 2. Compare the two numbers together. The temp value (15) is smaller than the current value (16), a third swap occurs for this pass.
 
Array after 5th pass:

[4, 8, _**15**_, _**16**_, 23, 42]


## Efficency

* **Time: O(n^2)**
  * Since insertion sort is comparing the current number to the rest of the number in the array, if there is a number that is smaller than the current number, the smaller number is then moved to the current index position and the current number is then moved to the next index position. The worse case scenario is that every number in the array is to be moved to another index position. Therefore the Big O time is O(n^2).

* **Space: O(1)**
  * The array is being sorted in place so the Big O space is always going to be the size of the array.