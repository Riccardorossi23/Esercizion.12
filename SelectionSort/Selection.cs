using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    public class Selection
    {
        public static void Sort(int[] array)
        {
            int temp;
            for (int x = 0; x < array.Length; x++)
            {
                int i_min = x;
                for (int y = 0; y < array.Length; y++)
                {
                    if (array[y] < array[i_min])
                        i_min = y;
                }
                temp = array[i_min];
                array[i_min] = array[x];
                array[x] = temp;
            }
        }
    }
}