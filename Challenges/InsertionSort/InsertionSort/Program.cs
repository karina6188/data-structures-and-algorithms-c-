using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void InsertSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int j = i - 1;
                int temp = arr[i];

                while (j >= 0 && temp < arr[j])
                {
                    arr[j + 1] = arr[j];

                }
            }
        }
    }
}
