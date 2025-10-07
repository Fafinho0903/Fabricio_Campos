using Microsoft.VisualBasic;
using System;
using System.ComponentModel.Design;

public class Program
{
    public static void Main(string[] args)
    {
        double media;
        int n1, n2;

        Console.WriteLine("Digite o primeiro valor:");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor:");
        n2 = int.Parse(Console.ReadLine());

        media = (n1 + n2) / 2.0;
        Console.WriteLine($"A média é {media}");

        int total = n1 + n2;


        if (total % 2 == 0)
        {
            Console.WriteLine("O total é par");
        }
        if (total == 0)
        {
        Console.WriteLine("O total não pode ser igual a zero!");
        }
        
        {


        }
        }
        }