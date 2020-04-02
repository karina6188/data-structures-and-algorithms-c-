using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryHashMap
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 3, -2, 5, 8 };
            int target = 6;
            int[] result = TwoSum(nums, target);
            Console.WriteLine($"{result[0]}, {result[1]}");
        }

        /// <summary>
        /// This method takes in an integer array and a target integer value
        /// Use a Dictionary as a hash map to find out the two numbers' index positions that sum up to be the target integer value
        /// The integer array should not contain any repetitive numbers, and only one answer possible
        /// First create an empty dictionary that takes in integer key and value data types
        /// Then use a for loop to loop through the numbers in the array while checking if the dictionary already contains the number's complement to the target sum
        /// If the dictionary does not have the number's complement, store the number as the key and the number's index position as the value into the dictionary
        /// Keep looping through each number in the array. Once a number's complement is found in the dictionary, return an integer array with the two number's index positions
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dictionary.ContainsKey(target - nums[i]))
                {
                    return new int[] {dictionary[target - nums[i]], i };
                }
                dictionary.TryAdd(nums[i], i); //TryAdd is different from Add. TryAdd does not throw an exception when the key already exist in the dictionary.
            }
            return null;
        }
    }
}
