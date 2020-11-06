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
            /// Creating reference of object node
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

        /// <summary>
        /// Peeks this instance.
        /// </summary>
        internal void peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("stack is empty");
                return;
            }

            Console.WriteLine("{0} is in the top of the stack", this.top.data);
        }

        /// <summary>
        /// Pops this instance.
        /// </summary>
        internal void pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("stack is empty");
                return;
            }

            Console.WriteLine("value poppedis {0}", this.top.data);
            this.top = this.top.next;
        }

        /// <summary>
        /// Determines whether this instance is empty.
        /// </summary>
        internal void IsEmpty()
        {
            while (this.top != null)
            {
                peek();
                pop();
            }
        }
    }
}
