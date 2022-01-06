using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5___CustoDaViagem
{
    public class Informacoes
    {
        public double Tempo { get; set; }
        public double VelocidadeMedia { get; set; }
        public double PrecoCombustivel { get; set; }
        public double ConsumoPorLitro { get; set; }


        public Informacoes(double tempo = 0 , double velocidadeMedia = 0 , double precoCombustivel = 0 , double consumolitro = 0)
        {
            this.Tempo = tempo;
            this.VelocidadeMedia = velocidadeMedia;
            this.PrecoCombustivel = velocidadeMedia;
            this.ConsumoPorLitro = consumolitro;
        }

        //METODO PARA CALCULAR CONSUMO COM COMBUSTÍVEL
        public double CalcularConsumo()
        {
            double distancia;
            double litrosUsado;
            double custototal;
            distancia = Tempo * VelocidadeMedia;
            litrosUsado = distancia / ConsumoPorLitro;
            custototal = litrosUsado * PrecoCombustivel;
            return custototal;
        }

        
        
    }
}
