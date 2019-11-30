using System;
using System.Collections;

namespace FindRepeatedWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable(1);
            hashtable.Add("applebee", "applebee");
            hashtable.Add("beeapple", "beeapple");
            hashtable.Add("eeeapplb", "eeeapplb");
            hashtable.Add("peeaplbe", "leeappbe");
            hashtable.Add("ppleeabe", "ppleeabe");
            Console.WriteLine();
            Console.WriteLine(hashtable.Get("applebee"));
            Console.WriteLine(hashtable.Get("beeapple"));
            Console.WriteLine(hashtable.Get("eeeapplb"));
            Console.WriteLine(hashtable.Get("leeappbe"));
            Console.WriteLine(hashtable.Get("ppleeabe"));

            //Console.WriteLine();
            //Console.WriteLine(hashtable.Contains("applebee"));
            //Console.WriteLine(hashtable.Contains("beeapple"));
            //Console.WriteLine(hashtable.Contains("eeeapplb"));
            //Console.WriteLine(hashtable.Contains("ppleeabe"));
            //Console.WriteLine();
            //Console.WriteLine(hashtable.Hash("elephant"));
            //Console.WriteLine(hashtable.Hash("tiger"));
        }

        static string RepeatedWord(string text)
        {
            string defaultText = "No repeated word is found";
            return defaultText;
        }
    }
}
