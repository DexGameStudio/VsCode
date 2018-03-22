using System;

namespace HerancaApostilaK19
{
    class Program
    {
        static void Main(string[] args)
        {
  Gerente g = new Gerente();
g.Nome = "Rafael Cosentino";
g.Salario = 2000;
g.Usuario = "rafael.cosentino";
g.Senha =  "12345";



Telefonista t = new Telefonista();
t.Nome = "Carolina Mello";
t.Salario = 1000;
t.EstacaoDeTrabalho = 13;

Secretario s = new Secretario();
s.Nome = "Tatiane Andrade";
s.Salario = 1500;
s.Ramal = 198;

Console.WriteLine("GERENTE");
Console.WriteLine("Nome: " + g.Nome);
Console.WriteLine("Salário: " + g.Salario);
Console.WriteLine("Usuário: " + g.Usuario);
Console.WriteLine("Senha: " + g.Senha);
Console.WriteLine("Bonificação: " + g.CalculaBonificacao());
Console.WriteLine("TELEFONISTA");
Console.WriteLine("Nome: " + t.Nome);
Console.WriteLine("Salário: " + t.Salario);
Console.WriteLine("Estacao de trabalho: " + t.EstacaoDeTrabalho);
Console.WriteLine("Bonificação: " + t.CalculaBonificacao());

Console.WriteLine("SECRETARIA");
Console.WriteLine("Nome: " + s.Nome);
Console.WriteLine("Salário: " + s.Salario);
Console.WriteLine("Ramal: " + s.Ramal);
Console.WriteLine("Bonificação: " + s.CalculaBonificacao());


        }
    }
}
