using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47___ExercicioLista
{
    public class Operador
    {
        List<int> conjunto = new List<int>();
        public int Numero { get; set; }

        public Operador(int numero = 0)
        {
            this.Numero = numero;
        }

        public void Comparar()
        {
            int maior = 0;
            int igual = 0;
            int menor = 0;

            Console.Write("Digite o Número Para Ser Comparado com a Lista: ");
            Numero = int.Parse(Console.ReadLine());
            for(int i = 0; i < 10; i++)
            {
                Console.Write($"Digite o Número {i + 1}: ");
                conjunto.Add(int.Parse(Console.ReadLine()));
                if(conjunto[i] > Numero)
                {
                    maior += 1;
                }
                else if(conjunto[i] == Numero)
                {
                    igual += 1;
                }
                else
                {
                    menor += 1;
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine($"Dos 10 Números Digitados, {maior} São Maiores que {Numero}");
            Console.WriteLine($"Dos 10 Números Digitados, {igual} São Iguais a  {Numero}");
            Console.WriteLine($"Dos 10 Números Digitados, {menor} São Menores que {Numero}");
        }
    }
}
