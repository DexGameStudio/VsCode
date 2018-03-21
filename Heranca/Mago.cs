using System;

namespace Heranca
{
    public class Mago : Personagens
    {
//atributos, no caso a Magia de ataque 
        public double BolaDeFogo{get; set;}

// Método de atacar do mago
        public double Atacar(){
        
        return PoderMagico * BolaDeFogo;

        }



        
        
    }
}