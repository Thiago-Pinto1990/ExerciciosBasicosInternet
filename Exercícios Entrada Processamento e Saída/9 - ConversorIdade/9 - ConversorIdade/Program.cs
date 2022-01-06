using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9___ConversorIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa interacao = new Pessoa();

            Console.Write("Digite os Anos: ");
            interacao.Anos = int.Parse(Console.ReadLine());
            Console.Write("Digite os Meses: ");
            interacao.Meses = int.Parse(Console.ReadLine());
            Console.Write("Digite os Dias: ");
            interacao.Dias = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine($"Você tem {interacao.ImprimirIdade()} dias de vida !");
            Console.ReadLine();
        }
    }
}
