using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 8, 4, 23, 42, 16, 15 };
            Mergesort(array);
            PrintArray()

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
            if (n <= 0)
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
                    //Console.WriteLine(left[i]);
                }

                int x = 0;
                for (int i = mid; i < arr.Length; i++)
                {
                    right[x] = arr[i];
                    //Console.WriteLine(right[x]);
                    x++;
                }

                Mergesort(left);

                Mergesort(right);

                Merge(left, right, arr);
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

            if (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    arr[k] = left[i];
                    i++;
                }
                else
                {
                    arr[k] = right[j];
                    j++;
                }
                k++;
            }
            else if (j < right.Length)
            {
                arr[k] = right[j];
                k++;
                j++;
            }
            else
            {
                arr[k] = left[j];
                k++;
                i++;
            }
            return arr;
        }
        static void PrintArray(int[] arr)
        {
            Console.WriteLine("[");
            for (int i = 0; i < arr.Length-1; i++)
            {
                Console.WriteLine($"{arr[i]}, ");
            }
            Console.WriteLine($"{arr[arr.Length]}]");
        }
    }
}
