using System;

namespace FindRepeatedWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable(5);
            hashtable.Add("beeapple", "beeapple");
            hashtable.Add("beeeappl", "beeeappl");
            hashtable.Add("applebee", "applebee");
            //Console.WriteLine();
            Console.WriteLine(hashtable.Get("applebee"));
            Console.WriteLine(hashtable.Get("beeapple"));
            Console.WriteLine(hashtable.Get("beeeappl"));
            //Console.WriteLine();
            //Console.WriteLine(hashtable.Contains("beeapple"));
            //Console.WriteLine(hashtable.Contains("abeeapple"));
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
