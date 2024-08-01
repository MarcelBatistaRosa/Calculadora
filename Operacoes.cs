using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCalculadoraV1
{
     public class Operacoes
    {
        public double X;
        public double Y;


        public double Adicao()
        {
            return X + Y;
        }

        public double Subtracao()
        {
            return X - Y;
        }

        public double Multiplicacao()
        {
            return X * Y;
        }

        public double Divisao()
        {
            return X / Y;
        }
    }
}
