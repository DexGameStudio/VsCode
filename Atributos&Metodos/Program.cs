using System;

namespace Atributos_Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Atributos de Classe

            /* Em casos que os objetos compartilham de um mesmo atributo, chamamo-os de atributos de classe
            um atributo de clase deve ser acessado através do nome da Classe.atributo

            Ex.: No Jogo Clash Royale ao jogar uma carta existe uma tempo de mobilização, chamado de cast time, esse tempo é igual em todas as 
            cartas de criaturas. Quando o jogo está perto de acabar o tempo de cast é reduzido (uma espécie de modo rápido de jogo) sendo assim,
            todos os objetos do meu jogo precisarão ter o atributo tempoDeCast modificado.
            Veja o código a seguir e compare com o codigo da classe clash royale.  
            */
            Console.WriteLine("Exercício Atributos de Instância");

            ClashRoyale magoelEtrico = new ClashRoyale();
            ClashRoyale principe = new ClashRoyale();

            magoelEtrico.nomeCarta = "Mago Elétrico";
            principe.nomeCarta = "Príncipe";


            ClashRoyale.tempoDeCast = 3;

            // Durante o tempo normal do jogo
            Console.WriteLine("============ Modo Normal ======================");
            Console.WriteLine("O " + magoelEtrico.nomeCarta + " posui " + magoelEtrico.Retornatempo() + "segundos de cast time ");
            Console.WriteLine("O " + principe.nomeCarta + " posui " + principe.Retornatempo() + "segundos de cast time ");

            //Entrando em modo jogo rápido

            Console.WriteLine("============ Modo Rápido ======================");
            ClashRoyale.tempoDeCast = 1;
            Console.WriteLine("O " + magoelEtrico.nomeCarta + " posui " + magoelEtrico.Retornatempo() + " segundos de cast time ");
            Console.WriteLine("O " + principe.nomeCarta + " posui " + principe.Retornatempo() + " segundos de cast time ");
                       
        }
    }
}
