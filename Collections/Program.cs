using System;
using System.Collections;
using System.Diagnostics;
/*
    As lisas são estruturas de armazenamento sequencial assim como os arrays. Mas diferentemente dos arrays as 
    listas não possuem capacidade fixa

    IList é a intercafe c# que define os métodos que uma lista deve implementar.

    A principal implementação dessa interface é a classe ArrayList
    Ex.: ArrayLst arraylist = new arrayList();

    Alguns métodos
    
    - Add(object)
       Adiciona uma referência ao final da lista

    - Insert(int, object)
        Adiciona uma referência em uma posição (int)

    - Count()
        Informa a quantidade de elementos armazenados na lista

    - Clear()
        Remove todos os elementos da lista

    - Contains(object)
        Verifica de um elemento está contido em uma lista

    - Remove(object)
        Reftira um elemento da lista, remove a primeira ocorrência do elemento passado como parâmentro

    - RemoveAt(int)
        Remove o elemento pelo index passado como parâmetro
    
    - IndexOf(object)
        Para descobrir o indice da primeira ocorrência de um determinado elemento
    
    Propriedades

    - Item
        Utilizado para recuperar uma determinada posição de uma lista
            myList[posicao]


 */



namespace Collections
{



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios de ArrayList - Pág 142 apostila k19");

            ArrayList arraylist = new ArrayList();

            long tempo = Program.AdicionaNoFinal(arraylist);

            Console.WriteLine("ArrayList: " + tempo + "ms");
        }

        public static long AdicionaNoFinal(IList lista) {
        Stopwatch sw = new Stopwatch(); 
        sw.Start();
        
        int size = 20000;
        
        for(int i=0; i<size; i++) {
        lista.Add(i); }
        sw.Stop();
        return sw.ElapsedMilliseconds;
        }

    }
}
