using System;

namespace ArrayShift
{
    public class Program
    {
        /// <summary>
        /// Define the array and value then call the insertShiftArray method.
        /// Print the returned new array into the console window.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] array = new int[] { 3, 5, 6, 7, 8 };
            int value = 12;

            insertShiftArray(array, value);
            Console.WriteLine(string.Join(",", insertShiftArray(array, value)));
        }

        /// <summary>
        /// The methhod checks if the array has odd or even elements inside.
        /// If the array has odd elements, find the middle element and add the value after the element.
        /// If the array has even elements, add the value to be in the middle index position inside the array.
        /// Create a new array and add old values from the old array and the new value to the new array.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="value"></param>
        /// <returns>The new array with the added value is returned.</returns>
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
