using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20___Validando
{
    class Program
    {
        static void Main(string[] args)
        {
            Numeros interacao = new Numeros();

            //FAZENDO VALIDAÇÃO ATRAVÉS DE DO WHILE
            do
            {
                Console.Write("Digite o Primeiro Número: ");
                interacao.Num1 = int.Parse(Console.ReadLine());
            } while (interacao.Num1 <= 0);

            do
            {
                Console.Write("Digite o Segundo Número: ");
                interacao.Num2 = int.Parse(Console.ReadLine());
            } while (interacao.Num2 <= 0);

            do
            {
                Console.Write("Digite o Terceiro Número: ");
                interacao.Num3 = int.Parse(Console.ReadLine());
            } while (interacao.Num3 <= 0);

            Console.WriteLine("\n");
            interacao.ImprimirValores();

            Console.ReadLine();
        }
    }
}
