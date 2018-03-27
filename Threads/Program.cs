using System;
using System.Threading;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício de Thread pág 151");
        
        
            Thread t1 = new Thread(ImprimeK19);
            Thread t2 = new Thread(ImprimeK31);


            t1.Start();
            t2.Start();
       
        }


        public static void ImprimeK19()
        {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("K19");
                }

        }

        public static void ImprimeK31(){
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("K31");
            }
        }
    }
}
