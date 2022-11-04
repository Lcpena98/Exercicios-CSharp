using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_Fixacao_03
{
    public class Aluno
    {
        public string Nome { get; set; }
        public double Nota01 { get; set; }
        public double Nota02 { get; set; }
        public double Nota03 { get; set; }

        public double CalcularNotaFinal(double Nota01, double Nota02, double Nota03)
        {
            double notaFinal = Nota01 + Nota02 + Nota03;
            return notaFinal;
        }
        public string Resultado(double nota)
        {
            double notafaltando = 60 - nota;
            if (nota >= 60)
                return "APROVADO";
            else
                return "REPROVADO, Faltam " + notafaltando + " PONTOS";

        }
    }
}
