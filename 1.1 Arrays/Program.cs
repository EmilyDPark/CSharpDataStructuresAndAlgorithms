using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---------------------------------------- Using created Array class ----------------------------------------

            // Create an object of the Array class
            Array numbers = new Array(3);

            // insert method
            numbers.Insert(10);
            numbers.Insert(20);
            numbers.Insert(30);
            numbers.Insert(40);

            // removeAt method
            numbers.RemoveAt(3);

            // indexOf method
            Console.WriteLine(numbers.IndexOf(10));

            // print method
            numbers.Print();

            // printArray method
            numbers.PrintArray();


            // ---------------------------------------- Exercises ----------------------------------------

            // max method
            Console.WriteLine(numbers.Max());

            // intersect method
            // Create a new array to compare
            Array newNums = new Array(5);
            newNums.Insert(10);
            newNums.Insert(20);
            newNums.Insert(40);
            newNums.Insert(50);
            newNums.Insert(60);
            Console.WriteLine("\nnewNums");
            newNums.PrintArray();

            numbers.Intersect(newNums).PrintArray();

            // reverse method
            numbers.Reverse();
            numbers.PrintArray();

            Array nullArr = new Array(0);
            nullArr.Reverse();
            nullArr.PrintArray();

            // insertAt method
            numbers.InsertAt(15, 2);
            numbers.PrintArray();

        } // Main method

    } // Program class

} // Arrays namespace
