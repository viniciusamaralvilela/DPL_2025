using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Escolha uma cor para o fundo do console:");
        Console.WriteLine("1 - Azul");
        Console.WriteLine("2 - Verde");
        Console.WriteLine("3 - Vermelho");
        Console.Write("Digite o número da cor: ");

        int escolha = int.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 1:
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Clear(); 
                Console.WriteLine("Cor alterada para Azul.");
                break;

            case 2:
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("Cor alterada para Verde.");
                break;

            case 3:
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine("Cor alterada para Vermelho.");
                break;

            default:
                Console.WriteLine("Opção inválida.");
                break;
        }

        Console.ResetColor(); 
    }
}
