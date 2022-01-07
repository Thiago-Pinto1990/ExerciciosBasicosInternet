using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26___ImprimindoNumeros
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


        public void Imprimir()
        {
            for(int i = Final; i >= Inicio; i--)
            {
                Console.Write($"{i} ");
            }

        }
    }
}
