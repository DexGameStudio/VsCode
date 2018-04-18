using System;

namespace BreakAndContinue
{
    class Program
    {
        static void Main(string[] args)
        {
string[] classesJogadores = new string[]{"Humano", "Elfo", "Orc", "Morto Vivo" };

    foreach (string classes in classesJogadores)
    {
        if(classes == "Elfo")
        {
            continue;
        }
        Console.WriteLine(classes);
    }




        }
    }
}
