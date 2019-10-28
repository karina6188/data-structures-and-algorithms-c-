using System;
using System.Collections.Generic;
using System.Text;

namespace LLMerge
{
    public class LinkedList
    {
        public Node Head;
        //public Node Head { get; set; }

        //public LinkedList()
        //{
        //    Head = null;
        //}

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

        public void PrintList()
        {
            Node current = Head;
            while(current.Next != null)
            {
                Console.Write(current.Data + " --> ");
                current = current.Next;
            }
            Console.WriteLine(current.Data);
        }
    }

    public class EmptyClass
    {
        public Node MergeLists(Node node1, Node node2)
        {
            Node tempNode = new Node(0);
            Node tail = tempNode;
            while (true)
            {
                if (node1 != null)
                {
                    tail.Next = node1;
                    node1 = node1.Next;
                    tail = tail.Next;
                }
                if (node2 != null)
                {
                    tail.Next = node2;
                    node2 = node2.Next;
                    tail = tail.Next;
                }
                if (node1 == null && node2 == null)
                {
                    break;
                }
            }
            return tempNode.Next;
        }
    }
}
