using System;
namespace ClasseAbstrata
{
    public class Poupanca: Conta
    {

        

         public override void imprimeExtrato(){

            Console.WriteLine("EXTRATO DETALHADO DE CONTA POUPANÇA");
            System.DateTime agora = System.DateTime.Now;

            Console.WriteLine("Data " + agora.ToString("D"));
            Console.WriteLine("Saldo: " + this.Saldo);
            Console.WriteLine("Aniversário: " + this.diaDoAniversario);
         }
    }
}