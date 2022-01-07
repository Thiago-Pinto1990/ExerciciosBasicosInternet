using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26___ImprimindoNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Numeros interacao = new Numeros();

            Console.Write("Digite Início: ");
            interacao.Inicio = int.Parse(Console.ReadLine());
            Console.Write("Digite Final: ");
            interacao.Final = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            interacao.Imprimir();
            Console.ReadLine();
        }
    }
}
