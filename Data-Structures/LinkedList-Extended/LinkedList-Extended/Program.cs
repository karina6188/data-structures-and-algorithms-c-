using System;
using System.Collections.Generic;

namespace LinkedList_Extended
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList_Extend linklist = new LinkedList_Extend();
            linklist.Append(1);
            linklist.Append(2);
            linklist.Append(3);
            linklist.Append(4);
            linklist.Append(5);
            linklist.Append(6);
            linklist.ReadValueFromEnd(2);
        }
    }
}
