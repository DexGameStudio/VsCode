using System;
namespace HerancaApostilaK19
{
    public class Servicos
    {
        public Cliente Contratante {get; set;}
        public Funcionario Responsavel {get; set;}
        public string DataDeContratacao {get; set;}
       
        public virtual double CalculaTaxa(){
          
            return 10;
        }

        public Servicos(){
            Console.WriteLine("Serviços");
        }

    }
}