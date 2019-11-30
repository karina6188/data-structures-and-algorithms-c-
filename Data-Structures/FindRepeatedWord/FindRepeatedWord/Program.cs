using System;
using System.Collections;

namespace FindRepeatedWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "Classical music is art music produced or rooted in the traditions of Western culture, including both liturgical (religious) and secular music.";
            string string2 = "I have always remembered that Christmas fondly. It had such an impact on me. As an adult with children in my life whom I adore, I can now understand my mom’s actions.";
            string string3 = "Welsh Corgis have historically been used as herding dogs, specifically for cattle. They are of the type of herding dog referred to as \"heelers\", meaning that they would nip at the heels of the larger animals to keep them on the move.";

            Console.WriteLine($"String 1:");
            Console.WriteLine($"\"{string1}\"\n");
            Console.WriteLine($"The first repeated word is: {RepeatedWord(string1)}\n==========================================");
            Console.WriteLine($"String 2:");
            Console.WriteLine($"\"{string2}\"\n");
            Console.WriteLine($"The first repeated word is: {RepeatedWord(string2)}\n==========================================");
            Console.WriteLine($"String 3:");
            Console.WriteLine($"\"{string3}\"\n");
            Console.WriteLine($"The first repeated word is: {RepeatedWord(string3)}\n==========================================");
        }

        static string RepeatedWord(string text)
        {
            string defaultText = "No repeated word is found";
            char[] separator = { ',', '.', ';', ':', '\'', '(', ')', ' ' };
            string[] splitString = text.ToLower().Split(separator);
            Hashtable hashtable = new Hashtable(10);
            for (int i = 0; i < splitString.Length; i++)
            {
                if (splitString[i].Length > 0)
                {
                    if (hashtable.Contains(splitString[i]))
                    {
                        hashtable.Add(splitString[i], splitString[i]);
                        return splitString[i];
                    }
                    hashtable.Add(splitString[i], splitString[i]);
                }
            }
            Console.WriteLine(defaultText);
            return defaultText;
        }
    }
}
