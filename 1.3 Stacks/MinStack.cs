using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class MinStack
    {
        // ------------------------------ Exercise ------------------------------
        // 2 - Design a stack that supports push, pop and retrieving the minimum value in constant time.
        //     For example, we populate our stack with [5, 2, 10, 1] (from left to right).
        //     stack.min() // 1
        //     stack.pop()
        //     stack.min() // 2

        private int[] items = new int[5];
        private int count;
        private int[] min = new int[5];
        private int minCount;

        public void Push(int item)
        {
            if (count == items.Length)
                throw new StackOverflowException();

            if (count == 0)
                min[0] = item;
            else
                if (item < min[minCount])
                min[++minCount] = item;

            items[count++] = item;
        } // Push method

        public int Pop()
        {
            if (count == items.Length)
                throw new InvalidOperationException();

            if (items[count - 1] == min[minCount])
                minCount--;

            return items[--count];
        } // Pop method

        public int Min()
        {
            return min[minCount];
        } // Min method

        public bool IsEmpty()
        {
            return count == 0;
        } // IsEmpty method

        public override string ToString()
        {
            var content = new int[count];
            Array.Copy(items, content, count);
            return $"[{string.Join(", ", content)}]";
        } // ToString method

    } // MinStack class

} // Stacks namespace
