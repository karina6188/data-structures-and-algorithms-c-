using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    public class Queue
    {
        public Node front;
        public int count;

        /// <summary>
        /// A constructor to initialize a queue with the front property set to be null and count to be zero.
        /// </summary>
        public Queue()
        {
            this.front = null;
            this.count = 0;
        }

        /// <summary>
        /// Get the value of queue count.
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
