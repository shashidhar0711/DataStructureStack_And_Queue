using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureStack_And_Queue
{
    public class Node
    {
        /// <summary>
        /// Integer type data
        /// Node type next
        /// </summary>
        public int data;
        public Node next;

        /// <summary>
        /// Initializes a new instance of the <see cref="Node"/> class.
        /// </summary>
        /// <param name="data">The data.</param>
        public Node(int data)
        {
            this.data = data;
        }
    }
}
