using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insert_sort
{
    public class Sort
    {
        public static void shiftR(int[] array, int buco)
        {
            int x;
            for (x = array.Length- 2; x >= buco; x--)
            {
                array[x + 1] = array[x];
            }
                
        }
        public static void Insert(int[]array)
        {
            int nuovo, x;
            int dove;
            for(x=0;x<array.Length;x++)
            {
                array[x] = 0;
                for(x=0;x<array.Length;x++)
                {
                    nuovo = (int)(Max * Math.random());
                    dove = 0;
                    while((array[dove]<nuovo)&&(array[dove]!=0))
                    {
                        dove++;
                        array(dove);
                        array[dove] = nuovo;
                    }
            

            
                }
            }
        }
    }
}
