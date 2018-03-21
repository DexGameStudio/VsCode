using System;
namespace Heranca
{
    public class Personagens
    {
        //Atributos de todos os personagens
        public double Forca {get; set;}
        public double Destreza {get; set;}
        public double Habilidade {get; set;}
        public double PoderMagico {get; set;}

        public double Vitalidade {get; set;}

//Método para contabilizar o dano
        public void ControleDeDano(Personagens nomePersonagem, double dano ){
            nomePersonagem.Vitalidade -= dano;
        }

//Métdo para imprimir a ficha dos personagens        

            public void ImprimirSttus(){
            Console.WriteLine("Força " + Forca);
            Console.WriteLine("Destreza " + Destreza);
            Console.WriteLine("Vitalidade " +Vitalidade);
            Console.WriteLine("Habilidade " + Habilidade);
            Console.WriteLine("PoderMagico " + PoderMagico);
            Console.WriteLine();
        }


    }
}