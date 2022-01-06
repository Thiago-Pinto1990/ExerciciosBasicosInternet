using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5___CustoDaViagem
{
    class Program
    {
        static void Main(string[] args)
        {
            Informacoes interacao = new Informacoes();

            Console.Write("Digite o Tempo de Viagem em Horas: ");
            interacao.Tempo = double.Parse(Console.ReadLine());
            Console.Write("Digite a Velocidade Média da Viagem: ");
            interacao.VelocidadeMedia = double.Parse(Console.ReadLine());
            Console.Write("Digite o Preço do Combustível: ");
            interacao.PrecoCombustivel = double.Parse(Console.ReadLine());
            Console.Write("Digite o Consumo Por Litro do Veículo: ");
            interacao.ConsumoPorLitro = double.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            Console.Write($"O Consumo Total foi {interacao.CalcularConsumo()} reais !");

            Console.ReadLine();

        }
    }
}
