using System;

namespace Insertion_Sort
{
    public class Program
    {
        /// <summary>
        /// Call InsertionSort method to sort number arrays.
        /// Call PrintArray method to print out the initial and sorted arrays.
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            int[] array1 = new int[] { 8, 4, 23, 42, 16, 15 };
            InsertionSort(array1);
            Console.WriteLine("Use insertion sort to sort array [8, 4, 23, 42, 16, 15]:");
            PrintArray(array1);
            Console.WriteLine("");
            Console.WriteLine("");

            int[] array2 = new int[] { 20, 18, 12, 8, 5, -2 };
            InsertionSort(array2);
            Console.WriteLine("Use insertion sort to sort array [20, 18, 12, 8, 5, -2]:");
            PrintArray(array2);
            Console.WriteLine("");
            Console.WriteLine("");

            int[] array3 = new int[] { 5, 12, 7, 5, 5, 7 };
            InsertionSort(array3);
            Console.WriteLine("Use insertion sort to sort array [5, 12, 7, 5, 5, 7]:");
            PrintArray(array3);
            Console.WriteLine("");
            Console.WriteLine("");

            int[] array4 = new int[] { 2, 3, 5, 7, 13, 11 };
            InsertionSort(array4);
            Console.WriteLine("Use insertion sort to sort array [2, 3, 5, 7, 13, 11]:");
            PrintArray(array4);
            Console.WriteLine("");
        }

        /// <summary>
        /// This method takes in a number array then compare the numbers starting at index 0.
        /// A variable named temp is used to store the next number after the current number.
        /// If temp is smaller than the current number, the two numbers swap their index positions.
        /// Use a while loop to keep comparing the two adjacent numbers together.
        /// Inside the while loop, temp value and the current number are changed accordingly to be the previous index positions to check if every number is sorted to be at their correct position before the current index position.
        /// Keep doing this until the method reaches to the last number of the array and completes the sorting.
        /// </summary>
        /// <param name="arr"></param>
        public static void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int j = i - 1;
                int temp = arr[i];

                while (j >= 0 && temp < arr[j])
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                    arr[j + 1] = temp;
                }
            }
        }

        /// <summary>
        /// This method takes in a number array and print it out in a format of an array.
        /// </summary>
        /// <param name="arr"></param>
        public static void PrintArray(int[] arr)
        {
            Console.Write("[");
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.Write($"{arr[i]}, ");
            }
            Console.Write($"{arr[arr.Length - 1]}]");
        }
    }
}
