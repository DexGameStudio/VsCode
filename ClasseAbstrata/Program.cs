using System;

    /* CLASSES ABSTRATAS 

    Durante a criação de classes dentro de uma abstração em heranças temos 
    exemplos de classes que de fato não representam um "objeto" real. Ex.:
    Em um banco temos a classe Conta e as sub classes Conta Poupança e Conta
    Corrente. Durante a criação de uma conta, jamais poderiamos ter uma instância
    de uma classe apenas Conta, um objeto tipo Conta não é suficiente para 
    representar uma conta que pertença ao domínio Banco.


    Para evitar que uma classe abstrata seja instanciada temos o modificador abstract


    MÉTODOS ABSTRATOS

    Em alguns casos métodos da classe mãe não são suficientes e o usuário necessita 
    de métodos mais específicos em cada classe filha quando criamos um método abstrato
    os as classes filhas são obrigadas a implementarem indivudualmente o corpo daquele método

    um método abstrato é uma declaração de método na classe abstrata e sem corpo. Ex.:

       abstract class Conta
    {
        

        public abstract void imprimeExtrato();
    } 

    todas as classes filhas de Conta são obrigadas a implementar o método imprimirExtrato()

   */





namespace ClasseAbstrata
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Teste de Classes e Métodos Abstratos");

         Console.WriteLine("Teste de Interface");


        Corrente c1 = new Corrente();
        Poupanca p1 = new Poupanca();

        c1.Deposita(500);
        p1.Deposita(500);

        c1.Saca(100);
        p1.Saca(100);

        Console.WriteLine(c1.Saldo);
        Console.WriteLine(p1.Saldo);

        }
    }
}
