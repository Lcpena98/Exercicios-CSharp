// See https://aka.ms/new-console-template for more information
using exercicio_Fixacao_03;
string resultado;
double notaFinal;
Aluno aluno = new Aluno();
Console.WriteLine("Digite o nome do Aluno");
aluno.Nome = Console.ReadLine();
Console.WriteLine("Digite a primeira nota");
aluno.Nota01 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite a segunda nota");
aluno.Nota02 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite a terceira nota");
aluno.Nota03 = Convert.ToDouble(Console.ReadLine());

notaFinal = aluno.CalcularNotaFinal(aluno.Nota01, aluno.Nota02, aluno.Nota03);
resultado = aluno.Resultado(notaFinal);
Console.WriteLine(resultado);