using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32___SomaQuadrados
{
    class Program
    {
        static void Main(string[] args)
        {
            Numeros obj = new Numeros();

            do
            {
                Console.Write("Digite um Número: ");
                obj.Num = int.Parse(Console.ReadLine());

            } while (obj.Num <= 0 || obj.Num >= 10);

            Console.Write("Digite a Quantidade de Números: ");
            obj.Iteracao = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");
            obj.Imprimir();

            Console.ReadLine();
        }
    }
}
