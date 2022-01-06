using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3___PagamentoComissao
{
    class Program
    {
        static void Main(string[] args)
        {
            Peça interacaopeca = new Peça();
            Vendedor interacaovendedor = new Vendedor();

            interacaopeca.IdVendedor = interacaovendedor;
            
            Console.Write("Digite a Identificação do Vendedor: ");
            interacaovendedor.idVendedor = int.Parse(Console.ReadLine());
           
            Console.Write("Digite o Código da Peça: ");
            interacaopeca.CodigoPeca = int.Parse(Console.ReadLine());
            Console.Write("Digite o Preço Unitário da Peça: ");
            interacaopeca.PrecoUnitario = double.Parse(Console.ReadLine());
            Console.Write("Digite a Quantidade Vendida: ");
            interacaopeca.QuantidadeVendida = int.Parse(Console.ReadLine());
            interacaopeca.ImprimirComissao();
            
            Console.ReadLine();

        }
    }
}
