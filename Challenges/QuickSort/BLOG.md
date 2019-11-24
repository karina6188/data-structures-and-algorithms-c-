# data-structures-and-algorithms-c#

## About This Program
Challenge - Quick Sort

Author: Karina Chen

## Description
This is a daily code challenges. The task is to create a method that takes in a number array then sort the array using quick sort. The elements of the array will be sorted from smaller values to larger values.

## Quick Sort
Quick Sort is an effective sorting algorithm based on the divide and conquer approach. The quick sort algorithm partitions the array by making one of the array element to be a pivot. Therefore the array is partitioned into three parts: 1) the pivot element, 2) elements less than the pivot, and 3) element greater than the pivot.

## Result
![Alt app execution capture](/Assets/.JPG)

## Pseudocode
```
 ALGORITHM QuickSort(arr, left, right)
    if left < right
        // Partition the array by setting the position of the pivot value 
        DEFINE position <-- Partition(arr, left, right)
        // Sort the left
        QuickSort(arr, left, position - 1)
        // Sort the right
        QuickSort(arr, position + 1, right)

 ALGORITHM Partition(arr, left, right)
    // set a pivot value as a point of reference
    DEFINE pivot <-- arr[right]
    // create a variable to track the largest index of numbers lower than the defined pivot
    DEFINE low <-- left - 1
    for i <- left to right do
        if arr[i] <= pivot
            low++
            Swap(arr, i, low)

     // place the value of the pivot location in the middle.
     // all numbers smaller than the pivot are on the left, larger on the right. 
     Swap(arr, right, low + 1)
    // return the pivot index point
     return low + 1

 ALGORITHM Swap(arr, i, low)
    DEFINE temp;
    temp <-- arr[i]
    arr[i] <-- arr[low]
    arr[low] <-- temp
```
## Trace
Sample Array:
[8,4,23,42,16,15]

**Progress:**

**Part 1:**


![Alt app execution capture](/Assets/code28_1.jpg)

**Part 2:**


**Part 3:**


**Pass 4:**


**Pass 5:**



## Efficency

* **Time: O(nlogn)**
  * The bio O time for merge sort is O(nlogn). The O(**n**logn) here is because of the while loop that keeps spliting all the values until there is only one value in the sub array. O(n**log**n) is because the array is splited into halves recursively. O(nlog**n**) the n here represents the height of the recursion.

* **Space: O(n)**
  * The array is not being sorted in-place. Every time a sub array is sorted, merge sort makes a copy of it. Therefore the big O space for merge sort is O(n).