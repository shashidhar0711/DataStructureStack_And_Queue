using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureStack_And_Queue
{
    public class LinkedListQueue
    {
        /// <summary>
        /// Initially head is null 
        /// </summary>
        Node head = null;

        /// <summary>
        /// Ens the queue.
        /// </summary>
        /// <param name="data">The data.</param>
        internal void EnQueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} pushed in to Queue", node.data);
        }

        /// <summary>
        /// Displays this instance.
        /// </summary>
        internal void Display()
        {
            Node temp = this.head;
            if(temp == null)
            {
                Console.WriteLine("Queue is empty!");
                return;
            }
            while(temp != null)
            {
                Console.WriteLine(temp.data+" ");
                temp = temp.next;
            }
        }
    }
}
