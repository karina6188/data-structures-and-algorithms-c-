using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListImplementation
{
    public class LinkedList
    {
        public Node Head { get; set; }

        public LinkedList()
        {
            Head = null;
        }

        public void Insert(int value)
        {
            Node newNode = new Node(value);

            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node current = Head;
                Head = newNode;
                Head.Next = current;
                while (current.Next != null)
                {
                    current = current.Next;
                }
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

        public int PrintList()
        {
            Node current = Head;
            int numberOfNodes = 1;
            while (current.Next != null)
            {
                Console.Write(current.Data + " --> ");
                current = current.Next;
                numberOfNodes++;
            }
            Console.WriteLine(current.Data);
            return numberOfNodes;
        }
    }
}
