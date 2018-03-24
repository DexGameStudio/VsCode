using System;
namespace Object
{
    public class Repositorio
    {
        private object[] objetos = new object[10];

        public void Adicionar(object o, int index){
            objetos[index] = o;
        }
        public void Remove(object o, int index){
            objetos[index] = null;
        }

        public object Pega(int posicao){
            return objetos[posicao];
        }


        
    }
}