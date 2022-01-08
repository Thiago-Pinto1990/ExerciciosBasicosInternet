using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37___Menu
{
    public class Operacao
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public int Opcao { get; set; }

        //CONSTRUTOR
        public Operacao(double num1 = 0 , double num2 = 0 , int opcao = 0)
        {
            this.Num1 = num1;
            this.Num2 = num2;
            this.Opcao = opcao;
        }

        //MÉTODO PARA APRESENTAR MENU
        public int ApresentarMenu()
        {
            Console.WriteLine("1 - Adição\n2 - Subtração\n3 - Multiplicação\n4 - Divisão\n");
            Console.Write("Digite o Número da Opção Escolhida: ");
            Opcao = int.Parse(Console.ReadLine());
            return Opcao;
        }

        //MÉTODO PARA REALIZAR AS OPERAÇÕES

        public void RealizarOperacao()
        {
            string resposta;
            do
            {

                switch (ApresentarMenu())
                {
                    case 1://SOMA
                        Console.Write("Digite o Primeiro Número: ");
                        Num1 = int.Parse(Console.ReadLine());
                        Console.Write("Digite o Segundo Número: ");
                        Num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("\n");
                        Console.WriteLine($"{Num1} + {Num2} = {Num1 + Num2}");
                        break;

                    case 2://SUBTRAÇÃO
                        Console.Write("Digite o Primeiro Número: ");
                        Num1 = int.Parse(Console.ReadLine());
                        Console.Write("Digite o Segundo Número: ");
                        Num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("\n");
                        Console.WriteLine($"{Num1} - {Num2} = {Num1 - Num2}");
                        break;

                    case 3://MULTIPLICAÇÃO
                        Console.Write("Digite o Primeiro Número: ");
                        Num1 = int.Parse(Console.ReadLine());
                        Console.Write("Digite o Segundo Número: ");
                        Num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("\n");
                        Console.WriteLine($"{Num1} x {Num2} = {Num1 * Num2}");
                        break;

                    case 4://DIVISÃO
                        Console.Write("Digite o Primeiro Número: ");
                        Num1 = int.Parse(Console.ReadLine());
                        Console.Write("Digite o Segundo Número: ");
                        Num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("\n");
                        Console.WriteLine($"{Num1} / {Num2} = {Num1 / Num2}");
                        break;

                    default:
                        Console.WriteLine("Entrada Inválida !");
                        break;

                }

                Console.Write("Deseja Continuar [S] ou [N]: ");
                resposta = Console.ReadLine().ToUpper();
                Console.WriteLine("\n");

            } while (resposta == "S");
        }
    }
}
