using System;

namespace HashTables
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HashTable hashtable = new HashTable(10);
            Console.WriteLine("Telephone area codes in the United States:");

            string[] states = { "Arkansas", "California", "Colorado", "Florida", "Georgia", "Hawaii", "Iowa", "Illinois", "Indiana", "Kentucky", "Massachusetts", "Michigan", "Minnesota", "North Carolina", "New Jersey", "New York", "Ohio", "Oklahoma", "Pennsylvania", "Texas", "Virginia", "Washington" };
            string[] areaCode = { "479", "510", "303", "727", "478", "808", "641", "309", "574", "270", "978", "616", "763", "828", "973", "585", "330", "405", "215", "432", "804", "425" };

            for (int i = 0; i < states.Length; i++)
            {
                hashtable.Add(states[i], areaCode[i]);
            }

            Console.WriteLine("\nFind area codes for these states:");
            string[] getStates = { "Utah", "Florida", "New Jersey", "South Dakota", "Montana", "Missouri", "Kentucky", "Colorado", "California", "Alabama" };
            for (int i = 0; i < getStates.Length; i++)
            {
                hashtable.Get(getStates[i]);
            }

            Console.WriteLine("\nDoes the hashtable contains the area codes for these states?");
            string[] containsStates = { "Delaware", "Iowa", "Illinois", "Maine", "North Carolina" };
            for (int i = 0; i < containsStates.Length; i++)
            {
                Console.WriteLine($"Hashtable contains key \"{containsStates[i]}\" ? {hashtable.Contains(containsStates[i])}");
            }

            Console.WriteLine("\nHash these states:");
            string[] hashStates = { "Kansas", "Maryland", "Tennessee", "Oregon", "Alaska" };
            for (int i = 0; i < hashStates.Length; i++)
            {
                Console.WriteLine($"Hash \"{hashStates[i]}\" into bucket: {hashtable.Hash(hashStates[i])}");
            }
        }
    }
}
