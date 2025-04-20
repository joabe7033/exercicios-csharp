using System;

class Exercicio02
{
    public static void Run()
    {
        Console.Write("Digite seu ano de nascimento: ");
        int anoNascimento = int.Parse(Console.ReadLine());

        int anoAtual = 2024;
        int idade = anoAtual - anoNascimento;

        Console.WriteLine($"Você tem {idade} anos.");
    }
}
