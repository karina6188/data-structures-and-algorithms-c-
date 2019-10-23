using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkedList
    {
        public Node Head { get; set; }

        public LinkedList()
        {
            Head = null;
        }

        public void Append(int value)
        {
            Node newNode = new Node(value);

            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node current = Head;
                while(current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public void InsertBefore(int value, int newVal)
        {

        }

        public void InsertAfter(int value, int newVal)
        {
            Node newNode = new Node(newVal);

            if(Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node current = Head;
                while(current != null && current.Data != value)
                {
                    current = current.Next;
                }
                if (current.Data == value)
                {
                    current.Next = newNode;
                    newNode.Next = current.Next;
                }
            }
        }
    }
}
