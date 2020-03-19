using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    class StackWithTwoQueues
    {
        // ------------------------------ Exercise ------------------------------
        // 2 - Build a stack using two queues.
        //     Implement the following operations and calculate their runtime complexities.
        //      - push
        //      - pop
        //      - peek
        //      - size
        //      - isEmpty

        private Queue<int> queue1 = new Queue<int>();
        private Queue<int> queue2 = new Queue<int>();
        private int top;

        public void push(int item)
        {
            queue1.Enqueue(item);
            top = item;
        }

        public int pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException();

            while (queue1.Count > 1)
            {
                top = queue1.Dequeue();
                queue2.Enqueue(top);
            }

            SwapQueues();
            return queue2.Dequeue();
        }

        public int peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException();

            return top;
        }

        public int size()
        {
            return queue1.Count;
        }

        public void SwapQueues()
        {
            (queue1, queue2) = (queue2, queue1);
        }

        public bool IsEmpty()
        {
            return queue1.Count == 0;
        }

        public override string ToString()
        {
            return $"[{string.Join(", ", queue1)}]";
        }

    } // StackWithTwoQueues class

} // Queues namespace
