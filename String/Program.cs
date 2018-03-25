using System;
/*

Classe String

Uma característica fundamental da classe string é a imutabilidade. Alguns métodos pode dar a 
impressão errada de que o conteúdo do objeto será alterado. Por exemplo o método ToUpper() 
que é utilizado para obter uma string com letras maiúsculas. Esse método não altera a string 
original, ele cria uma nova string com o conteúdo diferente.

Métodos e propriedades da classe String

Lenght
Armazena a quantidade de caracteres de uma string.

ToUpper
O método ToUpper() é utilizado para obter uma cópia de uma string com letras maiúsculas. 

ToLower
O método Tolower() é utilizado para obter uma cópia de uma string com letras minúsculas.

Trim
O método Trim() é utilizado para obter uma cópia de uma string sem espaços em branco no final e início.

Split
O método Split() divide uma string em várias de acordo com um delimitador e devolve um array com as strings obtidas. 

 Replace
O método Replace() cria uma cópia de uma string substituindo “pedaços” internos por outro conteúdo.  
 */


namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Explicando imutabilidade");
            string nome = "Arnoldo Silva";
            nome.ToUpper();
            //Imprime Arnoldo Silva
            Console.WriteLine(nome);
            Console.WriteLine();
            //Imprime o nome alterado
            string nomeAlterado = nome.ToUpper();
            Console.WriteLine(nomeAlterado);
            Console.WriteLine();

            // Método Lenth
           Console.WriteLine("Método Lenght()");
            Console.WriteLine(nome.Length);
            Console.WriteLine();
            // Método ToUpper

            nomeAlterado = nome.ToUpper();
            Console.WriteLine(nomeAlterado);
            Console.WriteLine();

            //Método Tolower
           Console.WriteLine("Método ToLower()");
            nomeAlterado = nome.ToLower();
            Console.WriteLine(nomeAlterado);
            Console.WriteLine();
           
           
            // Método Trim
           Console.WriteLine("Método Trim()");
           
            string nomeTest = " Antono Arnoldo ";
            Console.WriteLine(nomeTest);

            nomeAlterado = nomeTest.Trim();
            Console.WriteLine(nomeAlterado);
            Console.WriteLine();
            
            //Método Split
            Console.WriteLine("Método Split()");

            string texto = " k31, k32";
            string[] cursos = texto.Split(new char[]{','});
            //Imprime k31
            Console.WriteLine(cursos[0]);
            //Imprime k32
            Console.WriteLine(cursos[1]);
            Console.WriteLine();

            // Os elementos ficaram com o caractere vazio, utilizar o for combinado com o trim para remover os caracteres
            for (int i = 0; i < cursos.Length; i++)
            {
                cursos[i] = cursos[i].Trim();
                Console.WriteLine(cursos[i]);
            }
            Console.WriteLine();

            //Método Replace()
            string texto1 = "Curso de Csharp da k19, Curso e ASP .NET MVC da K19 ";
            Console.WriteLine(texto1);

            string texto1Alterado = texto1.Replace("Curso" , "Treinamento");

            Console.WriteLine(texto1Alterado);


        }
    }
}
