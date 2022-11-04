using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_Fixacao_01
{
     class Triangulo
    {
        public double largura { get; set; }
        public double altura { get; set; }
        public double AreaTriangulo(double largura, double altura)
        {
            double area = largura * altura;
            return area;
        }
        public double PerimetroTriangulo(double largura, double altura)
        {
            double perimetro = 2*(largura+altura);
            return perimetro;
        }
        public double DiagonalTriangulo(double largura, double altura)
        {
            double diagonal = (altura*altura)+(largura*largura);
            return diagonal;
        }

    } 

}
