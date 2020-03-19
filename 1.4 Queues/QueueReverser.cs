using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    class QueueReverser
    {
        // ------------------------------ Exercise ------------------------------
        // 1 - Given an integer K and a queue of integers, write code to reverse the
        //     order of the first K elements of the queue.
        //     Input: Q = [10, 20, 30, 40, 50], K = 3
        //     Output: Q = [30, 20, 10, 40, 50]

        public static void reverse(Queue<int> queue, int k)
        {
            if (k < 0 || k > queue.Count)
                throw new InvalidOperationException();

            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < k; i++)
                stack.Push(queue.Dequeue());
            while (stack.Count != 0)
                queue.Enqueue(stack.Pop());
            for (int i = 0; i < queue.Count - k; i++)
                queue.Enqueue(queue.Dequeue());
        }

    } // QueueReverse class

} // Queues namespace
