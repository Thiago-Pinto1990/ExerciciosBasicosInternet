using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4___Soma2a2
{
    public class Numeros
    {
        //MÉTODO DE ACESSO
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Num3 { get; set; }
        public int Num4 { get; set; }

        //COSTRUTOR
        public Numeros(int num1 = 0 , int num2 = 0 , int num3 = 0 , int num4 = 0)
        {
            this.Num1 = num1;
            this.Num2 = num2;
            this.Num3 = num3;
            this.Num4 = num4;
        }

        //MÉTODO PARA IMPRIMIR SOMA
        public void ImprimirSoma()
        {
            Console.WriteLine($"{Num1} + {Num2} = {Num1 + Num2}");
            Console.WriteLine($"{Num1} + {Num3} = {Num1 + Num3}");
            Console.WriteLine($"{Num1} + {Num4} = {Num1 + Num4}");
            Console.WriteLine($"{Num2} + {Num3} = {Num2 + Num3}");
            Console.WriteLine($"{Num2} + {Num4} = {Num2 + Num4}");
            Console.WriteLine($"{Num3} + {Num4} = {Num3 + Num4}");
        }
        
        //MÉTODO PARA IMPRIMIR MULTIPLICAÇÃO
        public void ImprimirMultiplicacao()
        {
            Console.WriteLine($"{Num1} x {Num2} = {Num1 * Num2}");
            Console.WriteLine($"{Num1} x {Num3} = {Num1 * Num3}");
            Console.WriteLine($"{Num1} x {Num4} = {Num1 * Num4}");
            Console.WriteLine($"{Num2} x {Num3} = {Num2 * Num3}");
            Console.WriteLine($"{Num2} x {Num4} = {Num2 * Num4}");
            Console.WriteLine($"{Num3} x {Num4} = {Num3 * Num4}");
        }
    }
}
