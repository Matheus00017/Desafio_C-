using System; 

/*
2) Crie um programa em C# que calcule o indice de massa corporal (IMC). Solicite ao usuario que insira seu peso (em quilogras) e sua altura (em metros). o IMC é calculado pela formula:IMC = peso / (altura * altura). Exiba o resultado no console.indicando a faixa de classificação. 
*/

class Exercicio_02
{
    static void Main()
    {
        Console.WriteLine("Digite seu peso em KG: ");
        double peso = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a Sua altura em metros: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        double imc = peso / (altura  * altura);
        Console.WriteLine("Seu IMC é de: " + imc);
    }
}