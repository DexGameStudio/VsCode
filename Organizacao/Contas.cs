namespace Organizacao.Sistema.Contas
{
    public class Contas
    {
        public double Saldo {get;set;}
        public void Deposita(double valor){
            this.Saldo += valor;
        }
    }
}