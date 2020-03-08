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
            list.addFirst(20);
            list.addFirst(10);
            list.printList();

            // addLast method
            list.addLast(30);
            list.addLast(40);
            list.addLast(50);
            list.printList();

            // indexOf method
            Console.WriteLine(list.indexOf(30));

            // contains method
            Console.WriteLine(list.contains(40));

            // removeFirst method
            list.removeFirst();
            list.printList();

            // removeLast method
            list.removeLast();
            list.printList();

            // size method
            Console.WriteLine(list.size());

            // toArray method;
            var array = list.toArray();
            Console.WriteLine($"[{string.Join(", ", array)}]");

            // reverse method
            list.reverse();
            list.printList();

            // getKthFromTheEnd method
            Console.WriteLine(list.getKthFromTheEnd(1));


            // ---------------------------------------- Exercises ----------------------------------------

            // printMiddle method
            list.printMiddle();

            // hasLoop method
            var list2 = LinkedList.createWithLoop();
            Console.WriteLine(list2.hasLoop());

        }  // Main method

    } // LinkedList class

} // Program namespace
