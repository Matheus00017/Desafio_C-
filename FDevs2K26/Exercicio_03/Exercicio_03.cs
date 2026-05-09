using System;
/*
Desenvolva uma calculadora simples em C# que permite que ao usuario realizar operações de soma, subtração, multiplicação e divisão. O programa deve solicitar dois números e a operação desejada. Exiba o resultado no console.
*/

class Exercicio_03
{
    static void Main()
    {
        string operacao = "";
        
        Console.WriteLine("Digite o seu 1º Número:");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o seu 2º Número:");
        double numero2 = Convert.ToDouble(Console.ReadLine());
    
        Console.WriteLine("Digite a operação desejada (soma, subtração, multiplicação, divisão):");
        operacao = Console.ReadLine();

        switch(operacao)
        {
            case "soma":
            case "+":
                Console.WriteLine("O resultado da soma de : " + numero1 + " + " + numero2 + " = " + (numero1 + numero2));
                break;
            case "subtração":
            case "-":
                Console.WriteLine("O resultado da subtração de : " + numero1 + " - " + numero2 + " = " + (numero1 - numero2));
                break;
            case "multiplicação":
            case "*":
                Console.WriteLine("O resultado da multiplicação de : " + numero1 + " * " + numero2 + " = " + (numero1 * numero2));
                break;
            case "divisão":
            case "/":
                Console.WriteLine("O resultado da divisão de : " + numero1 + " / " + numero2 + " = " + (numero1 / numero2));
                break;
        }
    }
}

/*
 ________________________________________________________________________________________________________________
 _____________________________________________if else if_________________________________________________________

 class Exercicio_03
 {
    static void Main()
    {
        string operacao = "";
        
        Console.WriteLine("Digite o seu 1º Número:");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o seu 2º Número:");
        double numero2 = Convert.ToDouble(Console.ReadLine());
    
        Console.WriteLine("Digite a operação desejada (soma, subtração, multiplicação, divisão):");
        operacao = Console.ReadLine();

        if(operacao == "soma" || operacao == "+")
        {
            Console.WriteLine("O resultado da soma de : " + numero1 + " + " + numero2 + " = " + (numero1 + numero2));
        }
        else if(operacao == "subtração" || operacao == "-")
        {
            Console.WriteLine("O resultado da subtração de : " + numero1 + " - " + numero2 + " = " + (numero1 - numero2));
        }
        else if(operacao == "multiplicação" || operacao == "*")
        {
            Console.WriteLine("O resultado da multiplicação de : " + numero1 + " * " + numero2 + " = " + (numero1 * numero2));
        }
        else if(operacao == "divisão" || operacao == "/")
        {
            Console.WriteLine("O resultado da divisão de : " + numero1 + " / " + numero2 + " = " + (numero1 / numero2));
        }
    }
 }
*/