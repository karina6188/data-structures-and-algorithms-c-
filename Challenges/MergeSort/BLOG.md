# data-structures-and-algorithms-c#

## About This Program
Challenge - Merge Sort

Author: Karina Chen

## Description
This is a daily code challenges. The task is to create a method that takes in a number array then sort the array using merge sort. The array will be sorted from smaller values to bigger values. The method cuts the array in half and does this recursively until there is only one value in the array, then the method compares the number at an index position in the left array to the number at the same index position in the right array. The smaller value is then added into the final sorted array. The method will do this recursively until all the numbers are compared and added into the final sorted array.

## Merge Sort
MergeSort is a divide-and-conquer algorithm that splits an array into two parts then recursively sorts each sub array before merging the values back into one sorted array.

## Result
![Alt app execution capture](/Assets/.JPG)

## Pseudocode
```
 ALGORITHM Mergesort(arr)
    DECLARE n <-- arr.length
           
    if n > 1
      DECLARE mid <-- n/2
      DECLARE left <-- arr[0...mid]
      DECLARE right <-- arr[mid...n]
      // sort the left side
      Mergesort(left)
      // sort the right side
      Mergesort(right)
      // merge the sorted left and right sides together
      Merge(left, right, arr)

 ALGORITHM Merge(left, right, arr)
    DECLARE i <-- 0
    DECLARE j <-- 0
    DECLARE k <-- 0

    while i < left.length && j < right.length
        if left[i] <= right[j]
            arr[k] <-- left[i]
            i <-- i + 1
        else
            arr[k] <-- right[j]
            j <-- j + 1
            
        k <-- k + 1

    if i = left.length
       set remaining entries in arr to remaining values in right
    else
       set remaining entries in arr to remaining values in left
```
## Trace
Sample Array:
[8,4,23,42,16,15]


**Progress:**

**Pass 1:**

![Alt app execution capture](/Assets/code27_1.jpg)





**Pass 2:**

![Alt app execution capture](/Assets/code27_2.jpg)



**Pass 3:**

![Alt app execution capture](/Assets/code27_3.jpg)



**Pass 4:**

![Alt app execution capture](/Assets/code27_4.jpg)




**Pass 5:**

 ![Alt app execution capture](/Assets/code27_5.jpg)




## Efficency

* **Time: O(nlogn)**
  * The bio O time for merge sort is O(nlogn). The O(**n**logn) here is because of the while loop that keeps spliting all the values until there is only one value in the sub array. O(n**log**n) is because the array is splited into halves recursively. O(nlog**n**) the n here represents the height of the recursion.

* **Space: O(n)**
  * The array is not being sorted in-place. Every time a sub array is sorted, merge sort makes a copy of it. Therefore the big O space for merge sort is O(n).