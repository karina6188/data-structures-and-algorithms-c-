using System;
using System.Collections.Generic;

namespace LinkedLists
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList linklist = new LinkedList();
            linklist.Append(1);
            linklist.Append(2);
            linklist.Append(3);
            linklist.Append(4);
            linklist.Append(5);
            linklist.Append(6);
            linklist.InsertBefore(5, 10);
        }
    }
}
