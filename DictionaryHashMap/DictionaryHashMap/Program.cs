using System;
using System.Collections.Generic;

namespace DictionaryHashMap
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 3, -2, 5, 8 };
            int target = 6;
            TwoSum(nums, target);
        }

        static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int> { };
            for (int i = 0; i < nums.Length; i++)
            {
                dictionary.Add(i, nums[i]);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (hashTable.ContainsKey[])
            }

        }
    }
}
