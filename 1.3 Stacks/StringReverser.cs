using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class StringReverser
    {
        public string Reverse(string input)
        {
            if (input == null)
                throw new InvalidOperationException();

            var stack = new Stack<char>();

            foreach (char ch in input)
                stack.Push(ch);

            var reversed = new StringBuilder();
            while (stack.Count != 0)
                reversed.Append(stack.Pop());

            return reversed.ToString();
        }

    } // StringReverser class

} // Stacks namespace
