// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite um número inteiro para calcular o fatorial   :");
int n = int.Parse(Console.ReadLine());
if (n < 0)
{
    Console.WriteLine("Não existe NEGATIVO.");
}
else
{
    long fatorial = 1;
    for(int contador = 1; contador <= n; contador++)
    {
        fatorial *= contador;
    }
    Console.WriteLine($"{n} = {fatorial}");
}
