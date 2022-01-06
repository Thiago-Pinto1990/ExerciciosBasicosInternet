using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEstoqueMedio
{
    public class Estoque
    {
        private int qntMinima;

        public int QntMinima
        {
            get { return qntMinima; }
            set 
            { 
                if(value >= 0)
                {
                    qntMinima = value;

                }
                else
                {
                    Console.WriteLine("Valor Inválido !");
                }
                 
            }
        }

        private int qntMaxima;

        public int QntMaxima
        {
            get { return qntMaxima; }
            set
            {
                if (value >= 0)
                {
                    qntMaxima = value;
                }
                else
                {
                    Console.WriteLine("Valor Inválido !");
                }

            }

        }
        //CRIANDO CONSTRUTORES

        public Estoque(int qntminima , int qntmaxima)
        {
            this.QntMinima = qntminima;
            this.QntMaxima = qntmaxima;
        }

        //MÉTODO PARA CALCULAR ESTOQUE MÉDIO

        public double CalculoMedio()
        {
            return (QntMinima + QntMaxima) / 2.0;
        }
    }
}
