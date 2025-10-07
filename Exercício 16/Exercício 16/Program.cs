using System.Data;

double n, a, j;

Console.WriteLine("Escreva o número desejado:");
n = double.Parse(Console.ReadLine());

a = 2;
j = n - 1;

while (a > 1)
{
    n = n * j;
    j = j - 1;

    if (j == 0)
    {
        a =0;
    }
    

}
Console.Clear();
Console.WriteLine($"O resultado é: {n}");
