using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___OrdemDecrescente
{
    class Program
    {
        static void Main(string[] args)
        {
            Numeros interacao = new Numeros();

            Console.Write("Digite o Primeiro Número: ");
            interacao.Num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o Segundo Número: ");
            interacao.Num2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o Terceiro Número: ");
            interacao.Num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            interacao.ImprimirOrdem();

            Console.ReadLine();
        }
    }
}
