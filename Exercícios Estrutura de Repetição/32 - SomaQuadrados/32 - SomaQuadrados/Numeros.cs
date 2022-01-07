using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32___SomaQuadrados
{
    public class Numeros
    {
        public int Num { get; set; }
        public int Iteracao { get; set; }//O USUÁRIO VAI DETERMINAR A QUANTIDADE DE NÚMEROS

        public Numeros(int num = 0 , int iteracao = 0)
        {
            this.Num = num;
            this.Iteracao = iteracao;
        }

        //MÉTODO PARA IMPRIMIR
        public void Imprimir()
        {
            int voltas = 0;

            while (voltas < Iteracao)
            {
                voltas += 1;
                if (Num % 2 != 0)
                {
                    Console.Write($"{Math.Pow(Num, 2)} ");
                    Num += 2;
                }
                else
                {
                    Num += 1;
                    Console.Write($"{Math.Pow(Num, 2)} ");
                    Num += 2;
                }

            }
            
        }
    }
}
