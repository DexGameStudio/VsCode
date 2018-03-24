using System;
/*
Object
Todas a classes derivam direta ou indiretamente da classe Object. Consequentemente todo conteúdo definido nessa classe está presente em todos os objetos.
Além disso qualquer referência pode ser armazenada em uma variável do tipo object. Ou seja, a idéia de polimorfismo pode ser usada para criar objetos genéricos que podem ser aplicados em qualquer objeto de qualquer classe. Em c# utilizamos object como alias para Object.


Polimorfismo
Aproveitando polimorfismo gerado pela herança da classe Object, é possível criar uma classe para armazenar objetos de qualquer tipo como se fosse um repositório de objetos

Class Repositorios
{
	//
} 

Um array de objetos pode ser utilizado como estrutura básica para manter os objetos 

Class Repositorios
{
	//object: alias para System.Object
	private object[] objetos = new object[100];
}

Alguns métodos podem ser criados para formar a interface do repositório. Ex métodos para adicionar, retirar e pesquisar.

Class Repositorio
{
	private object[] objetos = new object[100];

	public void Adiciona(object o)
	{
	// implementa
	}


	public void Remove(object o)
	{
	// implementa
	}

	public object Pega(int posicao)
	{
	// implementa
	}

}
 */

namespace Object
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio de Object");
// Criamos uma classe pessoas, instanciaremos alguns objetos pessoa 

        Pessoas p1 = new Pessoas("Arnoldo", 32);
        Pessoas p2 = new Pessoas("Sacha", 30);

        Repositorio repositorio = new Repositorio();

        repositorio.Adicionar(p1, 0);
        repositorio.Adicionar(p2,1);

        Console.WriteLine(repositorio.Pega(1));

        Console.WriteLine();
        
     

        
        //EXERCÍCIOS  DE FIXAÇÃO PÁG 129

        Funcionario f = new Funcionario();
        f.Nome = "Jonas Hirata";
        f.Salario = 30000;

        Console.WriteLine(f);


        //EXERCÍCIOS  DE FIXAÇÃO PÁG 130
                Console.WriteLine();

                Funcionario f1 = new Funcionario();
                f1.Nome = "Jonas Hirata";
                f1.Salario = 3000;

                Funcionario f2 = new Funcionario();

                f2.Nome = "Jonas Hirata";
                f2.Salario = 5000;

                Console.WriteLine("f1 == f2");
                Console.WriteLine(f1.Equals(f2));

        }
    }
}
