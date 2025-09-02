// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite o número total de eleitores:");
int totalEleitores = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o número de votos brancos:");
int votosBrancos = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o número de votos nulos:");
int votosNulos = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o número de votos válidos:");
int votosVálidos = int.Parse(Console.ReadLine());
double percBrancos = (votosBrancos * 100.0) / totalEleitores;
double percNulos = (votosNulos * 100.0) / totalEleitores;
double percVálidos = (votosVálidos * 100.0) / totalEleitores;
Console.WriteLine("Resultados");
Console.WriteLine($"Percentual de votos brancos: {percBrancos}%");
Console.WriteLine($"Percentual de votos nulos: {percNulos}%");
Console.WriteLine($"Percentual de votos Válidos: {percVálidos}%");

