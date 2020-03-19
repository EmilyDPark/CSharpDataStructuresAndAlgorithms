using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            // -------------------- Using Queues --------------------
            var queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            Console.WriteLine($"[{string.Join(", ", queue)}]");

            var front = queue.Dequeue();
            Console.WriteLine(front);


            // -------------------- Exercise: Reversing a Queue --------------------
            Reverse(queue);
            Console.WriteLine($"[{string.Join(", ", queue)}]");


            // -------------------- Exercise: Building a Queue using an Array --------------------
            ArrayQueue aQueue = new ArrayQueue(5);
            aQueue.Enqueue(10);
            aQueue.Enqueue(20);
            aQueue.Enqueue(30);
            Console.WriteLine(aQueue);

            aQueue.Dequeue();
            var aFront = aQueue.Dequeue();
            Console.WriteLine(front);
            Console.WriteLine(aQueue);

            aQueue.Enqueue(40);
            aQueue.Enqueue(50);
            aQueue.Enqueue(60);
            aQueue.Enqueue(70);
            aQueue.Dequeue();
            aQueue.Enqueue(80);
            Console.WriteLine(aQueue);

            Console.WriteLine(aQueue.Peek());
            Console.WriteLine(aQueue);


            // -------------------- Exercise: Building a Queue using Two Stacks --------------------
            QueueWithTwoStacks sQueue = new QueueWithTwoStacks();
            sQueue.Enqueue(10);
            sQueue.Enqueue(20);
            sQueue.Enqueue(30);
            var sFront = sQueue.Dequeue();
            Console.WriteLine(sFront);


            // -------------------- Exercise: Create a Priority Queue with an Array --------------------
            PriorityQueue prQueue = new PriorityQueue();
            prQueue.Add(5);
            prQueue.Add(3);
            prQueue.Add(6);
            prQueue.Add(1);
            prQueue.Add(4);
            Console.WriteLine(prQueue);

            while (!prQueue.IsEmpty())
                Console.WriteLine(prQueue.Remove());


            // -------------------- Exercise: Reverse K Elements of a Queue --------------------
            Queue<int> reQueue = new Queue<int>();
            reQueue.Enqueue(10);
            reQueue.Enqueue(20);
            reQueue.Enqueue(30);
            reQueue.Enqueue(40);
            reQueue.Enqueue(50);
            QueueReverser.reverse(reQueue, 3);
            Console.WriteLine($"[{string.Join(", ", reQueue)}]");


            // -------------------- Exercise: Build a Queue with a Linked List from Scratch --------------------
            LinkedListQueue lQueue = new LinkedListQueue();
            lQueue.Enqueue(10);
            lQueue.Enqueue(20);
            lQueue.Enqueue(30);
            lQueue.Enqueue(40);
            lQueue.Enqueue(50);
            Console.WriteLine(lQueue);
            lQueue.Dequeue();
            Console.WriteLine(lQueue.Dequeue());
            Console.WriteLine(lQueue.Peek());
            Console.WriteLine(lQueue);
            Console.WriteLine(lQueue.Size());


            // -------------------- Exercise: Build a Queue with a Linked List from Scratch --------------------
            StackWithTwoQueues qStack = new StackWithTwoQueues();
            qStack.push(10);
            qStack.push(20);
            qStack.push(30);
            qStack.push(40);
            qStack.push(50);
            Console.WriteLine(qStack);
            qStack.pop();
            Console.WriteLine(qStack.pop());
            Console.WriteLine(qStack.peek());
            Console.WriteLine(qStack);
            Console.WriteLine(qStack.size());


        } // Main method

        // -------------------- Exercise: Reversing a Queue --------------------
        public static void Reverse(Queue<int> queue)
        {
            var stack = new Stack<int>();
            while (queue.Count != 0)
                stack.Push(queue.Dequeue());
            while (stack.Count != 0)
                queue.Enqueue(stack.Pop());
        } // Reverse method

    } // Program class

} // Queues namespace
