using System.ComponentModel.Design;
using System.Diagnostics.Tracing;

Console.WriteLine("Digite a primeira nota do aluno:");
int nota1 = int.Parse(Console.ReadLine());
Console.WriteLine("Agora digite a segunda nota:");
int nota2 = int.Parse(Console.ReadLine());
double media = (nota1 + nota2) / 2;
Console.WriteLine($"A media de notas desse aluno é {media}");
if (media >= 6)
{
    Console.WriteLine("Aluno APROVADO");
}
else
{
    Console.WriteLine("Aluno REPROVADO");
}


