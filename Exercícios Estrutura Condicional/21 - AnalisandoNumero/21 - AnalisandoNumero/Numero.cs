using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21___AnalisandoNumero
{
    public class Numero
    {
        public int Num { get; set; }

        public Numero(int numero = 0)
        {
            this.Num = numero;
        }


        public void AnalisarNumero()
        {
            bool validacao = true;
            int resposta;
            do
            {
                Console.Write("Digite um Número: ");
                Num = int.Parse(Console.ReadLine());
                if (Num >= 0)
                {
                    Console.WriteLine("O Número é Positivo");
                }
                else
                {
                    Console.WriteLine("O Número é Negativo");
                }

                Console.Write("Digite 1 Para Continuar ou 0 Para Sair: ");
                resposta = int.Parse(Console.ReadLine());
                if (resposta == 1)
                {
                    validacao = true;
                }
                else
                {
                    validacao = false;
                }
            } while (validacao == true);
        }
    }
}
