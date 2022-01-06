using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15___MediaAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno interacao = new Aluno();

            Console.Write("Digite a Primeira Nota: ");
            interacao.Nota1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a Segunda Nota: ");
            interacao.Nota2 = double.Parse(Console.ReadLine());
            Console.Write("Digite a Terceira Nota: ");
            interacao.Nota3 = double.Parse(Console.ReadLine());
            Console.Write("Digite a Quarta Nota: ");
            interacao.Nota4 = double.Parse(Console.ReadLine());

            interacao.AnalisarSituacao();

            Console.ReadLine();
        }
    }
}
