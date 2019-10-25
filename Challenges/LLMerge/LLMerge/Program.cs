using System;
using System.Collections.Generic;

namespace LLMerge
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList list1 = new LinkedList();
            list1.Append(1);
            list1.Append(2);
            list1.Append(3);
            list1.Append(4);
            list1.Append(5);

            LinkedList list2 = new LinkedList();
            list2.Append(11);
            list2.Append(12);
            list2.Append(13);
            list2.Append(14);
            list2.Append(15);
            list2.Append(16);
            list2.Append(17);
            list2.Append(18);
            list2.Append(19);
            list2.Append(20);

            MergeLists(list1, list2);
        }

        public static Node MergeLists(LinkedList list1, LinkedList list2)
        {
            while()
        }
    }
}
