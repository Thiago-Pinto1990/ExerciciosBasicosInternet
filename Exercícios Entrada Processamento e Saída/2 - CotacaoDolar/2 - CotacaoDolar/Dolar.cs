using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___CotacaoDolar
{
    public class Dolar
    {
        private double quantia;

        public double Quantia
        {
            get { return quantia; }
            set 
            {
                if(value < 0) 
                {
                    Console.WriteLine("Entrada Quantia Inválida !");
                    
                }
                else
                {
                    quantia = value;
                }
                 
            }
        }

        private double valor;

        public double Valor
        {
            get { return valor; }
            set 
            { 
                if(value < 0)
                {
                    Console.WriteLine("Entrada Valor Inválida !");
                    
                }
                else
                {
                    valor = value;
                }
                 
            }
        }

        //CRIANDO CONSTRUTOR
        public Dolar(double quantia , double valor)
        {
            this.Quantia = quantia;
            this.Valor = valor;
        }

        public Dolar()
        {
            this.Quantia = quantia;
            this.Valor = valor;
        }

        //MÉTODO PARA CONVERTER
        public void ImprimirConversao()
        {
            Console.WriteLine($"Você possui {Valor*Quantia} reais !");
        }


    }
}
