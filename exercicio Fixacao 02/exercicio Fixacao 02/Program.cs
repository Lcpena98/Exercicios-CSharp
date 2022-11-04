// See https://aka.ms/new-console-template for more information
using exercicio_Fixacao_02;

int aumento;;
Funcionario funcionario = new Funcionario();
Console.WriteLine("Digite o Nome do funcionario");
funcionario.Nome = Console.ReadLine();
Console.WriteLine("Digite o Salario Bruto do funcionario");
funcionario.SalarioBruto = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o Imposto");
funcionario.Imposto = Convert.ToDouble(Console.ReadLine());
funcionario.Salario = funcionario.SalarioLiquido(funcionario.SalarioBruto,funcionario.Imposto);
Console.WriteLine(funcionario);
Console.WriteLine("Digite a porcentagem do aumento do salario");
aumento = Convert.ToInt32(Console.ReadLine());
funcionario.Salario =  funcionario.AumentoSalario(funcionario.Salario, aumento);
Console.WriteLine(funcionario);