using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___CotacaoDolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Dolar interacao = new Dolar();

            Console.Write("Digite a quantia em dólares: ");
            interacao.Quantia = double.Parse(Console.ReadLine());
            Console.Write("Digite a cotação do dólar: ");
            interacao.Valor = double.Parse(Console.ReadLine());
            interacao.ImprimirConversao();

            Console.ReadLine();
            
        }
    }
}
