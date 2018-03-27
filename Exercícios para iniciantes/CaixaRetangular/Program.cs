using System;



namespace CaixaRetangular
{
    class Program
    {
        static void Main(string[] args)
        {


            Cubo c1 = new Cubo();
            
            Console.WriteLine("Entre com o comprimento da caixa");
            c1.Comprimento = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Entre com a largura da caixa ");
            c1.Largura = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Entre com a altura da caixa");
            c1.Altura = double.Parse(Console.ReadLine());
            Console.WriteLine();

            c1.CalculaArea();

            Console.WriteLine("O volume da caixa informada é "  + c1.Area + " metros cúbicos");


            Console.WriteLine("Fim da aplicação");
        }

        public class Cubo{

            public double Comprimento {get;set;}
            public double Largura {get;set;}
            public double Altura{get;set;}
            public double Area{get;set;}
        
        
        public void CalculaArea(){
        
            Area += Comprimento*Largura*Altura;
        }
        

        }

    }
}
