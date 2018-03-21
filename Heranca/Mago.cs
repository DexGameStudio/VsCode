using System;

namespace Heranca
{
    public class Mago : Personagens
    {

        public double BolaDeFogo{get; set;}

        public double Atacar(){
        
        return PoderMagico * BolaDeFogo;

        }



        
        
    }
}