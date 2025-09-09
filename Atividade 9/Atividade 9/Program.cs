Console.WriteLine("Hello, World!");
Console.WriteLine("Digite a quantidade de maças compradas:");
int quantidade = int.Parse(Console.ReadLine());
double preco;
if (quantidade < 12)
{
    preco = 1.30;
}
else
{
    preco = 1.00;
}
double total = quantidade * preco;
Console.WriteLine($"O valor total da compra é: R$ {total}");