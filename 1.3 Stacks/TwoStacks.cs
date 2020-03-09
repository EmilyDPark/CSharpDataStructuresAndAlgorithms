using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class TwoStacks
    {
        // ------------------------------ Exercise ------------------------------
        // 1 - Implement two stacks in one array. Support these operations:
        //     push1() // to push in the first stack
        //     push2() // to push in the second stack
        //     pop1()
        //     pop2()
        //     isEmpty1()
        //     isEmpty2()
        //     isFull1()
        //     isFull2()
        //     Make sure your implementation is space efficient.
        //     (hint: do not allocate the same amount of space by dividing the array in half.)

        private int[] items;
        private int top1;
        private int top2;

        public TwoStacks(int capacity)
        {
            if (capacity <= 0)
                throw new InvalidOperationException();

            items = new int[capacity];
            top1 = -1;
            top2 = capacity;
        } // TwoStacks constructor

        public void Push1(int item)
        {
            if (IsFull1())
                throw new StackOverflowException();

            items[++top1] = item;
        } // Push1 method

        public void Push2(int item)
        {
            if (IsFull2())
                throw new StackOverflowException();

            items[--top2] = item;
        } // Push2 method

        public int Pop1()
        {
            if (IsEmpty1())
                throw new InvalidOperationException();

            return items[top1--];
        } // Pop1 method

        public int Pop2()
        {
            if (IsEmpty2())
                throw new InvalidOperationException();

            return items[top2++];
        } // Pop2 method

        public bool IsEmpty1()
        {
            return top1 == -1;
        } // IsEmpty1 method

        public bool IsEmpty2()
        {
            return top2 == items.Length;
        } // IsEmpty2 method

        public bool IsFull1()
        {
            return top1 + 1 == top2;
        } // IsFull1 method

        public bool IsFull2()
        {
            return top2 - 1 == top1;
        } // IsFull2 method

        public void PrintStack1()
        {
            var content = new int[top1 + 1];
            Array.Copy(items, content, top1 + 1);
            Console.WriteLine($"[{string.Join(", ", content)}]");
        } // PrintStack1 method

        public void PrintStack2()
        {
            var content = new int[items.Length - top2];
            for (int i = 0, j = items.Length - 1; j >= top2; i++, j--)
                content[i] = items[j];
            Console.WriteLine($"[{string.Join(", ", content)}]");
        } // PrintStack2 method

        public override string ToString()
        {
            var content = new int[items.Length];
            Array.Copy(items, content, items.Length);
            return $"[{string.Join(", ", content)}]";
        } // ToString method

    } // TwoStack class

} // Stacks namespace
