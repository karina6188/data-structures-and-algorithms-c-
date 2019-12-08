using System;
using System.Collections.Generic;

namespace LeftJoinHashtables
{
    public class Program
    {
        static void Main(string[] args)
        {
            HashTable synonyms = new HashTable(10);
            Console.WriteLine("SYNONYMS TABLE");
            synonyms.AddNode("influence", "impact");
            synonyms.AddNode("perfume", "fragrance");
            synonyms.AddNode("cluster", "bundle");
            synonyms.AddNode("communication", "conversation");
            synonyms.AddNode("solve", "deal with");
            synonyms.AddNode("track", "path");
            synonyms.AddNode("infinite", "everlasting");
            synonyms.AddNode("migration", "movement");
            synonyms.AddNode("grateful", "thankful");
            synonyms.AddNode("lift", "raise");

            PrintTable(synonyms);

            HashTable antonyms = new HashTable(7);
            Console.WriteLine("ANTONYMS TABLE");
            antonyms.AddNode("influence", "cause");
            antonyms.AddNode("perfume", "odor");
            antonyms.AddNode("communication", "silence");
            antonyms.AddNode("solve", "neglect");
            antonyms.AddNode("infinite", "limited");
            antonyms.AddNode("capture", "release");
            antonyms.AddNode("adjust", "disarrange");

            PrintTable(antonyms);

            Console.WriteLine("JOINED TABLE");
            PrintTable(LeftJoin(synonyms, antonyms));
        }

        /// <summary>
        /// Takes in two data tables then creates a result table with the same numbers of table 1's buckets
        /// Loop through the table 1's buckets to add all the nodes key/values into the result table
        /// Then loop through the result table to find if table 2 has the keys that result table has.
        /// Using Contains method to check. If table 2 has keys that the result table has, Contains method returns the index position of the bucket where the key is found
        /// If the key that result table has but table 2 does not have, Contains method returns -1 to indicate that the key is not found in any index position of the buckets
        /// Then add "null" to the result table's value where the key is not found in table 2 
        /// If the key is found, go to the index position of the buckets and get the node's value then add it to the result's table where the keys are matched
        /// </summary>
        /// <param name="table1"></param>
        /// <param name="table2"></param>
        /// <returns>Result table with all the key/value pairs from table 1 and table 2 if table 2 has the same keys with table 1</returns>
        public static HashTable LeftJoin(HashTable table1, HashTable table2)
        {
            HashTable result = new HashTable(table1.Buckets);
            for (int i = 0; i < table1.Buckets; i++)
            {
                result.AddNode(table1.HashNode[i].Key, table1.HashNode[i].Value);
            }

            for (int i = 0; i < result.Buckets; i++)
            {
                int foundIndex = table2.Contains(table1.HashNode[i].Key);
                if (foundIndex != -1)
                {
                    string fromAntonyms = table2.HashNode[foundIndex].Value;
                    result.HashNode[i].Value += ", " + fromAntonyms;
                }
                else
                {
                    result.HashNode[i].Value += ", null";
                }
            }
            return result;
        }

        /// <summary>
        /// Takes in a hash table and console write how many data rows are in the table
        /// Loop through the buckets of the table to print out each row of key/value pair
        /// If the bucket is empty, console write "empty row" then exit the method
        /// If the bucket has a node, console write the node's key and value
        /// </summary>
        /// <param name="hashtable"></param>
        /// <returns></returns>
        public static bool PrintTable(HashTable hashtable)
        {
            Console.WriteLine($"There are {hashtable.Buckets} words in this table");
            Console.WriteLine("KEYS => VALUES");
            for (int i = 0; i < hashtable.Buckets; i++)
            {
                if (hashtable.HashNode[i] == null)
                {
                    Console.WriteLine("--- empty row ---");
                    Console.WriteLine();
                    return false;
                }
                Console.Write($"{hashtable.HashNode[i].Key} => ");
                Console.Write(hashtable.HashNode[i].Value);
                Console.WriteLine();
            }
            Console.WriteLine();
            return true;
        }
    }
}
