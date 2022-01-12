using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50___JogoTentativaErro
{
    public class Numeros
    {
        public int Jogada { get; set; }//MÉTODO DE ACESSO

        public Numeros(int Jogada = 0)//CONSTRUTOR
        {
            this.Jogada = Jogada;
        }

        //MÉTODO PARA SORTEAR NÚMERO
        static public int Sortear()
        {
           
            Random NumAleatorio = new Random();
            return NumAleatorio.Next(0, 100);
        }

        int numSorteado = Sortear();
        /* USAR A VARIÁVEL numSorteado FOI A ÚNICA FORMA QUE ENCONTREI PARA O PROGRAMA RODAR CORRETAMENTE.
         * QUANDO EU CHAMAVA DIRETAMENTE O MÉTODO SORTEAR DENTRO DO MÉTODO JOGAR, ACONTECIA UM SORTEIO NOVO
         * APÓS CADA TENTATIVA DO USUÁRIO, QUANDO NA VERDADE DEVERIA ACONTECER UM ÚNICO SORTEIO E ENTÃO 
         * AS TENTATIVAS DO USUÁRIO.
         */

        //MÉTODO PARA JOGAR
        public void Jogar()
        {
            bool Acertou;
            int tentativa = 0;//VARIÁVEL CONTADORA
            string retorno;//RETORNO DO USUÁRIO SE QUER OU NÃO CONTINUAR TENTANDO
            
            do
            {
                tentativa += 1;
                
                Console.Write($"Tentativa Número {tentativa}: ");
                Jogada = int.Parse(Console.ReadLine());
                if(Jogada == numSorteado)
                {
                    Console.WriteLine(numSorteado);
                    Console.WriteLine($"Parabéns ! Você Ganhou com {tentativa} Tentativas !");
                    Acertou = true;
                }
                else if(Jogada > numSorteado)
                {
                    Console.WriteLine($"Você Errou ! O Número Está Entre {numSorteado} e {Jogada}");
                    Acertou = false;
                }
                else//Jogada < SORTEAR()
                {
                    Console.WriteLine($"Você Errou ! O Número Está Entre {Jogada} e {numSorteado}");
                    Acertou = false;
                }

                Console.WriteLine("\n");
                if(Acertou == false)
                {
                    Console.Write("Deseja Continuar [S] ou [N]: ");
                }
                retorno = Console.ReadLine().ToUpper();

            } while (Acertou == false && retorno == "S");
        }



        

        
    }
}
