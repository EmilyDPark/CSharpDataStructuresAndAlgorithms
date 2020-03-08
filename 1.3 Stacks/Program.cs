using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            // --------------------Using Stacks--------------------
            //var stack = new Stack<int>();
            //stack.Push(10);
            //stack.Push(20);
            //stack.Push(30);
            //Console.WriteLine($"[{ string.Join(", ", stack)}]");
            //var top = stack.Pop();
            //Console.WriteLine(top);
            //Console.WriteLine($"[{ string.Join(", ", stack)}]");
            //top = stack.Peek();
            //Console.WriteLine(top);


            // -------------------- Exercise: Reversing a String --------------------
            String str = "abcd";

            StringReverser reverser = new StringReverser();
            var result = reverser.Reverse(str);

            Console.WriteLine(result);


            // -------------------- Exercise: Balanced Expressions --------------------
            String str2 = "(([1] + <2>)){a}";

            Expression exp = new Expression();
            exp.IsBalanced(str2);
            var result2 = exp.IsBalanced(str2);
            Console.WriteLine(result2);


            // -------------------- Exercise: Building a Stack Using an Array --------------------
            Stack stack2 = new Stack();
            stack2.Push(10);
            stack2.Push(20);
            stack2.Push(30);
            stack2.Pop();
            Console.WriteLine(stack2);
            Console.WriteLine(stack2.Peek());


        } // Main method

    } // Program class

} // Stacks namespace
