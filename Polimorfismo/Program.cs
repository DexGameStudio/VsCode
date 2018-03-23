using System;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício de Polimorfismo");

            GeradorDeExtrato gerador = new GeradorDeExtrato();

            ContaPoupanca cp = new ContaPoupanca();
            cp.Saldo = 2000;

            ContaCorrente cc = new ContaCorrente();
            cc.Saldo = 1000;


            gerador.imprimeExtratoBasico(cp);
            gerador.imprimeExtratoBasico(cc);


            Console.WriteLine("Exercício Complementares de Polimorfismo - pág 100 apostila k19");

            Estacionamento e1 = new Estacionamento();
            Gerentes g1 = new Gerentes();

            g1.Veiculo = "Fusion";

            e1.ValidarTicket(g1);

        }
    }
}
