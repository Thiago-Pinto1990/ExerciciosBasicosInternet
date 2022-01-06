using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9___ConversorIdade
{
    public class Pessoa
    {
        public int Anos { get; set; }
        public int Meses { get; set; }
        public int Dias { get; set; }

        public Pessoa(int anos = 0 , int meses = 0 , int dias = 0)
        {
            this.Anos = anos;
            this.Meses = meses;
            this.Dias = dias;
        }

        public int ImprimirIdade()
        {
            int MesesConvertidos = Anos * 12;
            int MesesTotal = MesesConvertidos + Meses;
            int DiasTotal = MesesTotal * 30;
            return DiasTotal + Dias;

        }
    }
}
