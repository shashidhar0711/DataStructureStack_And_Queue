using System;

namespace DataStructureStack_And_Queue
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedListQueue linkedListQueue = new LinkedListQueue();

            /// Adding elements into Queue
            linkedListQueue.EnQueue(70);
            linkedListQueue.EnQueue(50);
            linkedListQueue.EnQueue(36);

            /// Printing all the elements
            linkedListQueue.Display();

            Console.WriteLine("---------------------------");
            /// Deleting the element in the queue
            linkedListQueue.DeQueue();

            /// Printing all the elements Excecpt delted one
            linkedListQueue.Display();

            /// It is deleting upto empty from begining
            linkedListQueue.IsEmpty();
            linkedListQueue.Display();

        }
    }
}
