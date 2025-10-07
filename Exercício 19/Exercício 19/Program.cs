Console.WriteLine("Quantos números você quer digitar?");
int n = int.Parse(Console.ReadLine());

if (n < 3)
{
    Console.WriteLine("Erro:é necessario informar pelo menos 3 números!");
    return;
}
double[] numeros = new double[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Digite o {i + 1}º número:");
    numeros[i] = double.Parse(Console.ReadLine());
}
double menor = numeros.Min();
double maior = numeros.Max();
double soma = numeros.Sum() - menor - maior;
double media = soma / (n - 2);

Console.WriteLine($"\n Menor número: {menor}");
Console.WriteLine($"Maior número:{maior}");
Console.WriteLine($"Média (excluindo o menor e o maior):{media:f2}");