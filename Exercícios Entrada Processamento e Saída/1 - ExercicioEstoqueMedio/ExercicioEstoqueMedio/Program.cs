using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEstoqueMedio
{
    class Program
    {
        static void Main(string[] args)
        {
            Estoque interacao = new Estoque(0 , 0);
            
            Console.Write("Quantidade Mínima: ");
            interacao.QntMinima = int.Parse(Console.ReadLine());
            Console.Write("Quantidde Máxima: ");
            interacao.QntMaxima = int.Parse(Console.ReadLine());
            Console.WriteLine($"O estoque médio é {interacao.CalculoMedio()} !");

            Console.ReadLine();
        }
    }
}
