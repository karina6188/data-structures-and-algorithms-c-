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

        /// <summary>
        /// This method takes in two arguments. One sorted integer array and one integer number.
        /// The method is to keep dividing the integer array into two portions and look for the search key.
        /// The array will be divided until all the integers in the array have been divided into a sub array that has only one integer.
        /// Have various variable integers to track the start point, end point, the index number of the array, the mid point of the array, and the length of the array (sub-array).
        /// While the start point of the array is less than or equal to the end point of the array, keep dividing the array into smaller sub-array.
        /// While doing this, check if the search key is greater or less than the first or the last number of the array. This is to check if the search key is outside of the array numbers range.
        /// When all the numbers in the array have been checked and excluded, and when the binary search reaches to the head or the end of the array, break out from the while loop.
        /// Finally, check the first or the last number of the array to see if it is equal to the search key. If yes, the search key is found. If not, the search key does not exist in the array.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="key"></param>
        /// <returns></returns>
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
