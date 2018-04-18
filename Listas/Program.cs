using System;
using System.Collections;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Listas");

            List<int> lista = new List<int>();

            lista.Add(100);
            lista.Add(200);
            lista.Add(300);


            Console.WriteLine(lista[0]);
            Console.WriteLine(lista[1]);
            Console.WriteLine(lista[2]);

            Console.WriteLine("Removendo numero 100");
            lista.Remove(100);

            Console.WriteLine(lista[0]);
            Console.WriteLine(lista[1]);
            //Console.WriteLine(lista[2]);
            // com isso 200 passou pro indice 0 e 300 passou para o indice 1

            lista.Add(400);
            lista.Add(500);
            lista.Add(600);
            lista.Add(700);
            lista.Add(800);

// Método IndexOf = busca qual o indice do parametro informado

           Console.WriteLine(lista.IndexOf(600));

        }
    }
}
