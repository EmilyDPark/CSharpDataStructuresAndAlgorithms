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
            Console.WriteLine("Exercise: Reversing a String");
            String str = "abcd";
            StringReverser reverser = new StringReverser();
            var result = reverser.Reverse(str);
            Console.WriteLine(result);


            // -------------------- Exercise: Balanced Expressions --------------------
            Console.WriteLine("\nExercise: Balanced Expressions");
            String str2 = "(([1] + <2>)){a}";
            Expression exp = new Expression();
            exp.IsBalanced(str2);
            var result2 = exp.IsBalanced(str2);
            Console.WriteLine(result2);


            // -------------------- Exercise: Building a Stack Using an Array --------------------
            Console.WriteLine("\nExercise: Building a Stack Using an Array");
            Stack stack2 = new Stack();
            stack2.Push(10);
            stack2.Push(20);
            stack2.Push(30);
            stack2.Pop();
            Console.WriteLine(stack2);
            Console.WriteLine(stack2.Peek());


            // -------------------- Exercise: Two Stacks in One Array --------------------
            Console.WriteLine("\nExercise: Two Stacks in One Array");
            TwoStacks twoStacks = new TwoStacks(6);
            twoStacks.Push1(11);
            twoStacks.Push1(22);
            twoStacks.Push1(33);
            twoStacks.Push2(44);
            twoStacks.Push2(55);
            twoStacks.Push2(66);
            Console.WriteLine(twoStacks);
            twoStacks.PrintStack1();
            twoStacks.PrintStack2();
            twoStacks.Pop1();
            twoStacks.Pop2();
            twoStacks.PrintStack1();
            twoStacks.PrintStack2();


            // -------------------- Exercise: Minimum Value in a Stack --------------------
            Console.WriteLine("\nExercise: Minimum Value in a Stack");
            MinStack minStack = new MinStack();
            minStack.Push(14);
            minStack.Push(5);
            minStack.Push(7);
            minStack.Push(3);
            Console.WriteLine(minStack);
            Console.WriteLine(minStack.Min());
            minStack.Pop();
            Console.WriteLine(minStack.Min());

        } // Main method

    } // Program class

} // Stacks namespace
