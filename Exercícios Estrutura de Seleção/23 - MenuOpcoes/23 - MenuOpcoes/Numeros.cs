using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23___MenuOpcoes
{
    public class Numeros
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Opcao { get; set; }

        public Numeros(int num1 = 0 , int num2 = 0)
        {
            this.Num1 = num1;
            this.Num2 = num2;
        }


        //METODO PARA IMPRIMIR OPERAÇÕES
        public void Imprimir()
        {
            switch (Opcao)
            {
                case 1:
                    Console.WriteLine($"{Num1} + {Num2} = {Num1 + Num2}");
                    break;
                case 2:
                    Console.WriteLine($"{Num1} - {Num2} = {Num1 - Num2}");
                    break;
                case 3:
                    Console.WriteLine($"{Num1} x {Num2} = {Num1 * Num2}");
                    break;
                case 4:
                    Console.WriteLine($"{Num1} / {Num2} = {Num1 / Num2}");
                    break;
                default:
                    Console.WriteLine("Entrada Inválida !");
                    break;
            }
        }
    }
}
