Console.Clear();
Console.Write("Введите значение N: ");
int n = int.Parse(Console.ReadLine()!);
PrintNumbersFromNTo1(n);
    static void PrintNumbersFromNTo1(int n)
    {
        Console.Write(n);

        if (n > 1)
        {
            Console.Write(", ");
            PrintNumbersFromNTo1(n - 1);
        }
    }
