using System;
using System.IO;

namespace ProjetoWirecast
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EDITOR DE NOMES DOS JOGADORES");

            Jogador j1 = new Jogador("JF");
            Jogador j2 = new Jogador("Komodo");

            j1.Jogador1();
            j2.Jogador2();
        }
    }
}
