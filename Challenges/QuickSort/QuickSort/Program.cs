using System;

namespace QuickSort
{
    public class Program
    {
        /// <summary>
        /// Call Quicksort method to sort the array and set the left and right points to be index 0 and the last index of the array.
        /// Call PrintArray method to print out arrays.
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            int[] array = new int[] { 8, 4, 23, 42, 16, 15 };
            Console.Write("Array: ");
            PrintArray(array);
            Console.Write("Result: ");
            PrintArray(Quicksort(array, 0, array.Length - 1));

            int[] array2 = new int[] { 20, 18, 12, 8, 5, -2 };
            Console.Write("\nArray: ");
            PrintArray(array2);
            Console.Write("Result: ");
            PrintArray(Quicksort(array2, 0, array2.Length - 1));

            int[] array3 = new int[] { 5, 12, 7, 5, 5, 7 };
            Console.Write("\nArray: ");
            PrintArray(array3);
            Console.Write("Result: ");
            PrintArray(Quicksort(array3, 0, array3.Length - 1));

            int[] array4 = new int[] { 2, 3, 5, 7, 13, 11 };
            Console.Write("\nArray: ");
            PrintArray(array4);
            Console.Write("Result: ");
            PrintArray(Quicksort(array4, 0, array4.Length - 1));
        }

        /// <summary>
        /// This method calls Partition method and sends in the left and right index positions.
        /// Quicksort method recursively calls itself to partitions the sub arrays and sort left and right sub arrays.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static int[] Quicksort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int position = Partition(arr, left, right);

                Quicksort(arr, left, position - 1);
                Quicksort(arr, position + 1, right);
            }
            return arr;
        }

        /// <summary>
        /// This method sets the most right element to be the pivot and sets an index tracker called low to be at the previous index of left.
        /// Use for loop to loop through elements from left to right.
        /// If the element is smaller than the pivot, move the low tracker to the next index position then runs Swap method.
        /// After all the elements have been checked and compared to the pivot, they should be swapped to the left or the right side of the array.
        /// Then calls another Swap method to move the pivot to be at the correct position within the array.
        /// Now the elements which are smaller than the pivot are on the left side of it and the elements which are larger than the pivot are on the right side of it.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];

            int low = left - 1;
            for (int i = left; i < right; i++)
            {
                if (arr[i] <= pivot)
                {
                    low++;
                    Swap(arr, i, low);
                }
            }
            Swap(arr, right, low + 1);
            return low + 1;
        }

        /// <summary>
        /// Takes in an array and two index trackers i and low.
        /// Store the current element at index position i in variable temp.
        /// Assign element at index position low to be the element at index position i.
        /// Assign element at index potition low to be temp.
        /// This completes the swap of the two elements at index positions i and low.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="i"></param>
        /// <param name="low"></param>
        static void Swap(int[] arr, int i, int low)
        {
            int temp;
            temp = arr[i];
            arr[i] = arr[low];
            arr[low] = temp;
        }

        /// <summary>
        /// Use a for loop to print out all the elements of an array.
        /// </summary>
        /// <param name="arr"></param>
        public static string PrintArray(int[] arr)
        {
            string output = "[";
            Console.Write("[");
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.Write($"{arr[i]}, ");
                output += $"{arr[i]}, ";
            }
            Console.Write($"{arr[arr.Length - 1]}]");
            output += $"{arr[arr.Length - 1]}]";
            Console.WriteLine();
            return output;
        }
    }
}
