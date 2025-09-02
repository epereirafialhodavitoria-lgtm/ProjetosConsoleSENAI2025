// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite a sua idade em anos:");
int anos = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a sua idade em meses:");
int meses = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a sua idade em dias:");
int dias = int.Parse(Console.ReadLine());
int idadeEmDias = (anos * 365) + (meses * 30) + dias;
Console.WriteLine($" A idade total em dias é: {idadeEmDias}");
