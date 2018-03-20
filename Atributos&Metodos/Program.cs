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
            Console.WriteLine("Exercício Atributos de Classe");

            ClashRoyale magoelEtrico = new ClashRoyale();
            ClashRoyale principe = new ClashRoyale();

            magoelEtrico.nomeCarta = "Mago Elétrico";
            principe.nomeCarta = "Príncipe";


            ClashRoyale.tempoDeCast = 3;

            // Durante o tempo normal do jogo
            Console.WriteLine("================== Modo Rápido ==========================");
            Console.WriteLine("O " + magoelEtrico.nomeCarta + " posui " + magoelEtrico.Retornatempo() + " segundos de cast time ");
            Console.WriteLine("O " + principe.nomeCarta + " posui " + principe.Retornatempo() + " segundos de cast time ");

            //Entrando em modo jogo rápido

            Console.WriteLine("================== Modo Rápido ==========================");
            ClashRoyale.tempoDeCast = 1;
            Console.WriteLine("O " + magoelEtrico.nomeCarta + " posui " + magoelEtrico.Retornatempo() + " segundos de cast time ");
            Console.WriteLine("O " + principe.nomeCarta + " posui " + principe.Retornatempo() + " segundos de cast time ");


            //SOBRECARGA
            /*
            No jogo Resident Evil nosso personagem precisa achar pentes de balas para poder atirar nos zumbis no caminho,
            normalmente um pente de arma possui 15 balas mas nem sempre os pentes possuem todas as balas, para este exercício 
            podemso utilizar o conceito de sobrecarga onde temos o método recarregarCartucho executando as duas situações 
            
             */


            Console.WriteLine("============ Exercício de Sobrecarga =====================");

            Sobrecarga arma01 = new Sobrecarga();
            Sobrecarga arma02 = new Sobrecarga();


            Console.WriteLine("Arma 01 com uso do método RecarregarCartucho()- não foi informado nenhum parâmetro");
            arma01.RetornaNumeroDeBalas();
            arma01.RecarregarCartucho();
            arma01.RetornaNumeroDeBalas();

            Console.WriteLine("Arma 02 com uso do método RecarregarCartucho(10) - informado o parâmetro 10");
            arma02.RecarregarCartucho(10);
            arma02.RetornaNumeroDeBalas();
                       
        }
    }
}
