using System.Drawing;

int mac;
Console.WriteLine("Nova promoção no Hortifruti! Leve 12 ou mais e pague R$1,00 por MAÇÃ!");
Console.WriteLine("\nQuantas maçãs você quer");
mac = int.Parse(Console.ReadLine());
if (mac < 12)
{
    Console.WriteLine($"Cada maçã saiu no valor de R$ 1,30, seu total é: R${mac * 1.30}");
}
else if (mac >= 12)
{
    Console.WriteLine($"Cada maçã saiu no valor de R$ 1,00, seu total é: R${ mac * 1.00}");
}
