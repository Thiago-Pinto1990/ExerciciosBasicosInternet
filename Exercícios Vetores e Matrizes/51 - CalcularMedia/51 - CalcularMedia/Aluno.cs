using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51___CalcularMedia
{
    public class Aluno
    {
        Dictionary<string, double> Pauta = new Dictionary<string, double>();

        //MÉTODO PARA LER NOTAS
        public void LerNotas()
        {
            Console.Write("Digite a Quantidade de Alunos: ");
            int N = int.Parse(Console.ReadLine());
            for(int i = 0; i < N; i++)
            {
                Console.Write($"Digite o Nome do Aluno {i + 1}: ");
                string nome = Console.ReadLine();
                Console.Write($"Digite a Nota do Aluno {i + 1}: ");
                double nota = double.Parse(Console.ReadLine());
                Pauta.Add(nome, nota);
            }
        }

        //MÉTODO PARA ANALISAR NOTAS
        public void AnalisarNotas()
        {
            int NotaAcima = 0;
            int NotaAbaixo = 0;
            foreach(KeyValuePair<string,double> i in Pauta)
            {
                if(i.Value >= 7)
                {
                    NotaAcima += 1;
                }
                else if(i.Value < 5)
                {
                    NotaAbaixo += 1;
                }
            }

            if(NotaAcima >= 1)
            {
                Console.WriteLine("\n");
                Console.WriteLine($"{NotaAcima} Alunos Estão Com Notas Acima de 7 !");
            }
            else if(NotaAbaixo >= 1)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Não Há Nenhum Aluno Com Nota Acima de 5 !");
            }
        }
    }
}
