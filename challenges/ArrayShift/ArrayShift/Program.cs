using System;

namespace ArrayShift
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 3, 5, 6, 7, 8 };
            int value = 12;

            insertShiftArray(array, value);
            Console.WriteLine(string.Join(",", insertShiftArray(array, value)));
        }
        public static int[] insertShiftArray(int[] array, int value)
        {
            int index;
            if (array.Length % 2 == 0)
            {
                index = array.Length / 2;
            }
            else
            {
                index = (array.Length + 1) / 2;
            }

            int[] newArray = new int[array.Length + 1];
            for(int i = 0; i < array.Length+1; i++)
            {
                if (i < index)
                {
                    newArray[i] = array[i];
                }
                else if (i == index)
                {
                    newArray[index] = value;
                }
                else
                {
                    newArray[i] = array[i - 1];
                }
            }
            return newArray;
        }
    }
}
