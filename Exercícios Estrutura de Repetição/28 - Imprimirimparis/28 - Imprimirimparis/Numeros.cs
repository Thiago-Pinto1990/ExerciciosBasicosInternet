using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28___Imprimirimparis
{
    public class Numeros
    {
        public int Inicio { get; set; }
        public int Final { get; set; }

        public Numeros(int inicio = 0 , int final = 0)
        {
            this.Inicio = inicio;
            this.Final = final;
        }

        //MÉTODO PARA IMPRIMIR ÍMPARES
        public void ImprimirImpares()
        {
            for(int i = Inicio; i <= Final; i++)
            {
                if(i % 2 != 0)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
