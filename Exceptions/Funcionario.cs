using System;

namespace Exceptions
{
    public class Funcionario
    {

        private double salario;

        public void AumentaSalario(double aumento){
            if(aumento <0)
            {
                ArgumentException erro = new ArgumentException();
                throw erro;
            }else {
                this.salario += aumento;
            }
        }        
    }
}