using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureStack_And_Queue
{
    public class LinkedListStack
    {
        /// <summary>
        /// Variables
        /// </summary>
        private Node top;

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedListStack"/> class.
        /// </summary>
        public LinkedListStack()
        {
            this.top = null;
        }

        /// <summary>
        /// Pushes the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        internal void push(int value)
        {
            Node node = new Node(value);

            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }

            this.top = node;
            Console.WriteLine("{0} pushed value to stack ", value);
        }

        /// <summary>
        /// Displays this instance.
        /// </summary>
        internal void display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.WriteLine(temp.data + "");
                temp = temp.next;
            }
        }
    }
}
