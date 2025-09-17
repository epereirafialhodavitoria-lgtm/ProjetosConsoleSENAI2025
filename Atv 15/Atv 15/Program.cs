// See https://aka.ms/new-console-template for more information
Console.WriteLine("N    úmeros entre 1000 e 2000:");
for (int numero = 1000; numero <= 2000; numero++)
{
    if (numero % 11 == 5)
    {
        Console.WriteLine(numero);
    }
}
