using System;
namespace Polimorfismo
{
    public class Estacionamento
    {
        public void ValidarTicket(Funcionarios veiculo){
            DateTime agora = DateTime.Now;
            string horario = String.Format("{0:d/MM/yyyy HH:mm:ss}", agora);

            Console.WriteLine("Data e Hora da entrada: " + horario);
            Console.WriteLine("Veículo " + veiculo.Veiculo);
        }

    }
}