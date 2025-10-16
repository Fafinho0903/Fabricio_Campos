using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;

int esc, i, cont, rep;
i = 0;
rep = 1;
List<int> stack = new List<int>();

//Começo do sistema

while (rep>0)
{
    Console.WriteLine("Escolha uma operação: \n\n 1 - Push: inserir um elemento no topo da pilha.\r\n\r\n 2 - Pop: remover e retornar o elemento do topo.\r\n\r\n 3 - Peek (ou Top): observar qual elemento está no topo, sem removê-lo. \r\n\r\n 4 - Sair.");
    esc = int.Parse(Console.ReadLine());

    Console.Clear();

    //Escrever e Adicionar um Número

    switch (esc)
    {
        case 1:
            while (i == 0)
            {

                Console.WriteLine("Insira um número: ");
                stack.Add(int.Parse(Console.ReadLine()));
                Console.WriteLine("Deseja escrever mais um número? \n 1 - sim    2 - não");
                cont = int.Parse(Console.ReadLine());

                if (cont == 1)
                {

                    i = 0;
                }

                else if (cont == 2)
                {
                    i++;
                }
            Console.Clear() ;
            }


            break;
    }

    //Remover e Retornar ao Número Anterior
    switch (esc)
    {
        case 2:
            
            int indiceTopo = stack.Count - 1;
            int elementoRemovido = stack[indiceTopo];
            stack.RemoveAt(stack.Count - 1);


            Console.WriteLine("\nNúmero removido com sucesso!\n");
            break;
    }

    //Mostrar o Número do Topo
    switch (esc)
    {
        case 3:
            if (stack.Count > 0)
            {
                int elementoTopo = stack[stack.Count - 1];
                Console.WriteLine($"\nO número que está no topo é {elementoTopo} \n");
            }
            else
            {
                Console.WriteLine("\nA Pilha deve conter pelo menos um número\n");
            }
            break;
    }

    //Sair
    switch (esc)
    {
        case 4:

            rep = 0;

            break;
    }
}