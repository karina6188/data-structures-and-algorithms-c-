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
