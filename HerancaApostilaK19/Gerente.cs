using System;
namespace HerancaApostilaK19
{
    public class Gerente : Funcionario
    {
        public string Usuario {get; set;}
        public string Senha {get;set;}

        public override double CalculaBonificacao(){
            return this.Salario * 0.6 + 100;
        }

    public override void ImprimirDados(){
        Console.WriteLine(this.Nome);
        Console.WriteLine(this.Salario);
        Console.WriteLine(this.CalculaBonificacao());
    }

    }
}