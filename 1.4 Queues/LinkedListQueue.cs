using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    class LinkedListQueue
    {
        // ------------------------------ Exercise ------------------------------
        // 2 - Build a queue using a linked list from scratch.
        //     Implement the following operations and calculate their runtime complexities.
        //      - enqueue
        //      - dequeue
        //      - peek
        //      - size
        //      - isEmpty

        private class Node
        {
            internal int value;
            internal Node next;

            public Node(int value)
            {
                this.value = value;
            }
        }

        private Node head;
        private Node tail;
        private int count;

        public void Enqueue(int item)
        {
            var node = new Node(item);

            if (head == null)
                head = tail = node;
            else
            {
                tail.next = node;
                tail = node;
            }
            count++;
        }

        public int Dequeue()
        {
            if (IsEmpty())
                throw new InvalidOperationException();

            int value;
            if (head == tail)
            {
                value = head.value;
                head = tail = null;
            }
            else
            {
                value = head.value;
                var second = head.next;
                head.next = null;
                head = second;
            }
            count--;
            return value;
        }

        public int Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException();

            return head.value;
        }    

        public int Size()
        {
            return count;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public override string ToString()
        {
            var list = new List<int>();

            Node current = head;
            while (current != null)
            {
                list.Add(current.value);
                current = current.next;
            }

            return $"[{string.Join(", ", list)}]";
        }

    } // LinkedListQueue class

} // Queues namespace
