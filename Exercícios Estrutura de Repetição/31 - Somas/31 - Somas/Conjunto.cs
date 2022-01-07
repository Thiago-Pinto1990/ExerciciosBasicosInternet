using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31___Somas
{
    public class Conjunto
    {
        List<int> Numeros = new List<int>();

        //public List<int> Numeros { get; set; }

        //CRIANDO CONSTRUTOR
        /*public Conjunto(List<int> numeros) // PROGRAMA NÃO RODOU COM MÉTODO DE ACESSO E CONSTRUTOR. VER ONDE ESTÁ O ERRO.
        {
            this.Numeros = numeros;
        }
        */

        //MÉTODO PARA INSERIR E SOMAR NÚMEROS 
        public void Imprimir()
        {
            int somaPar = 0;
            int somaImpar = 0;
            int resposta = 0;
            int iteracao = -1;

            do
            {
                iteracao += 1;
                Console.Write("DIGITE UM NÚMERO POSITIVO PARA ANALISAR: ");
                Numeros.Add(int.Parse(Console.ReadLine()));
                //Numeros.Insert(iteracao ,int.Parse(Console.ReadLine()));
                if(Numeros[iteracao] % 2 == 0)
                {
                    Console.WriteLine($"{Numeros[iteracao]} É PAR !");
                    somaPar += Numeros[iteracao];
                }
                else
                {
                    Console.WriteLine($"{Numeros[iteracao]} É ÍMPAR !");
                    somaImpar += Numeros[iteracao];
                }

                Console.Write("DIGITE 1 PARA CONTINUAR OU -1 PARA SAIR: ");
                resposta = int.Parse(Console.ReadLine());


            } while (resposta != -1);

            Console.WriteLine("\n");
            Console.WriteLine($"A SOMA DOS NÚMEROS PARES É {somaPar}");
            Console.WriteLine($"A SOMA DOS NÚMEROS ÍMPARES É {somaImpar}");
            Console.WriteLine("\n");

            foreach(var i in Numeros)
            {
                Console.Write($"{i} ");
            }

        }
    }
}
