﻿using System;

namespace LinkedListImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list1 = new LinkedList();
            list1.Append(1);
            list1.Append(2);
            list1.Append(3);
            list1.Append(4);
            list1.Append(5);
            Console.WriteLine("Linked List: ");
            list1.PrintList();
            list1.Insert(10);
            Console.WriteLine("Insert to Head: ");
            list1.PrintList();
        }
    }
}
