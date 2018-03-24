namespace ClasseAbstrata
{
/*
Interface
No Sistema orientado a objetos, as classes conversam entre sim através dos métodos. Interface é um contrato assinado entre classes, 
uma vez que em herança uma classe filha não pode ter mais de uma mãe e por vezes necessitamos implementar métodos em classes distintas!


	•	Todos os métodos de uma interface são públicos e não podem incluir modificadores de acesso 
	•	Uma interface só pode conter métodos, propriedades, indexadores e eventos. 
	•	Por convenção em c# o nome de uma interface deve começar com I. No nosso exemplo aqui IConta.
	•	Uma interface é composta basicamente por métodos abstratos. 
	•	 Usando “ : ” fazemos a classe assinar o contrato com a interface. Ex.: public class ContaPoupanca : IConta 
	•	 Uma vez que a classe assine o contrato, esta, tem a obrigação de implementar os métodos daquela.


 */


    public interface IConta
    {
         void Deposita(double valor);
         void Saca(double valor);

         double Saldo {get;set;}
    }
}