using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3___PagamentoComissao
{
    public class Peça
    {

        public Vendedor IdVendedor { get; set; }


        public int CodigoPeca { get; set; }//FUTURAMENTE MELHORAR A UTILIZAÇÃO DESTE ATRIBUTO

        public double PrecoUnitario { get; set; }

        public int QuantidadeVendida { get; set; }

        public Peça(int codigoPeca = 0, double precoUnitario = 0, int quantidadeVendida = 0)
        {
            
            this.CodigoPeca = codigoPeca;
            this.PrecoUnitario = precoUnitario;
            this.QuantidadeVendida = quantidadeVendida;
        }

        public void ImprimirComissao()
        {
            Console.WriteLine($"O funcionário {IdVendedor.idVendedor} vendeu {QuantidadeVendida} peças e vai receber comissão de {0.05*PrecoUnitario*QuantidadeVendida} reais !");
        }






    }
}
