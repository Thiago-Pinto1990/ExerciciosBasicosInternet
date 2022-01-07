using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23___MenuOpcoes
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

            Console.WriteLine("1 - Adição\n2 - Subtração\n3 - Multiplicação\n4 - Divisão\n");
            Console.Write("Escolha a Opção Desejada: ");
            interacao.Opcao = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");
            interacao.Imprimir();

            Console.ReadLine();
        }
    }
}
