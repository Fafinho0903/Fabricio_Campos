double n,i,count,valor;
Console.WriteLine("Digite um valor");
n = double.Parse(Console.ReadLine());
i = 1;
count = 0;
while (n >= i)
{
    Console.WriteLine($"Digite o {i}º numero:");
    valor = double.Parse(Console.ReadLine());
    i++;
        if (valor < 0)
    {

    count++;
    
    }

}
Console.WriteLine($"{count} valores são negativos"); 
