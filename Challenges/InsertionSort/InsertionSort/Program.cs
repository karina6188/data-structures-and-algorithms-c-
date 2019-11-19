using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 8, 4, 23, 42, 16, 15 };
            InsertionSort(array1);
            Console.WriteLine("Sort array [8, 4, 23, 42, 16, 15] using insertion sort:");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine();
            }
        }

        static void InsertionSort(int[] arr)
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
    }
}
