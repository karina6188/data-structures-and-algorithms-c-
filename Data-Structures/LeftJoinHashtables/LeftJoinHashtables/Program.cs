using System;
using System.Collections.Generic;

namespace LeftJoinHashtables
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTable synonyms = new HashTable(10);
            synonyms.AddNode("influence", "impact");
            synonyms.AddNode("perfume", "fragrance");
            synonyms.AddNode("cluster", "bundle");
            synonyms.AddNode("communication", "conversation");
            synonyms.AddNode("solve", "deal with");
            synonyms.AddNode("track", "path");
            synonyms.AddNode("infinite", "everlasting");
            synonyms.AddNode("migration", "movement");
            synonyms.AddNode("grateful", "thankful");
            synonyms.AddNode("5", "five");

            HashTable antonyms = new HashTable(8);
            antonyms.AddNode("capture", "release");
            antonyms.AddNode("communication", "silence");
            antonyms.AddNode("solve", "neglect");
            antonyms.AddNode("infinite", "limited");
            antonyms.AddNode("influence", "cause");
            antonyms.AddNode("adjust", "disarrange");
            antonyms.AddNode("perfume", "odor");
        }

        static HashTable LeftJoin(HashTable table1, HashTable table2)
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
                    result.HashNode[i].Value += fromAntonyms;
                }
                else
                {
                    result.HashNode[i].Value += "null";
                }
            }
            return result;
        }
    }
}
