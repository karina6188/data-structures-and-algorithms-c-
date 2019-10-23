using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists
{
    public class LinkedList
    {
        public Node Head { get; set; }

        public LinkedList()
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
                TestAppend(newNode);
                return TestAppend(newNode);
            }
        }

        public bool InsertBefore(int value, int newVal)
        {
            Node newNode = new Node(newVal);

            if (Head == null)
            {
                Head = newNode;
                return true;
            }
            else
            {
                Node previous = Head;
                Node current = Head.Next;
                while (current != null && current.Data != value)
                {
                    previous = current;
                }
                if (current.Data == value)
                {
                    previous.Next = newNode;
                    newNode.Next = current;
                }
                TestInsertBefore(value, previous, current, newNode);
                return TestInsertBefore(value, previous, current, newNode);
            }
        }

        public bool InsertAfter(int value, int newVal)
        {
            Node newNode = new Node(newVal);

            if (Head == null)
            {
                Head = newNode;
                return true;
            }
            else
            {
                Node current = Head;
                while (current != null && current.Data != value)
                {
                    current = current.Next;
                }
                if (current.Data == value)
                {
                    current.Next = newNode;
                    newNode.Next = current.Next;
                }
                TestInsertAfter(value, current, newNode);
                return TestInsertAfter(value, current, newNode);
            }
        }

        public bool TestAppend(Node newNode)
        {
            if (newNode.Next == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool TestInsertBefore(int value, Node previous, Node current, Node newNode)
        {
            if (current.Data == value)
            {
                if (previous.Next == newNode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool TestInsertAfter(int value, Node current, Node newNode)
        {
            if (current.Data == value)
            {
                if (current.Next == newNode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
