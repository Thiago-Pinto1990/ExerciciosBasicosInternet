using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18___VerificandoCodigo
{
    public class Numeros
    {
        public int Codigo { get; set; }

        
        public Numeros(int codigo = 0)
        {
            this.Codigo = codigo;
        }

        //MÉTODO PARA VALIDAR CÓDIGO
        public bool ValidarCodigo()
        {
            if(Codigo == 1 || Codigo == 2 || Codigo == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //MÉTODO PARA RETORNAR NÚMERO POR  EXTENSO
        public void ImprimirNumero()
        {
            if(ValidarCodigo() == true)
            {
                switch (Codigo)
                {
                    case 1:
                        Console.WriteLine("UM");
                        break;
                    case 2:
                        Console.WriteLine("DOIS");
                        break;
                    case 3:
                        Console.WriteLine("TRÊS");
                        break;

                 }
            }
            else
            {
                Console.WriteLine("Código Inválido !");
            }
        }
    }
}
