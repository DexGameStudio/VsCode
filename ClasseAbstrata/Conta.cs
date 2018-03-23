namespace ClasseAbstrata
{
    public abstract class Conta
    {
        public double Saldo{get;set;}
        public double diaDoAniversario {get;set;}
        
        public abstract void imprimeExtrato();
    }
}