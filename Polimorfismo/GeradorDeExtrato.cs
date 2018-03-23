using System;

namespace Polimorfismo
{
    public class GeradorDeExtrato
    {
        public void imprimeExtratoBasico(Conta c){
            DateTime agora = DateTime.Now;
            string horario = String.Format("{0:d/M/yyy HH:mm:ss}", agora);

            Console.WriteLine("Data: " + horario);
            Console.WriteLine("Saldo: " + c.Saldo);
        }
    }
}