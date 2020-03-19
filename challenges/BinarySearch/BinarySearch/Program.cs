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
