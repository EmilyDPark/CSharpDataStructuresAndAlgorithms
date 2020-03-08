using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedList
    {
        private class Node
        {
            internal int value;
            internal Node next;

            public Node(int value)
            {
                this.value = value;
            }

        } // Node class

        private Node first;
        private Node last;
        private int count;

        public void AddLast(int item)
        {
            var node = new Node(item);

            if (IsEmpty())
                first = last = node;
            else
            {
                last.next = node;
                last = node;
            }

            count++;
        } // AddLast method

        public void AddFirst(int item)
        {
            var node = new Node(item);

            if (IsEmpty())
                first = last = node;
            else
            {
                node.next = first;
                first = node;
            }

            count++;
        } // AddFirst method

        private bool IsEmpty()
        {
            return first == null;
        } // IsEmpty method

        public int IndexOf(int item)
        {
            int index = 0;
            var current = first;
            while (current != null)
            {
                if (current.value == item) return index;
                current = current.next;
                index++;
            }
            return -1;
        } // IndexOf method

        public bool Contains(int item)
        {
            return IndexOf(item) != 1;
        } // Contains method

        public void RemoveFirst()
        {
            if (IsEmpty())
                throw new InvalidOperationException();

            if (first == last)
                first = last = null;
            else
            {
                var second = first.next;
                first.next = null;
                first = second;
            }

            count--;
        } // RemoveFirst method

        public void RemoveLast()
        {
            if (IsEmpty())
                throw new InvalidOperationException();

            if (first == last)
                first = last = null;
            else
            {
                var previous = GetPrevious(last);
                last = previous;
                last.next = null;
            }

            count--;
        } // RemoveLast method

        private Node GetPrevious(Node node)
        {
            var current = first;
            while (current != null)
            {
                if (current.next == node) return current;
                current = current.next;
            }
            return null;
        } // GetPrevious method

        public int Size()
        {
            return count;
        } // Size method

        public int[] ToArray()
        {
            int[] array = new int[count];
            var current = first;
            var index = 0;
            while (current != null)
            {
                array[index++] = current.value;
                current = current.next;
            }

            return array;
        } // ToArray method

        public void Reverse()
        {
            var previous = first;
            var current = first.next;
            while (current != null)
            {
                var next = current.next;
                current.next = previous;
                previous = current;
                current = next;
            }

            last = first;
            last.next = null;
            first = previous;
        } // Reverse method

        public int GetKthFromTheEnd(int k)
        {
            if (IsEmpty())
                throw new InvalidOperationException();

            var a = first;
            var b = first;
            for (int i = 0; i < k - 1; i++)
            {
                b = b.next;
                if (b == null)
                    throw new InvalidOperationException();
            }
            while (b != last)
            {
                a = a.next;
                b = b.next;
            }
            return a.value;
        } // GetKthFromTheEnd method

        public void PrintList()
        {
            if (IsEmpty()) return;

            var current = first;
            if (IsEmpty())
            {
                Console.WriteLine("List is empty.");
                return;
            }
            Console.Write("{");
            while (current != null && current.next != null)
            {
                Console.Write(current.value + ", ");
                current = current.next;
            }
            if (current != null && current.next == null)
            {
                Console.Write(current.value);
            }
            Console.Write("}");
            Console.WriteLine();
        } // PrintList method


        // ---------------------------------------- Exercises ----------------------------------------

        // 1 - Find the middle of a linked list in one pass.
        //     If the list has an even number of nodes, there would be two middle nodes.
        //     (Note: Assume that you don’t know the size of the list ahead of time.)
        public void PrintMiddle()
        {
            if (IsEmpty())
                throw new InvalidOperationException();

            var a = first;
            var b = first;
            while (b != last && b.next != last)
            {
                a = a.next;
                b = b.next.next;
            }

            if (b == last)
                Console.WriteLine(a.value);
            else
                Console.WriteLine(a.value + ", " + a.next.value);

        } // PrintMiddle method

        // 2 - Check to see if a linked list has a loop
        public bool HasLoop()
        {
            var slow = first;
            var fast = first;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast)
                    return true;
            }
            return false;
        } // HasLoop method

        public static LinkedList CreateWithLoop()
        {
            var list = new LinkedList();
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);

            // Get a reference to 30
            var node = list.last;

            list.AddLast(40);
            list.AddLast(50);

            // Create the loop
            list.last.next = node;

            return list;
        } // CreateWithLoop method

    } // LinkedList class

} // LinkedList namespace
