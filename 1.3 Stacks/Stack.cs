using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class Stack
    {
        private int[] items = new int[5];
        private int count;

        public void Push(int item)
        {
            if (count == items.Length)
                throw new InvalidOperationException();

            items[count++] = item;
        } // Push method

        public int Pop()
        {
            if (count == items.Length)
                throw new InvalidOperationException();

            return items[--count];
        } // Pop method

        public int Peek()
        {
            if (count == 0)
                throw new InvalidOperationException();

            return items[count - 1];
        } // Peek method

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




    } // Stack class

} // Stacks namespace
