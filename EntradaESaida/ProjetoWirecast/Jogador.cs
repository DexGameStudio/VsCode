using System;
using System.IO;

namespace ProjetoWirecast
{
    public class Jogador
    {
        public string NomeJogador {get;set;}

        public Jogador(string NomeJogador){
            this.NomeJogador = NomeJogador;
        }


        public void Jogador1(){
            TextWriter arquivo = new StreamWriter("jogador1.txt");
            arquivo.WriteLine(NomeJogador.ToString());
            arquivo.Close();
        }

        public void Jogador2(){
            TextWriter arquivo = new StreamWriter("jogador2.txt");
            arquivo.WriteLine(NomeJogador.ToString());
            arquivo.Close();
        }

    }
}