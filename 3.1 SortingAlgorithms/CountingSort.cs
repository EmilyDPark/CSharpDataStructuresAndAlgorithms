using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class CountingSort
    {
        public void Sort(int[] array)
        {
            var counts = new int[Max(array) + 1];

            foreach (int num in array)
                counts[num]++;

            int k = 0;
            for (int i = 0; i < counts.Length; i++)
                for (int j = 0; j < counts[i]; j++)
                    array[k++] = i;
        }

        public int Max(int[] array)
        {
            var max = 0;
            foreach (int num in array)
            {
                if (num > max)
                    max = num;
            }
            return max;
        }
    }
}
