# data-structures-and-algorithms-c#

## About This Program
Challenge - Insertion Sort

Author: Karina Chen

## Description
This is a daily code challenges. The task is to create a method that takes in a number array then sort the array using insertion sort. The method is to sort the array to have the numbers sorted from smallest value to the largest value.

## Insertion Sort
Insertion sort is a simple sorting algorithm that sort an array by comparing two adjacent elements at a time.This sorting algorithm is easy to implement and efficient for sorting small data sets.

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
`
[8,4,23,42,16,15]
`

**Progress:**
![Alt app execution capture](/Assets/code15_1.JPG)

**Pass 1:**

**Pass 2:**

**Pass 3:**

**Pass 4:**

**Pass 5:**

**Pass 6:**

## Change Log

1.1: Set up the program, add Table of Contents to README. - 2019 Nov 06

1.2: Create a Node class. - 2019 Nov 06

1.3: Create a BinaryTree class. - 2019 Nov 06

1.4: Add PreOrder(), InOrder(), and PostOrder() methods. - 2019 Nov 06

1.5: Create a TraverseBinaryTree() method. - 2019 Nov 06

1.6: Add BinarySearchTree class. - 2019 Nov 06

1.7: Create a traverseBinarySearch() method to traverse each node in the binary search tree using breadth first traversal. - 2019 Nov 06

1.8: Add add() method to add a new node with a value to the correct position on the tree. - 2019 Nov 06

1.9: Add contains() method to check if a value exists on the tree. - 2019 Nov 06

1.10: Add try and catch blocks. - 2019 Nov 06

1.11: Add unit testing. Pass all the tests. The program is completed. - 2019 Nov 06