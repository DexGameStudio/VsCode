using System;
using System.IO;


namespace EntradaESaida
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrada e Saída!");

        // TextReader teclado = Console.In;
        // string linha = teclado.ReadLine();
        
        // while (linha != null)
        // {
        //     Console.WriteLine(linha);
        //     linha = teclado.ReadLine();
        // }


        // Lendo conteudo de um arquivo de texto
        // TextReader arquivo = new StreamReader("jogadores.txt");
        // string linha2 = arquivo.ReadLine();

        // while (linha2 != null)
        // {
        //     Console.WriteLine(linha2);

        // }
        // arquivo.Close();



        //Cria um arquivo de texto e imprime nele

        TextWriter arquivo = new StreamWriter("saida.txt");

        arquivo.WriteLine("Primeira Linha");
        arquivo.WriteLine("Segunda Linha");
        arquivo.WriteLine("Terceira Linha");
        
        arquivo.Close();



        
        }
    }
}
