using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício Collections - Pág 144 Apostila K19");

        List<int> arrayList = new List<int>();

        long tempo = Program.AdicionaNoFinal(arrayList);
        Console.WriteLine("ArrayList: " + tempo + " ms");

        LinkedList<int> linkedList = new LinkedList<int>();

        tempo = Program.AdicionaNoFinal(linkedList);
        Console.WriteLine("ArrayList: " + tempo + " ms");
           
        }

        public static long AdicionaNoFinal(ICollection<int> lista){
            Stopwatch sw = new Stopwatch();

            sw.Start();
            int size = 100000;

            for (int i = 0; i < size; i++)
            {
                lista.Add(i);
            }
            sw.Stop();
            return sw.ElapsedMilliseconds;
        }




    }
}
