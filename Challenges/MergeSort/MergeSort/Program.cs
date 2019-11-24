using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 8, 4, 23, 42, 16, 15, 5 };
            Mergesort(array);

            int[] array2 = { 20, 18, 12, 8, 5, -2 };
            //Mergesort(array2);

            int[] array3 = { 5, 12, 7, 5, 5, 7 };
            //Mergesort(array3);

            int[] array4 = { 2, 3, 5, 7, 13, 11 };
            //Mergesort(array4);
        }

        static void Mergesort(int[] arr)
        {
            int n = arr.Length;
            if (n > 1)
            {
                int mid = n / 2;
                int[] left = new int[mid];
                int[] right = new int[n - mid];

                //Mergesort(left);
                //for (int i = 0; i < mid; i++)
                //{
                //    left[i] = arr[i];
                //    Console.WriteLine(left[i]);
                //}

                int x = 0;
                for (int i = mid; i < arr.Length; i++)
                {
                    right[x] = arr[i];
                    x++;
                    Console.WriteLine(right[x]);
                }
            }
        }

        static void Merge(int[] left, int[] right, int[] arr)
        {

        }
    }
}
