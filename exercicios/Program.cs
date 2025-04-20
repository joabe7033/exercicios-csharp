using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escolha o exercício:");
        Console.WriteLine("1 - Nome e Saudação");
        Console.WriteLine("2 - Calcular Idade");
        Console.WriteLine("3 - Média de Notas");
        Console.WriteLine("4 - Maior Número");
        Console.WriteLine("5 - Par ou Ímpar");
        Console.Write("Opção: ");
        
        int opcao = int.Parse(Console.ReadLine() ?? "0");

        switch (opcao)
        {
            case 1:
                Exercicio01.Run();
                break;
            case 2:
                Exercicio02.Run();
                break;
            case 3:
                Exercicio03.Run();
                break;
            case 4:
                Exercicio04.Run();
                break;
            case 5:
                Exercicio05.Run();
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }
}
