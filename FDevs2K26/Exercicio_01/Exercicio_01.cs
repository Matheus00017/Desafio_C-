using System;

/*
1) Desenvolva um programa em C# que utilize uma estrutura de repetição para calcular a soma dos números de 1 a 10. Exiba o resultado no console
*/

class Exercicio_01
{
    static void Main()
    {
        int soma = 0;
        for(int i = 1; i <=10; i++)
        {
            soma += i;
        }
        Console.WriteLine("A soma dos números de 1 a 10 é " + soma);
    }
}

