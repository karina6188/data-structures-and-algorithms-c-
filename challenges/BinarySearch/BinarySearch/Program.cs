using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 15, 32, 37, 41, 58 };
            int key = 85;
            //int key = 50;
            Console.WriteLine("running");

            int Output = BinarySearch(array, key);
            Console.WriteLine(Output);
        }

        public static int BinarySearch(int[] array, int key)
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
