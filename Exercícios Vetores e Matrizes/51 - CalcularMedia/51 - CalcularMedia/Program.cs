using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51___CalcularMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno interacao = new Aluno();
            interacao.LerNotas();
            interacao.AnalisarNotas();
            Console.ReadLine();
        }
    }
}
