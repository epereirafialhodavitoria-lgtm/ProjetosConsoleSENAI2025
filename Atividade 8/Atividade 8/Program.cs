Console.WriteLine("Olá! Escreva um número");
int número = int.Parse(Console.ReadLine());
if (número == 0)
{
    Console.WriteLine("O número 0 não é permitido digite outro numero");
}
else if (número > 0)
{
    Console.WriteLine("O número é POSITIVO"); 
}
else
{
    Console.WriteLine("O número é NEGATIVO");
}
