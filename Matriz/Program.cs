using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matiz2x2 = new int[2,2];

            matiz2x2[0,0] = 1;
            matiz2x2[0,1] = 2;
            matiz2x2[1,0] = 3;
            matiz2x2[1,1] = 4;

            Console.WriteLine(matiz2x2[1,1]);

            // Alimentando matriz com o laço FOR

            int[,] matizFOR = new int[2,2];
            int valor = 1;

            for (int linhas = 0; linhas <= 1; linhas++)
            {
                for (int colunas = 0; colunas <= 1; colunas++)
                {
                    matizFOR[linhas,colunas] = valor;
                    valor++;
                }
                
            }

                for (int linhas = 0; linhas <= 1; linhas++)
            {
                for (int colunas = 0; colunas <= 1; colunas++)
                {
                    Console.WriteLine(linhas+ " : " + colunas + " = " + matizFOR[linhas,colunas]);

                }
                
            }








        }
    }
}
