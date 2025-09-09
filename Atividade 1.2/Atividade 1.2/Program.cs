using System.ComponentModel.Design;

Console.WriteLine("olá! Digite um número para sabermos se é maior ou menor que o número 10");
int valor = int.Parse(Console.ReadLine());
if (valor > 10)
{
    Console.WriteLine("O número é maior que 10");
}
else if (valor < 10)
{
    Console.WriteLine("O número é menor que o 10");
}
else
{
    Console.WriteLine("O número é igual a 10");
}



