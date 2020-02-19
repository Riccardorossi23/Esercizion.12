using ClassEsercizio12;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordinameto
{
    class Program
    {
        static void Main(string[] args)
        {
             int[] dimensioni = {20, 50, 100, 500,1000,2000,5000,10000,20000, 30000,40000,50000,60000,100000};
            using(StreamWriter w=new StreamWriter("stat.csv",false,Encoding.UTF8))
            {
                w.WriteLine("Algoritmo;Dimensione;Tempo");
                foreach (int dim in dimensioni)
                {
                    int[] numeri = new int[dim];
                    Random rnd = new Random();
                    for (int i = 0; i < dim; i++)
                        numeri[i] = rnd.Next(0, 10000000);
                    Stopwatch s = new Stopwatch();
                    s.Start();
                    BubbleSort.Sort(numeri);
                    Insert_sort.Insert(numeri);
                    s.Stop();
                    long elapsed = s.ElapsedMilliseconds;
                    Console.WriteLine($"BubbleSort:{dim},{elapsed}");
                    w.WriteLine($"BubbleSort;{dim};{elapsed}");

                }
                w.Flush();
            } 
            Console.ReadLine();
        }
    }
}
