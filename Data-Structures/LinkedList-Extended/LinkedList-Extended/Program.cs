using System;
using System.Collections.Generic;

namespace LinkedList_Extended
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList_Extended linklist = new LinkedList_Extended();
            linklist.Append(1);
            linklist.Append(2);
            linklist.Append(3);
            linklist.Append(4);
            linklist.Append(5);
            linklist.Append(6);
            linklist.ReadValueFromEnd(3);
        }
    }
}
