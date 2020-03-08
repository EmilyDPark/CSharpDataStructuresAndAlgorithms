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

        public void addLast(int item)
        {
            var node = new Node(item);

            if (isEmpty())
                first = last = node;
            else
            {
                last.next = node;
                last = node;
            }

            count++;
        } // addLast method

        public void addFirst(int item)
        {
            var node = new Node(item);

            if (isEmpty())
                first = last = node;
            else
            {
                node.next = first;
                first = node;
            }

            count++;
        } // addFirst method

        private bool isEmpty()
        {
            return first == null;
        } // isEmpty method

        public int indexOf(int item)
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
        } // indexOf method

        public bool contains(int item)
        {
            return indexOf(item) != 1;
        } // contains method

        public void removeFirst()
        {
            if (isEmpty())
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
        } // removeFirst method

        public void removeLast()
        {
            if (isEmpty())
                throw new InvalidOperationException();

            if (first == last)
                first = last = null;
            else
            {
                var previous = getPrevious(last);
                last = previous;
                last.next = null;
            }

            count--;
        } // removeLast method

        private Node getPrevious(Node node)
        {
            var current = first;
            while (current != null)
            {
                if (current.next == node) return current;
                current = current.next;
            }
            return null;
        } // getPrevious method

        public int size()
        {
            return count;
        } // size method

        public int[] toArray()
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
        } // toArray method

        public void reverse()
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
        } // reverse method

        public int getKthFromTheEnd(int k)
        {
            if (isEmpty())
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
        } // getKthFromTheEnd method

        public void printList()
        {
            if (isEmpty()) return;

            var current = first;
            if (isEmpty())
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
        } // printList method


        // ---------------------------------------- Exercises ----------------------------------------

        // 1 - Find the middle of a linked list in one pass.
        //     If the list has an even number of nodes, there would be two middle nodes.
        //     (Note: Assume that you don’t know the size of the list ahead of time.)
        public void printMiddle()
        {
            if (isEmpty())
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

        } // printMiddle method

        // 2 - Check to se if a linked list has a loop
        public bool hasLoop()
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
        } // hasLoop method

        public static LinkedList createWithLoop()
        {
            var list = new LinkedList();
            list.addLast(10);
            list.addLast(20);
            list.addLast(30);

            // Get a reference to 30
            var node = list.last;

            list.addLast(40);
            list.addLast(50);

            // Create the loop
            list.last.next = node;

            return list;
        } // createWithLoop method

    } // LinkedList class

} // LinkedList namespace
