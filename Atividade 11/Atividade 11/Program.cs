using System.ComponentModel.Design;

Console.WriteLine("Digite o ano atual:");
int AnoAtual = int.Parse(Console.ReadLine());
Console.WriteLine("Agora digite o ano em que nasceu:");
int AnoNasceu = int.Parse(Console.ReadLine());  
int idade = AnoAtual - AnoNasceu;
if (idade < 16)
{
    Console.WriteLine("NÃO PODE VOTAR");
}
else if ((idade >= 18) && (idade <= 69)) 
{
    Console.WriteLine("VOTO OBRIGATORIO");
}
else
{
    Console.WriteLine("SEU VOTO É OPCIONAL");
}
