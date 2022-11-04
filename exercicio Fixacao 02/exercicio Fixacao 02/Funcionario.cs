using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_Fixacao_02
{
    class Funcionario
    {
        public string Nome { get; set; }
        public double SalarioBruto { get; set; }
        public double Imposto { get; set; }
        public double Salario { get; set; }

        public double SalarioLiquido(double salario, double imposto)
        {
            double salarioLiquido = salario - imposto;
            return salarioLiquido;
        }
        public double AumentoSalario( double salarioLiquido, int porcentagem) 
        {

            double acrescimo = (salarioLiquido * porcentagem)/100;
            double novoSalario = salarioLiquido + acrescimo;
            return novoSalario;
        }
        public override string ToString()
        {
            return "FUNCIONARIO: "+Nome +" $"+Salario;
        }
    }
}
