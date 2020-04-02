# data-structures-and-algorithms-c#

## About This Program
Challenge - Merge Sort

Author: Karina Chen

## Description
This is a daily code challenges. The task is to create a method that takes in a number array then sort the array using merge sort. The array will be sorted from smaller values to bigger values. The method cuts the array in half and does this recursively until there is only one value in the array, then the method compares the number at an index position in the left array to the number at the same index position in the right array. The smaller value is then added into the final sorted array. The method will do this recursively until all the numbers are compared and added into the final sorted array.

## Merge Sort
MergeSort is a divide-and-conquer algorithm that splits an array into two parts then recursively sorts each sub array before merging the values back into one sorted array.

## Result
![Alt app execution capture](/Assets/code27_24.JPG)

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

The initial array is split into left and right sub array. From the pseudocode, Mergesort(left) is called first. This is a recursion that the array will be splited into halves and the method goes to the left sub array and do this over and over until the left sub array's length is 1.
Then it moves to the right sub array and does the same thing until there is only one number left in the right sub array.

![Alt app execution capture](/Assets/code27_1.jpg)
![Alt app execution capture](/Assets/code27_2.jpg)
![Alt app execution capture](/Assets/code27_3.jpg)
![Alt app execution capture](/Assets/code27_4.jpg)
![Alt app execution capture](/Assets/code27_5.jpg)

**Pass 2:**

Once MergeSort(left) method is done spliting the left half of the initial array, it moves to MergeSort(right) and recursively spliting the right half of the initial array into sub arrays. The recursion ends when there is only 1 number left in the sub array.
After that it moves to the right sub array of the sub arrays and does the same thing until there is only one number left in the right sub array which is the very bottom of the recursion height.

![Alt app execution capture](/Assets/code27_6.jpg)
![Alt app execution capture](/Assets/code27_7.jpg)
![Alt app execution capture](/Assets/code27_8.jpg)
![Alt app execution capture](/Assets/code27_9.jpg)
![Alt app execution capture](/Assets/code27_10.jpg)
![Alt app execution capture](/Assets/code27_11.jpg)

**Pass 3:**

Now that every single number in the initial array has be splited into its own array that contains only one number. MergeSort method then calls an ouside method called Merge.
Merge method declares three index trackers. They are tracking index of left sub array, index of right sub array, and index of the final result array. Before the first pass, every tracker is set to be at index position 0.

Merge method compares the two numbers at the same index position of left and right sub arrays. Merge method then picks the number that is smaller and adds the number into the final result array. Whichever the sub array that has a number being picked by the Merge method needs to increase its index tracker by 1. The other sub array that is not being picked does not need to change its index tracker. The final result array needs to increase its index tracker by 1 because a number is added and now the index needs to move to the next one so the next number comes after the pervious number and does not replace the previous number.

![Alt app execution capture](/Assets/code27_12.jpg)
![Alt app execution capture](/Assets/code27_13.jpg)
![Alt app execution capture](/Assets/code27_14.jpg)

**Pass 4:**

After Merge method is done sorting and merging the left sub arrays, it now moves to the right half of the sub arrays and does the same thing. Once the index trackers reach to the end of the sub arrays, it breaks out from the while loop.

![Alt app execution capture](/Assets/code27_15.jpg)
![Alt app execution capture](/Assets/code27_16.jpg)
![Alt app execution capture](/Assets/code27_17.jpg)

**Pass 5:**

Finally, the last step is to merge the sorted left half array with the sorted right half array. This is the same as previous steps. The method compares the numbers at the same index position of left and right half arrays then adds the smaller number into the final result array until all the numbers are sorted and merged into one single final result array. Then the merge sort is completed.

![Alt app execution capture](/Assets/code27_18.jpg)
![Alt app execution capture](/Assets/code27_19.jpg)
![Alt app execution capture](/Assets/code27_20.jpg)
![Alt app execution capture](/Assets/code27_21.jpg)
![Alt app execution capture](/Assets/code27_22.jpg)
![Alt app execution capture](/Assets/code27_23.jpg)

## Efficency

* **Time: O(nlogn)**
  * The big O time for merge sort is O(nlogn). The O(**n**logn) here is because of the while loop that keeps spliting all the values until there is only one value in the sub array. O(n**log**n) is because the array is splited into halves recursively. O(nlog**n**) the n here represents the height of the recursion.

* **Space: O(n)**
  * The array is not being sorted in-place. Every time a sub array is sorted, merge sort makes a copy of it. Therefore the big O space for merge sort is O(n).
