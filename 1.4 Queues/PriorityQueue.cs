using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    class PriorityQueue
    {
        private int[] items = new int[5];
        private int count;

        public void Add(int item)
        {
            if (IsFull())
                items = ResizeArray(items);

            var i = ShiftItemsToInsert(item);
            items[i] = item;
            count++;
        }

        public int ShiftItemsToInsert(int item)
        {
            int i;
            for (i = count - 1; i >= 0; i--)
            {
                if (items[i] > item)
                    items[i + 1] = items[i];
                else
                    break;
            }
            return i + 1;
        }

        private int[] ResizeArray(int[] items)
        {
            int[] newItems = new int[count * 2];
            for (int i = 0; i < count; i++)
                newItems[i] = items[i];
            return newItems;
        }

        public int Remove()
        {
            if (IsEmpty())
                throw new InvalidOperationException();

            return items[--count];
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public bool IsFull()
        {
            return items.Length == count;
        }

        public override string ToString()
        {
            return $"[{string.Join(", ", items)}]";
        }



    } // PriorityQueue class

} // Queues namespace
