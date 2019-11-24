using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 8, 4, 23, 42, 16, 15 };
            PrintArray(Mergesort(array));

            int[] array2 = { 20, 18, 12, 8, 5, -2 };
            //Mergesort(array2);

            int[] array3 = { 5, 12, 7, 5, 5, 7 };
            //Mergesort(array3);

            int[] array4 = { 2, 3, 5, 7, 13, 11 };
            //Mergesort(array4);
        }

        static int[] Mergesort(int[] arr)
        {
            int n = arr.Length;
            if (n <= 1)
            {
                return arr;
            }
            if (n > 1)
            {
                int mid = n / 2;
                int[] left = new int[mid];
                int[] right = new int[n - mid];
                int[] result = new int[n];

                for (int i = 0; i < mid; i++)
                {
                    left[i] = arr[i];
                }

                Console.Write("Left: [");
                for (int i = 0; i < mid - 1; i++)
                {
                    Console.Write($"{left[i]}, ");
                }
                Console.Write($"{left[mid - 1]}] \n");

                int x = 0;
                for (int i = mid; i < arr.Length; i++)
                {
                    right[x] = arr[i];
                    x++;
                }

                Console.Write("Right: [");
                for (int i = 0; i < n - mid; i++)
                {
                    Console.Write($"{right[i]}, ");
                }
                Console.Write($"{right[n - mid - 1]}] \n");

                Mergesort(left);

                Mergesort(right);

                //Merge(left, right, result);
            }
            return arr;
        }

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
        static void PrintArray(int[] arr)
        {
            Console.WriteLine("[");
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.WriteLine($"{arr[i]}, ");
            }
            Console.WriteLine($"{arr[arr.Length - 1]}]");
        }
    }
}
