using System;

namespace MergeSort
{
    public class Program
    {
        /// <summary>
        /// Call Mergesort method to sort the array using quick sort.
        /// Call PrintArray method to print out the array.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] array = { 8, 4, 23, 42, 16, 15 };
            PrintArray(Mergesort(array));

            int[] array2 = { 20, 18, 12, 8, 5, -2 };
            PrintArray(Mergesort(array2));

            int[] array3 = { 5, 12, 7, 5, 5, 7 };
            PrintArray(Mergesort(array3));

            int[] array4 = { 2, 3, 5, 7, 13, 11 };
            PrintArray(Mergesort(array4));
        }

        /// <summary>
        /// Takes in an array and split the array into left and right sub arrays using mid point of the array length.
        /// Call the method recursively until all the values inside the array are splited into left and right sub arrays.
        /// Keep doing this until the sub array length is 1.
        /// Then recursively call Merge method.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int[] Mergesort(int[] arr)
        {
            int n = arr.Length;
            int[] result = new int[n];
            if (n <= 1)
            {
                return arr;
            }
            if (n > 1)
            {
                int mid = n / 2;
                int[] left = new int[mid];
                int[] right = new int[n - mid];

                for (int i = 0; i < mid; i++)
                {
                    left[i] = arr[i];
                }

                int x = 0;
                for (int i = mid; i < arr.Length; i++)
                {
                    right[x] = arr[i];
                    x++;
                }

                left = Mergesort(left);
                right = Mergesort(right);
                result = Merge(left, right, arr);
            }
            return result;
        }

        /// <summary>
        /// Takes in left and right sub arrays and takes in original array to get the length for result array.
        /// Set index trackers to 0 for left, right , and result arrays.
        /// Compare the left and right sub arrays index position 0. Assign the smaller value to be value of the result array at index position 0.
        /// Then increase the index tracker of the result array and the sub array of the selected value to the next index.
        /// Keep doing this until either the left or the right sub array has reached to the end of the array.
        /// Then assign the remaining sub array to be the values after the current index position of the result array.
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <param name="arr"></param>
        /// <returns></returns>
        static int[] Merge(int[] left, int[] right, int[] arr)
        {
            // left index
            int i = 0;
            // right index
            int j = 0;
            // result index
            int k = 0;
            int[] result = new int[arr.Length];

            while (i < left.Length || j < right.Length)
            {
                if (i < left.Length && j < right.Length)
                {
                    if (left[i] <= right[j])
                    {
                        result[k] = left[i];
                        i++;
                    }
                    else
                    {
                        result[k] = right[j];
                        j++;
                    }
                    k++;
                }
                else if (i < left.Length)
                {
                    result[k] = left[i];
                    i++;
                    k++;
                }
                else if (j < right.Length)
                {
                    result[k] = right[j];
                    j++;
                    k++;
                }
            }
            return result;
        }

        /// <summary>
        /// Takes in an array and use for loop to loop through each value inside the array and print to the console.
        /// </summary>
        /// <param name="arr"></param>
        static void PrintArray(int[] arr)
        {
            Console.Write("[");
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.Write($"{arr[i]}, ");
            }
            Console.Write($"{arr[arr.Length - 1]}]");
            Console.WriteLine();
        }
    }
}
