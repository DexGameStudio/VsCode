using System;

namespace Atributos_Metodos
{

/*
    Quando métodos possuem o mesmo nome e parâmetros diferentes, dizemos que houve uma sobrecarga 

 */


    public class Sobrecarga
    {
        
        public int numeroDeBalas;


        public void RecarregarCartucho(){
            numeroDeBalas += 15;
        }

        public void RecarregarCartucho(int numero){
            numeroDeBalas += numero;
        }

        public  void RetornaNumeroDeBalas(){
            Console.WriteLine(numeroDeBalas);
        }



        
        




    }
}