using System;

namespace BinarySearch
{
    public class Program
    {
        static int Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };
            int key = 8;

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
        /// This method takes in an integer array and a key which is the value that we are looking for inside the array
        /// As we do binary search, we pick the middle element inside the array and compare it to the key value
        /// If the middle element is smaller than the key value, make the current middle index to be the new ending index and use the new ending index to find the new middle index
        /// If the middle element is larger than the key value, make the current middle index to be the new starting index and use the new starting index to find the new middle index
        /// Keep dividing the array to a half range until you find the key value or until when the starting index is equal to the middle index or the middle index is equal to the ending index
        /// When the starting index is equal to the middle index, that means the binary search has reached to the beginning of the array and still hasn't found the key value
        /// When the midding index is equal to the ending index, that means the binary search has reached to the end of the array and still hasn't found the key value
        /// When these conditions happen, break out from the while loop and returns -1 which means the key value is not found inside the array
        /// This logic does not work when the array length is less than 3 because in this case, the starting index, middle index, and the ending index can be the same
        /// Use a for loop to check if the key value exists in the array when the array length is less than 3 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static int Binary_Search(int[] array, int key)
        {
            int endIndex = array.Length - 1;
            int middleIndex = endIndex / 2;
            int startIndex = 0;
            while (middleIndex != endIndex && startIndex != middleIndex)
            {
                if (array[middleIndex] > key)
                {
                    endIndex = middleIndex;
                    middleIndex = endIndex / 2;
                }
                if (array[middleIndex] < key)
                {
                    startIndex = middleIndex;
                    middleIndex = (endIndex + startIndex + 1) / 2;
                }
                if (array[middleIndex] == key)
                {
                    return middleIndex;
                }
            }
            if (array.Length < 3)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == key) return i;
                }
            }
            return -1;
        }
    }
}
