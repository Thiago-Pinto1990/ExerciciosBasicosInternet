using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28___Imprimirimparis
{
    class Program
    {
        static void Main(string[] args)
        {
            Numeros interacao = new Numeros();

            Console.Write("Digite o Início do Intervalo: ");
            interacao.Inicio = int.Parse(Console.ReadLine());
            Console.Write("Digite o Final do Intervalo: ");
            interacao.Final = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            interacao.ImprimirImpares();
            Console.ReadLine();
        }
    }
}
