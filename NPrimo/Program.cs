static void Main()
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        if (EhPrimo(numero))
        {
            Console.WriteLine($"{numero} é primo.");
        }
        else
        {
            Console.WriteLine($"{numero} não é primo.");
        }
    }

    static bool EhPrimo(int n)
    {
        if (n <= 1) return false;
        if (n == 2) return true;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }
