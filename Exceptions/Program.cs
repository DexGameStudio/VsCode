using System;



/*          TRATAMENTO DE ERROS

    Para lançar um erro, devemos criar um objeto de qualquer classe que derive de excepciona 
    para representar o erro que foi identificado. Depois de criar uma excepciona podemos 
    “lançar” a referencia dela utilizando o comando throw. Ex.:

if(valor < 0)
{
	System.ArgumentException erro = new system. ArgumentException;
	throw erro;
}

Capturando Erros
Para capturar uma exception utilizamos o try-catch

Class Teste
{
	static void main()
	{
		Conta c = new Conta();
		try
		{
			c.Deposita(100);
		}
		catch (System.ArgmentException e)
		{
		Console.WriteLine(“Erro  ao Depositar”);
		}
	}
}


Vários blocos de catch podem ser encadeados para identificar diferentes tipos de 
exceptions. Lembrando que a primeira ocorrência de uma catch o sistema exibe o
erro e segue para o fim do try-catch.

FINALLY

Se um erro acontecer no bloco try ele é abortado, em caso de erro apenas um bloco 
do catch é executado. Em alguns casos, queremos executar um trecho de código 
independentemente de ter ou não erros.

		try
		{
			c.Deposita(100);
		}
		catch (System.DivideByZero e)
		{
		Console.WriteLine(“Tratamento de divisão por 0”);
		}
		catch (System.NullReferenceException e)
		{
		Console.WriteLine(“Tratamento de referencia nula”);
		}
		finally
		{
		//executa sempre!
		}



 */


namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teste de tratamento de erros com throw");
        
            Funcionario f = new Funcionario();
            // usando throw o sistema previne a entrada do valor e interrompe a aplicação, tente retirar o comentário da linha abaixo //
            // f.AumentaSalario(-1000);


            // Agora faremos o tratamento dentro da classe main


            Console.WriteLine("Teste de tratamento de erros com try-catch");

            try
            {
                f.AumentaSalario(-1000);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Houve uma ArgmentException ao aumentar o salário");
                //throw;
            }

            



        }
    }
}
