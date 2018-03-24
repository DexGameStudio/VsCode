using System;
namespace ClasseAbstrata
{
    public class Poupanca: IConta
    {

        public double Saldo {get;set;}
        private double taxaPorOperacao = 0.45;


        //Implementando os métodos da interface IConta
        public void Deposita(double valor){
            this.Saldo += valor - this.taxaPorOperacao;
        }
        
        public void Saca(double valor){
            this.Saldo -= valor - this.taxaPorOperacao;
        }

        //  public override void imprimeExtrato(){

        //     Console.WriteLine("EXTRATO DETALHADO DE CONTA POUPANÇA");
        //     System.DateTime agora = System.DateTime.Now;

        //     Console.WriteLine("Data " + agora.ToString("D"));
        //     Console.WriteLine("Saldo: " + this.Saldo);
        //     Console.WriteLine("Aniversário: " + this.diaDoAniversario);
        //  }

    }
}