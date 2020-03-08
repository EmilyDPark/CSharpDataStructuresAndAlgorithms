﻿using System;
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

        public void insert(int item)
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
        } // insert method

        public void removeAt(int index)
        {
            // Validate the index
            if (index < 0 || index >= count)
                throw new InvalidOperationException();

            // Shift the items to the left to fill the hole
            for (int i = index; i < count; i++)
                items[i] = items[i + 1];

            count--;
        } // removeAt method

        public int indexOf(int item)
        {
            // If we find it, return index
            for (int i = 0; i < count; i++)
                if (items[i] == item)
                    return i;

            // Otherwise, return -1
            return -1;
        } // indexOf method

        public void print()
        {
            for (int i = 0; i < count; i++)
                Console.WriteLine(items[i]);
        } // print method

        public void printArray()
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
        } // printArray method


        // ---------------------------------------- Exercises ----------------------------------------

        // 1 - Extend the Array class and add a new method to return the largest number.
        public int max()
        {
            int max = 0;
            for (int i = 1; i < count; i++)
                if (items[max] < items[i])
                    max = i;

            return max;
        } // max method

        // 2 - Extend the Array class and add a method to return the common items in this array and another array.
        public Array intersect(Array otherArr)
        {
            Array common = new Array(1);
            for (int i = 0; i < this.count - 1; i++)
            {
                for (int j = 0; j < otherArr.count; j++)
                {
                    if (items[i] == otherArr.items[j])
                    {
                        common.insert(items[i]);
                    }
                }
            }
            return common;
        } // intersect method

        // 3 - Extend the Array class and add a method to reverse the array.
        //     For example, if the array includes [1, 2, 3, 4], after reversing and printing it, we should see [4, 3, 2, 1].
        public void reverse()
        {
            var temp = 0;
            for (int i = 0; i < count / 2; i++)
            {
                temp = items[i];
                items[i] = items[count - 1 - i];
                items[count - 1 - i] = temp;
            }
        } // reverse method

        // 4 - Extend the Array class and add a new method to insert an item at given index.
        public void insertAt(int item, int index)
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
        } // insertAt method

    } // Array class

} // Arrays namespace
