using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insert_sort
{
    public class Sort
    {
        public static void Insert(int[] array)
        {
            int nuovo;//flag
            int dove;//val
            for (int i = 1; i < array.Length; i++)
            {
                dove = array[i];
                nuovo = i - 1;
                while (nuovo >= 0 && array[nuovo] < dove)
                {
                    array[nuovo + 1] = array[nuovo];
                    nuovo--;
                }
                array[nuovo + 1] = dove;

            }
          
        }

    }
}
        