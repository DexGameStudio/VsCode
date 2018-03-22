using System;
namespace HerancaApostilaK19
{
    public class Funcionario
    {
        public string Nome {get; set;}
        public double Salario {get; set;}
    
        public virtual double CalculaBonificacao(){
            return this.Salario * 0.1;
        }
    
        public virtual void ImprimirDados(){
            Console.WriteLine(this.Nome);
            Console.WriteLine(this.Salario);
            Console.WriteLine(CalculaBonificacao());
        }
    }
}