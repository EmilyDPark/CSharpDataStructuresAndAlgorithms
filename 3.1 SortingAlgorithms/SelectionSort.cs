using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class SelectionSort
    {
        public void Sort(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                var minIndex = i;
                for (var j = i; j < array.Length; j++)
                    if (array[j] < array[minIndex])
                        minIndex = j;
                Swap(array, minIndex, i);
            }
        }

        public void Swap(int[] array, int index1, int index2)
        {
            var temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
    }
}
