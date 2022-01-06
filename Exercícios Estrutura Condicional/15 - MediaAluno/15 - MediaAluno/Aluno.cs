using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15___MediaAluno
{
    public class Aluno
    {
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }
        public double Nota4 { get; set; }
        public double Recuperacao { get; set; }


        public Aluno(double nota1 = 0,double nota2 = 0,double nota3 = 0,double nota4 = 0 , double recuperacao = 0)
        {
            this.Nota1 = nota1;
            this.Nota2 = nota2;
            this.Nota3 = nota3;
            this.Nota4 = nota4;
        }

        //CALCULANDO MEDIA SEM RECUPERAÇÃO
        public double CalcularMediaSimples()
        {
            double mediasimples = (Nota1 + Nota2 + Nota3 + Nota4) / 4;
            return mediasimples;
        }

        //MÉTODO PARA CALCULAR MÉDIA COM RECUPERAÇÃO
        public double CalcularMediaRecup()
        {
            double mediafinal = (CalcularMediaSimples() + Recuperacao) / 2;
            return mediafinal;
        }

        //MÉTODO PARA ANALISAR SITUAÇÃO DO ALUNO
        public void AnalisarSituacao()
        {
            if(CalcularMediaSimples() >= 7)
            {
                Console.WriteLine("\n");
                Console.WriteLine($"Aluno Aprovado Com Média Final {CalcularMediaSimples()} !");
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("\n");
                Console.WriteLine($"Aluno em Recuperação com Nota {CalcularMediaSimples()}");
                Console.Write("Digite a Nota de Recuperação: ");
                Recuperacao = double.Parse(Console.ReadLine());
                Console.WriteLine("\n");
                if (CalcularMediaRecup() >= 7)
                {
                    Console.WriteLine($"Parabéns ! Aluno Aprovado Com Média {CalcularMediaRecup()}");
                }
                else
                {
                    Console.WriteLine($"Aluno Reprovado Com Média {CalcularMediaRecup()}");
                }
            }
        }
    }
}
