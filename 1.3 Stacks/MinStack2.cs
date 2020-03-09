using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class MinStack2
    {
        // ------------------------------ Exercise ------------------------------
        // 2 - Design a stack that supports push, pop and retrieving the minimum value in constant time.
        //     For example, we populate our stack with [5, 2, 10, 1] (from left to right).
        //     stack.min() // 1
        //     stack.pop()
        //     stack.min() // 2

        private Stack stack = new Stack();
        private Stack minStack = new Stack();

        public void Push(int item)
        {
            stack.Push(item);

            if (minStack.IsEmpty())
                minStack.Push(item);
            else if (item < minStack.Peek())
                minStack.Push(item);
        } // Push method

        public int pop()
        {
            if (stack.IsEmpty())
                throw new InvalidOperationException();

            var top = stack.Pop();

            if (minStack.Peek() == top)
                minStack.Pop();

            return top;
        } // Pop method

        public int min()
        {
            return minStack.Peek();
        } // Min method
    
    } // MinStack2 class

} // Stacks namespace
