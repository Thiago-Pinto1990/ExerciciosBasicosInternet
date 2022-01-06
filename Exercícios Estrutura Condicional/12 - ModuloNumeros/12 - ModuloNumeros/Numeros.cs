using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12___ModuloNumeros
{
    public class Numeros
    {
        public int Numero { get; set; }

        public Numeros(int numero = 0)
        {
            this.Numero = numero;
        }

        public void ImprimirModulo()
        {
            if(Numero >= 0)
            {
                Console.WriteLine($"O módulo de {Numero} é {Numero}");
            }
            else
            {
                Console.WriteLine($"O módulo de {Numero} é {Numero*-1}");
            } 
            
        }
    }
}
