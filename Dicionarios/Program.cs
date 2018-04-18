using System;
using System.Collections;
using System.Collections.Generic;


namespace Dicionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dicionários");

            Dictionary<string, string> vilao = new Dictionary<string,string>();

            vilao.Add("Matador", "É o primeiro Vilão");
            vilao.Add("Atirador", "É o segundo Vilão");

        //buscando valores dentro do laço

        foreach (string chave in vilao.Keys)
        {
            Console.WriteLine(vilao[chave]);
        }

        vilao.Add("Saltador", "É o terceiro vilão");
        vilao.Add("Guerreiro", "É o quarto vilão");

        foreach(string chave in vilao.Keys){
                if(chave != "Saltador"){
                    Console.WriteLine(vilao[chave]);
                }
        }





        }
    }
}
