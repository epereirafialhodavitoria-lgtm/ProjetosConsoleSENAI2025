Console.WriteLine("Digite um valor:");
int valor1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite outro valor:");
int valor2 = int.Parse(Console.ReadLine());
if (valor1 == valor2)
{
    Console.WriteLine($"Os valores não podem ser iguais.");
}
else if (valor1 < valor2)
{
    Console.WriteLine($"O maior valor é: {valor2}");
}
else
{
    Console.WriteLine($"O maior valor é: {valor1}");
}

