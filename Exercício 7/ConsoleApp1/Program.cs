using System.ComponentModel.Design;

int n1;
Console.WriteLine("Digite o 1° valor:");
n1 = int.Parse(Console.ReadLine());
if (n1 >= 10)
{
    Console.WriteLine("É maior que 10!");
}
else
{
    Console.WriteLine("É menor que 10!");
};