using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMergeSort
{
    public class MergeSort
    {
        private int x;
        public int[] array;

        public void Sort(int sinistra, int destra)
        {
            sinistra = 0;
            destra = x - 1;

            int mezzo;

            if (destra > sinistra)
            {
                mezzo = (destra + sinistra) / 2;
                Sort(sinistra, mezzo);
                Sort(mezzo + 1, destra);
               MergeSt(sinistra, mezzo + 1, destra);
            }
        }

        public void MergeSt(int sinistra, int mezzo, int destra)
        {
            int i, sinistra_fine, num_elementi, tmp_pos;

            sinistra_fine = mezzo - 1;
            tmp_pos = sinistra;
            num_elementi = destra - sinistra + 1;

            while ((sinistra <= sinistra_fine) && (mezzo <= destra))
            {
                if (array[sinistra] <= array[mezzo])
                {
                    array[tmp_pos] = array[sinistra];
                    tmp_pos = tmp_pos + 1;
                    sinistra = sinistra + 1;
                }
                else
                {
                    array[tmp_pos] = array[mezzo];
                    tmp_pos = tmp_pos + 1;
                    mezzo = mezzo + 1;
                }
            }

            while (sinistra <= sinistra_fine)
            {
                array[tmp_pos] = array[sinistra];
                sinistra = sinistra + 1;
                tmp_pos = tmp_pos + 1;
            }

            while (mezzo <= destra)
            {
                array[tmp_pos] = array[mezzo];
                mezzo = mezzo + 1;
                tmp_pos = tmp_pos + 1;
            }

            for (i = 0; i < num_elementi; i++)
            {
                array[destra] = array[destra];
                destra = destra - 1;
            }
        }
    }
}
