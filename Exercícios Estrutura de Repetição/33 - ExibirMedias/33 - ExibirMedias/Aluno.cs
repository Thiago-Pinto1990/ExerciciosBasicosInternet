using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33___ExibirMedias
{
    public class Aluno
    {
        Dictionary<string, double> Tabela = new Dictionary<string, double>();

        public void ImprimirDados()
        {
            int resposta = 0;
            int contagem = 0;
            string nome = null;
            double nota = 0;
            double soma = 0;

            do
            {
                contagem += 1;
                Console.Write("Digite o Nome do Aluno: ");
                nome = Console.ReadLine();
                Console.Write("Digite a Nota do Aluno: ");
                nota = double.Parse(Console.ReadLine());

                Tabela.Add(nome, nota);
                
                Console.Write("Digite -1 Para Sair ou 1 Para Continuar: ");
                resposta = int.Parse(Console.ReadLine());

            } while (resposta != -1);

            Console.WriteLine("\n");
            foreach(KeyValuePair<string,double> i in Tabela)
            {
                Console.WriteLine($"{i.Key} - {i.Value}");
                soma += i.Value;
            }

            Console.WriteLine("\n");
            Console.WriteLine($"A Média da Turma é {Math.Round(soma / Tabela.Count , 2)} !");
        }
    }
}
