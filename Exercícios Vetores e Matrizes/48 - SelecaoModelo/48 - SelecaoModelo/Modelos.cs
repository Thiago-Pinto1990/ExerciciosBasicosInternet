using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48___SelecaoModelo
{
    public class Modelos
    {
        //RESOLVI FAZER ESSE EXERCÍCIO UTILIZANDO DICIONÁRIO
        //PRECISO APRENDER A CRIAR MÉTODO DE ACESSO E CONSTRUTOR PARA ARRAY
        Dictionary<string, int> Cadastro = new Dictionary<string, int>();

        //MÉTODO PARA RECEBER CADASTRO DE MODELOS
        public void ReceberCadastro()
        {
            string nome;
            int idade;
            for(int i = 0; i < 20; i++)
            {
                Console.Write("Digite o Nome da Modelo: ");
                nome = Console.ReadLine();
                Console.Write("Digite a Idade da Modelo: ");
                idade = int.Parse(Console.ReadLine());
                Cadastro.Add(nome, idade);
            }
        }

        //MÉTODO PARA ANALISAR CANDITADAS CADASTRADAS
        public void AnalisarCandidatas()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Lista Das Candidatas Aptas: ");
            Console.WriteLine("\n");
            foreach (KeyValuePair<string,int> i in Cadastro)
            {
                if (i.Value >= 18 && i.Value <= 20)
                {
                    Console.WriteLine($"{i.Key} - {i.Value}");
                }
            }
        }
    }
}
