using System;
namespace Heranca
{
    public class Personagens
    {
        public double Forca {get; set;}
        public double Destreza {get; set;}
        public double Habilidade {get; set;}
        public double PoderMagico {get; set;}

        public double Vitalidade {get; set;}

        public void ControleDeDano(Personagens nomePersonagem, double dano ){
            nomePersonagem.Vitalidade -= dano;
        }

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