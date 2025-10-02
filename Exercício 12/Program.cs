int n1, n2, rep;
rep = 0;

while (rep < 1)
{
    Console.WriteLine("Escreva o primeiro número: ");
    n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Escreva o segundo número: ");
    n2 = int.Parse(Console.ReadLine());

    if (n1 > n2)
    {
        Console.WriteLine("O primeiro número é maior");
        rep = 1;
    }
    if (n2 > n1)
    {
        Console.WriteLine("O segundo é maior");
        rep = 1;
    }
    if (n1 == n2)
    {
        Console.WriteLine("Não é permitido números iguais, digite novamente:\n");
    }
}