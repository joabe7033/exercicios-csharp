using System;

class Exercicio01
{
    public static void Run()
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine() ?? "";
        Console.WriteLine($"Olá, {nome}!");
    }
}
