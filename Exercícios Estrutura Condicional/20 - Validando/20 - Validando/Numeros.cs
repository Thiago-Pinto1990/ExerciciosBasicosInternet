using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20___Validando
{
    public class Numeros
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Num3 { get; set; }


        public Numeros(int num1 = 0 , int num2 = 0 , int num3 = 0)
        {
            this.Num1 = num1;
            this.Num2 = num2;
            this.Num3 = num3;
        }

        public void ImprimirValores()
        {
            double menor;
            double maior;
            if(Num1 > Num2 && Num1 > Num3)
            {
                if(Num2 > Num3)
                {
                    maior = Num1;
                    menor = Num3;
                    Console.WriteLine($"{menor} x {maior} = {menor*maior}");
                    Console.WriteLine($"{maior} / {menor} = {maior/menor}");
                }
                else
                {
                    maior = Num1;
                    menor = Num2;
                    Console.WriteLine($"{menor} x {maior} = {menor * maior}");
                    Console.WriteLine($"{maior} / {menor} = {maior / menor}");
                }
            }
            else if(Num2 > Num1 && Num2 > Num3)
            {
                if(Num1 > Num3)
                {
                    maior = Num2;
                    menor = Num3;
                    Console.WriteLine($"{menor} x {maior} = {menor * maior}");
                    Console.WriteLine($"{maior} / {menor} = {maior / menor}");
                }
                else
                {
                    maior = Num2;
                    menor = Num1;
                    Console.WriteLine($"{menor} x {maior} = {menor * maior}");
                    Console.WriteLine($"{maior} / {menor} = {maior / menor}");
                }
            }
            else
            {
                if(Num2 > Num1)
                {
                    maior = Num3;
                    menor = Num1;
                    Console.WriteLine($"{menor} x {maior} = {menor * maior}");
                    Console.WriteLine($"{maior} / {menor} = {maior / menor}");
                }
                else
                {
                    maior = Num3;
                    menor = Num2;
                    Console.WriteLine($"{menor} x {maior} = {menor * maior}");
                    Console.WriteLine($"{maior} / {menor} = {maior / menor}");
                }
            }
        }
    }
}
