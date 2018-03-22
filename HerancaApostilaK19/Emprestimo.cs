using System;
namespace HerancaApostilaK19
{
    public class Emprestimo : Servicos
    {
        public double Valor {get; set;}
        public double Taxa {get; set;}


        public override double CalculaTaxa(){
            return this.Valor * 0.1;
        }

            public Emprestimo(){
             Console.WriteLine("Emprestimo");   
            }    
    
    }
}