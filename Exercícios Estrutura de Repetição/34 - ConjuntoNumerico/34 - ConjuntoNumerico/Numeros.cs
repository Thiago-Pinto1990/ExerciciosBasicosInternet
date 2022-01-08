using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34___ConjuntoNumerico
{
    public class Numeros
    {
        public int Num { get; set; }

        public Numeros(int num = 0)
        {
            this.Num = num;
        }

        public void OperarNumeros()
        {
            int menor = int.MaxValue;
            int maior = int.MinValue;
            int resposta = 0;

            do
            {
                Console.Write("Digite um Número: ");
                Num = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");

                if (Num > maior) maior = Num;
                if (Num < menor) menor = Num;

                Console.Write("Digite -1 Para Sair ou 1 Para Continuar: ");
                resposta = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");

            } while (resposta != -1);

            Console.WriteLine($"Maior = {maior}");
            Console.WriteLine($"Menor = {menor}");
        }
    }
}
