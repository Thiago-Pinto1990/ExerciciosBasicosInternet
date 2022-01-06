using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___OrdemDecrescente
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

        //MÉTODO CONSIDERANDO TODOS OS NÚMEROS DIFERENTES
        public void ImprimirOrdem()
        {
            if(Num1 > Num2 && Num1 > Num3)
            {
                if(Num2 > Num3)
                {
                    Console.WriteLine($"A Ordem Decrescente é {Num1} , {Num2} e {Num3}");
                }
                else
                {
                    Console.WriteLine($"A Ordem Decrescente é {Num1} , {Num3} e {Num2}");
                }
            }
            else if(Num2 > Num1 && Num2 > Num3)
            {
                if(Num1 > Num3)
                {
                    Console.WriteLine($"A Ordem Decrescente é {Num2} , {Num1} e {Num3}");
                }
                else
                {
                    Console.WriteLine($"A Ordem Decrescente é {Num2} , {Num3} e {Num1}");
                }
            }
            else
            {
                if(Num1 > Num2)
                {
                    Console.WriteLine($"A Ordem Decrescente é {Num3} , {Num1} e {Num2}");
                }
                else
                {
                    Console.WriteLine($"A Ordem Decrescente é {Num3} , {Num2} e {Num1}");
                }
            }
        }
    }
}
