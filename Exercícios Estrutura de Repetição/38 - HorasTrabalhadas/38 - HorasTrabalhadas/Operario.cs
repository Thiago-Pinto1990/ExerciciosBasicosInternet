using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38___HorasTrabalhadas
{
    public class Operario
    {
        public int C { get; set; }
        public double N { get; set; }
        public double SalarioParcial { get; set; }

        public Operario(int codigo = 0 , double horas = 0 , double salarioParcial = 0)
        {
            this.C = codigo;
            this.N = horas;
            this.SalarioParcial = salarioParcial;
        }


        public void ImprimirSalario()
        {
            string resposta;
            double E;
            double receber;

            do
            {

                Console.Write("Digite o Código do Operário: ");
                C = int.Parse(Console.ReadLine());
                Console.Write("Digite o Número de Horas Trabalhadas: ");
                N = double.Parse(Console.ReadLine());
                Console.Write("Digite o Salário Fixo do Operário: ");
                SalarioParcial = double.Parse(Console.ReadLine());
                
                if(N > 50)
                {
                    //HORA EXCEDENTE VALE 20,00
                    E = N - 50;
                    receber = N * 10 + E * 20;
                    Console.WriteLine($"O Salário Total de {C} é {SalarioParcial + receber} reais !");
                    Console.WriteLine($"O Salário Excedente de {C} é {E*20} reais !");

                }
                else
                {
                    //HORA EXCEDENTE VALE 10,00
                    receber = N * 10;
                    Console.WriteLine($"O Salário Total de {C} é {SalarioParcial + receber} reais !");
                    E = 0;
                }

                Console.WriteLine("\n");
                Console.Write("Deseja Continuar [S] ou [N]: ");
                resposta = Console.ReadLine().ToUpper();
                Console.WriteLine("\n");





            } while (resposta == "S");
        }
    }
}
