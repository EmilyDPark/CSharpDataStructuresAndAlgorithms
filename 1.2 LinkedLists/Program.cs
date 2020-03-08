using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new linked list
            var list = new LinkedList();

            // addFirst method
            list.AddFirst(20);
            list.AddFirst(10);
            list.PrintList();

            // addLast method
            list.AddLast(30);
            list.AddLast(40);
            list.AddLast(50);
            list.PrintList();

            // indexOf method
            Console.WriteLine(list.IndexOf(30));

            // contains method
            Console.WriteLine(list.Contains(40));

            // removeFirst method
            list.RemoveFirst();
            list.PrintList();

            // removeLast method
            list.RemoveLast();
            list.PrintList();

            // size method
            Console.WriteLine(list.Size());

            // toArray method;
            var array = list.ToArray();
            Console.WriteLine($"[{string.Join(", ", array)}]");

            // reverse method
            list.Reverse();
            list.PrintList();

            // getKthFromTheEnd method
            Console.WriteLine(list.GetKthFromTheEnd(1));


            // ---------------------------------------- Exercises ----------------------------------------

            // printMiddle method
            list.PrintMiddle();

            // hasLoop method
            var list2 = LinkedList.CreateWithLoop();
            Console.WriteLine(list2.HasLoop());

        }  // Main method

    } // LinkedList class

} // Program namespace
