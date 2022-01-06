using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12___ModuloNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Numeros interacao = new Numeros();

            Console.Write("Digite o Número: ");
            interacao.Numero = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            interacao.ImprimirModulo();

            Console.ReadLine();
        }
    }
}
