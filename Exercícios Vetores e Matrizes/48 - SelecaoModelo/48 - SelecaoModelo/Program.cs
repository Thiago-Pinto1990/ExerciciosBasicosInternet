using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48___SelecaoModelo
{
    class Program
    {
        static void Main(string[] args)
        {
            Modelos interacao = new Modelos();
            interacao.ReceberCadastro();
            interacao.AnalisarCandidatas();
            Console.ReadLine();
        }
    }
}
