using System;
using Organizacao.Sistema.Contas;


/* ORGANIZAÇÕES

NAMESPACE

   A medida que uma organização cresce devemos atentar para sua organização. 
   Assim como utilizamos pastas em um computador para organizar arquivos, durante 
   o desenvolvimento de uma aplicação podemos utilizar os namespace.

NAMESPACE encadeados

namespace Sistema
{ 
	namespace Contas
		{
			classe Conta
			{
				//Corpo
			}

		}

}	 

Ou 
Namespace Sistema.Contas
{
	Class Conta
	{
		//Corpo
	}
}

Namespace Global

Todas as classes, interfaces ou namespaces que não forem explicitamente 
colocadas em um namespace são automaticamente colocados no namespace global.

Classes com o mesmo namespace podem conversar entre si utilizando o nomes simples de cada uma delas
EX.:

namespace Sistema.Contas
{ 
			classe Conta
			{
				//Corpo
			}

}

Namespace Sistema.Contas

classe Poupanca: Conta
			{
				//Corpo
			}

		}


Using

Para facilitar a escrita do código podemos utilizar o comando using e não repetir o 
nome completo de uma classe ou interface várias vezes dentro de um mesmo arquivo.

Using Sistema.Contas;

namespace Sistema.Clientes

		{
			classe Cliente
			{
				/private Conta conta;
			}

		}
 




 */



namespace Organizacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teste Classe Organizacao.Sistema.Contas.Conta.cs");

            Contas c = new Contas();

            c.Deposita(100);
            Console.WriteLine(c.Saldo);

        }
    }
}
