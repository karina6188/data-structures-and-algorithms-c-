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
![Alt app execution capture](/Assets/code26_1.jpg)

**Pass 1:**

**Pass 2:**

**Pass 3:**

**Pass 4:**

**Pass 5:**

**Pass 6:**

## Efficency

* **Time: O(n^2)**
  * Since insertion sort is comparing each element to the next adjacent element, then if the next element is smaller than the current element, the next element is moved to the current index and the current element is moved to the next index position. The worse case scenario is that every element in the array is to be moved to another index position. Therefore the Big O time is O(n^2).

* **Space: O(1)**
  * The array is being sorted in place so the Big O space is always going to be the size of the array.