int num;
Console.WriteLine("Digite o 1° Valor:");
num = int.Parse(Console.ReadLine());
if (num > 0)
{
    Console.WriteLine("O numero é Positivo!");
}
else if (num < 0)
{
    Console.WriteLine("O numero é Negativo!");
}
if (num == 0)
{
    Console.WriteLine("O numero é inválido");
}