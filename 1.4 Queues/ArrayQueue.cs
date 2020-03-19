using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    class ArrayQueue
    {
        private int[] items;
        private int rear;
        private int front;
        private int count;

        public ArrayQueue(int capacity)
        {
            items = new int[capacity];
        }

        public void Enqueue(int item)
        {
            if (isFull())
                throw new InvalidOperationException();

            items[rear] = item;
            rear = (rear + 1) % items.Length;
            count++;
        }

        public int Dequeue()
        {
            if (isEmpty())
                throw new InvalidOperationException();

            var item = items[front];
            items[front] = 0;
            front = (front + 1) % items.Length;
            count--;
            return item;
        }

        public int Peek()
        {
            if (isEmpty())
                throw new InvalidOperationException();

            return items[front];
        }

        public bool isEmpty()
        {
            return count == 0;
        }

        public bool isFull()
        {
            return count == items.Length;
        }

        public override string ToString()
        {
            return $"[{string.Join(", ", items)}]";
        }

    } // ArrayQueue class

} // Queue namespace
