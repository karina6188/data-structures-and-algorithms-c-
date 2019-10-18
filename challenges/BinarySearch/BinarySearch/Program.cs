using System;

namespace BinarySearch
{
    public class Program
    {
        static int Main(string[] args)
        {
            int[] array = new int[] { 15, 32, 37, 41, 58 };
            int key = 41;

            if (array.Length < 1)
            {
                int defaultIndex = -1;
                Console.WriteLine(defaultIndex);
                return defaultIndex;
            }
            else
            {
                int Output = Binary_Search(array, key);
                Console.WriteLine(Output);
                return Output;
            }
        }

        public static int Binary_Search(int[] array, int key)
        {
            int start = 0;
            int end = array.Length - 1;
            int index = -1;
            int lastItem = array[array.Length - 1];
            int midAtEnd = array.Length - 2;
            int length = array.Length - 1;

            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (array[mid] > key)
                {
                    end = mid;
                }
                else if (array[mid] == key)
                {
                    index = mid;
                    break;
                }
                else
                {
                    start = mid;
                }
                if (start == midAtEnd)
                {
                    break;
                }
                if (array[0] > key)
                {
                    break;
                }
                if (lastItem < key)
                {
                    break;
                }
            }

            if (array[0] == key)
            {
                return 0;
            }

            if (lastItem == key)
            {
                return length;
            }
            return index;
        }
    }
}
