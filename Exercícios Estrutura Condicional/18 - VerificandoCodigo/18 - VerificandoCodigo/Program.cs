using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18___VerificandoCodigo
{
    class Program
    {
        static void Main(string[] args)
        {
            Numeros interacao = new Numeros();

            Console.Write("Digite o Código: ");
            interacao.Codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            interacao.ImprimirNumero();

            Console.ReadLine();
        }
    }
}
