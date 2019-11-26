using System;

namespace FindRepeatedWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable(5);
            int index = hashtable.Hash("dictionary");
            hashtable.Add("applebee", "applebee");
            hashtable.Add("applebee", "applebee");
            hashtable.Add("beeapple", "beeapple");
            Console.WriteLine();
            Console.WriteLine(hashtable.Get("beeapple"));
            Console.WriteLine(hashtable.Get("abeeapple"));
            Console.WriteLine(hashtable.Get("applebee"));
            Console.WriteLine();
            hashtable.Contains("beeapple");
            hashtable.Contains("abeeapple");
            Console.WriteLine();
            hashtable.Hash("elephant");
            hashtable.Hash("tiger");
        }

        static string RepeatedWord(string text)
        {
            string defaultText = "No repeated word is found";
            return defaultText;
        }
    }
}
