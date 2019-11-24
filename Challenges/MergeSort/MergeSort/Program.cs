﻿using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 8, 4, 23, 42, 16, 15 };
            Mergesort(array);

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
                    Console.WriteLine(left[i]);
                }

                int x = 0;
                for (int i = mid; i < arr.Length; i++)
                {
                    right[x] = arr[i];
                    Console.WriteLine(right[x]);
                    x++;
                }

                Mergesort(left);

                Mergesort(right);

                Merge(left, right, arr);
            }
            return arr;
        }

        static void Merge(int[] left, int[] right, int[] arr)
        {
            int i = 0;
            int j = 0;
            int k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[i])
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
            
        }
    }
}
