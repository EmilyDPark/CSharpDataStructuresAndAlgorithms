using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Array
    {
        private int[] items;
        private int count;

        public Array(int length)
        {
            items = new int[length];
        }

        public void Insert(int item)
        {
            // If the array is full, resize it
            if (items.Length == count)
            {
                // Create a new array (twice the size)
                int[] newItems = new int[count * 2];

                // Copy all the existing items
                for (int i = 0; i < count; i++)
                    newItems[i] = items[i];

                // Set "items" to this new array
                items = newItems;
            }

            // Add the new item at the end
            items[count++] = item;
        } // Insert method

        public void RemoveAt(int index)
        {
            // Validate the index
            if (index < 0 || index >= count)
                throw new InvalidOperationException();

            // Shift the items to the left to fill the hole
            for (int i = index; i < count; i++)
                items[i] = items[i + 1];

            count--;
        } // RemoveAt method

        public int IndexOf(int item)
        {
            // If we find it, return index
            for (int i = 0; i < count; i++)
                if (items[i] == item)
                    return i;

            // Otherwise, return -1
            return -1;
        } // IndexOf method

        public void Print()
        {
            for (int i = 0; i < count; i++)
                Console.WriteLine(items[i]);
        } // Print method

        public void PrintArray()
        {
            if (count == 0)
            {
                Console.WriteLine("Array is empty.");
                return;
            }

            Console.Write("[");
            for (int i = 0; i < count - 1; i++)
                Console.Write(items[i] + ", ");
            Console.Write(items[count - 1] + "]");
            Console.WriteLine();
        } // PrintArray method


        // ---------------------------------------- Exercises ----------------------------------------

        // 1 - Extend the Array class and add a new method to return the largest number.
        public int Max()
        {
            int max = 0;
            for (int i = 1; i < count; i++)
                if (items[max] < items[i])
                    max = i;

            return max;
        } // Max method

        // 2 - Extend the Array class and add a method to return the common items in this array and another array.
        public Array Intersect(Array otherArr)
        {
            Array common = new Array(1);
            for (int i = 0; i < this.count - 1; i++)
            {
                for (int j = 0; j < otherArr.count; j++)
                {
                    if (items[i] == otherArr.items[j])
                    {
                        common.Insert(items[i]);
                    }
                }
            }
            return common;
        } // Intersect method

        public Array Intersect2(Array other)
        {
            Array intersection = new Array(count);

            foreach (int item in items)
                if (other.IndexOf(item) >= 0)
                    intersection.Insert(item);

            return intersection;
        } // Intersect2 method

        // 3 - Extend the Array class and add a method to reverse the array.
        //     For example, if the array includes [1, 2, 3, 4], after reversing and printing it, we should see [4, 3, 2, 1].
        public void Reverse()
        {
            var temp = 0;
            for (int i = 0; i < count / 2; i++)
            {
                temp = items[i];
                items[i] = items[count - 1 - i];
                items[count - 1 - i] = temp;
            }
        } // Reverse method

        // 4 - Extend the Array class and add a new method to insert an item at given index.
        public void InsertAt(int item, int index)
        {
            // Validate the index
            if (index < 0 || index > count)
                throw new InvalidOperationException();

            // If the array is full, resize it
            if (items.Length == count)
            {

                // Create a new array (twice the size)
                int[] newItems = new int[count * 2];

                // Copy all the existing items
                for (int i = 0; i < count; i++)
                    newItems[i] = items[i];

                // Set "items" to this new array
                items = newItems;
            }

            // Shift the items to the right to make a hole
            for (int i = count; i >= index; i--)
            {
                items[i + 1] = items[i];

                // Add item at index
                if (i == index)
                    items[i] = item;
            }

            count++;
        } // InsertAt method

    } // Array class

} // Arrays namespace
