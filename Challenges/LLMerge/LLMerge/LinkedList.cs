using System;
using System.Collections.Generic;
using System.Text;

namespace LLMerge
{
    public class LinkedList
    {
        public Node Head { get; set; }

        public LinkedList()
        {
            Head = null;
        }

        public void MergeLists(LinkedList list1, LinkedList list2)
        {
            try
            {
                if (list1.Head != null && list2.Head != null)
                {
                    Console.WriteLine("1");
                    Node current1 = list1.Head;
                    Node current2 = list2.Head;
                    Node current = Head;
                    while (current1.Next != null && current2.Next != null)
                    {
                        Console.WriteLine("2");
                        current = current1;
                        current.Next = current2;
                        current1 = current1.Next;
                        current2 = current2.Next;
                        current = current.Next.Next;
                        Console.WriteLine($"THIS IS CURRENT: {current.Data}");
                    }
                    if (current1.Next != null)
                    {
                        Console.WriteLine("3");
                        while (current1.Next != null)
                        {
                            Console.WriteLine("4");
                            current = current1;
                            current1 = current1.Next;
                            current = current.Next;
                        }
                    }
                    if (current2.Next != null)
                    {
                        Console.WriteLine("5");
                        while (current2.Next != null)
                        {
                            Console.WriteLine("6");
                            current = current2;
                            current2 = current2.Next;
                            current = current.Next;
                        }
                    }
                }
                else if (list2.Head == null)
                {
                    Console.WriteLine("7");
                    Node current1 = Head;
                    while (current1.Next != null)
                    {
                        Console.WriteLine("8");
                        current1 = current1.Next;
                    }
                }
                else
                {
                    Console.WriteLine("9");
                    Node current2 = Head;
                    while (current2.Next != null)
                    {
                        Console.WriteLine("10");
                        current2 = current2.Next;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Both linked lists are empty.");
                Console.WriteLine(e.Message);
            }
        }

        public bool Append(int value)
        {
            Node newNode = new Node(value);

            if (Head == null)
            {
                Head = newNode;
                return true;
            }
            else
            {
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
                //TestAppend(newNode);
                //return TestAppend(newNode);
                return true;
            }
        }
    }
}
