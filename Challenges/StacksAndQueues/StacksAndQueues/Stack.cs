using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    class Stack
    {
        private Node top;
        private int count;

        /// <summary>
        /// A constructor to initialize a stack with the top to be null and count to be zero.
        /// </summary>
        public Stack()
        {
            this.top = null;
            this.count = 0;
        }

        /// <summary>
        /// Get the value of stack count.
        /// </summary>
        public int Count
        {
            get
            {
                return this.count;
            }
        }
    }
}
