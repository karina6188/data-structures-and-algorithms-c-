using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList_Extended
{
    public class LinkedList_Extended
    {
        public Node Head { get; set; }

        public LinkedList_Extended()
        {
            Head = null;
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
                return true;
            }
        }

        public int ReadValueFromEnd(int k)
        {
            Node current = Head;
            int listCounter = 0;
            while (current.Next != null)
            {
                current = current.Next;
                listCounter++;
            }
            int nodePosition = listCounter - k;

            Node current2 = Head;
            for (int i = 0; i < nodePosition; i++)
            {
                current2 = current2.Next;
            }
            Console.WriteLine(current2.Data);
            return current.Data;
        }
    }
}
