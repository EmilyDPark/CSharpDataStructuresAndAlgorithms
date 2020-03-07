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
            numbers.insert(10);
            numbers.insert(20);
            numbers.insert(30);
            numbers.insert(40);

            // removeAt method
            numbers.removeAt(3);

            // indexOf method
            Console.WriteLine(numbers.indexOf(10));

            // print method
            numbers.print();

            // printArray method
            numbers.printArray();


            // ---------------------------------------- Exercises ----------------------------------------

            // max method
            Console.WriteLine(numbers.max());

            // intersect method
            // Create a new array to compare
            Array newNums = new Array(5);
            newNums.insert(10);
            newNums.insert(20);
            newNums.insert(40);
            newNums.insert(50);
            newNums.insert(60);
            Console.WriteLine("\nnewNums");
            newNums.printArray();

            numbers.intersect(newNums).printArray();

            // reverse method
            numbers.reverse();
            numbers.printArray();

            Array nullArr = new Array(0);
            nullArr.reverse();
            nullArr.printArray();

            // insertAt method
            numbers.insertAt(15, 2);
            numbers.printArray();
        }
    }
}
