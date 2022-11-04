using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_de_Fixacao_04
{
    public class ConersorDeMoeda
    {
        public double CotacaoDolar { get; set; }
        public double qtdeDolares { get; set; }
        public double ValorReal(double cotacao, double qtde)
        {
            double real = cotacao * qtde;
            return real;
        }
    }
}
