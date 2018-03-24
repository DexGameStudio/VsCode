namespace ClasseAbstrata
{
    public class Corrente : IConta
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
        
    }
}