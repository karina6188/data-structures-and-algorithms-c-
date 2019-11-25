using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
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

        static int[] Quicksort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int position = Partition(arr, left, right);

                Quicksort(arr, left, position - 1);
                Quicksort(arr, position + 1, right);
            }
            return arr;
        }

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

        static void Swap(int[] arr, int i, int low)
        {
            int temp;
            temp = arr[i];
            arr[i] = arr[low];
            arr[low] = temp;
        }

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
