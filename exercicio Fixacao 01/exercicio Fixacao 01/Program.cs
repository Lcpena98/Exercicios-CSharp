using exercicio_Fixacao_01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

Triangulo triangulo = new Triangulo();
Console.WriteLine("Entre a largura do retângulo:");
triangulo.largura = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Entre a altura do retângulo:");
triangulo.altura = Convert.ToDouble(Console.ReadLine());

double area = triangulo.AreaTriangulo(triangulo.largura, triangulo.altura);
Console.WriteLine("AREA: " + area);
double perimetro =  triangulo.PerimetroTriangulo(triangulo.largura, triangulo.altura);
Console.WriteLine("PERIMETRO: " + perimetro);
double diagonal = triangulo.DiagonalTriangulo(triangulo.largura, triangulo.altura);
Console.WriteLine("DIAGONAL: " + diagonal);