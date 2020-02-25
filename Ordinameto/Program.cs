using ClassEsercizio12;
using ClassMergeSort;
using Insert_sort;
using SelectionSort;
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
                    int[] array = new int[dim];
                    Random rnd = new Random();
                    for (int i = 0; i < dim; i++)
                        array[i] = rnd.Next(0, 10000000);
                    Stopwatch s = new Stopwatch();
                    s.Restart();
                    BubbleSort.Sort(array);
                    s.Stop();
                    long elapsed = s.ElapsedMilliseconds;
                    Console.WriteLine($"BubbleSort:{dim},{elapsed}");
                    w.WriteLine($"BubbleSort;{dim};{elapsed}");
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = rnd.Next(0, 100000);
                    }
                    s.Restart();
                    Sort.Insert(array);
                    s.Stop();
                    elapsed = s.ElapsedMilliseconds;
                    Console.WriteLine($"InsertionSort:{dim},{elapsed}");
                    w.WriteLine($"InsertionSort; {dim}; {elapsed}");
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = rnd.Next(0, 100000);
                    }
                    s.Restart();
                    Selection.Sort(array);
                    s.Stop();
                    elapsed = s.ElapsedMilliseconds;
                    Console.WriteLine($"SelectionSort:{dim},{elapsed}");
                    w.WriteLine($"SelectionSort; {dim}; {elapsed}");
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = rnd.Next(0, 100000);
                    }
                    s.Restart();
                    MergeSort.Merge(array);
                    s.Stop();
                    elapsed = s.ElapsedMilliseconds;
                    Console.WriteLine($"MergeSort:{dim},{elapsed}");
                    w.WriteLine($"MergeSort;{dim}; {elapsed}");

                }
                w.Flush();
                Console.WriteLine("fine!");
            } 
            Console.ReadLine();

        }
    }
}
