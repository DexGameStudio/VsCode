using System;
using System.Collections;
using System.Collections.Generic;



namespace Enumeradores
{
                enum AI
            {
                Atacar,
                Correr,
                Patrulhar
                
            }
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enumeradores");

            AI vilaoFase1 = AI.Patrulhar;
            AI vilaoFase2 = AI.Atacar;
            AI vilaoFase3 = AI.Correr;

            Console.WriteLine(vilaoFase1);
            Console.WriteLine(vilaoFase2);
            Console.WriteLine(vilaoFase3);


            int v1 = (int)vilaoFase1;
            Console.WriteLine(v1);
        }
    }
}
