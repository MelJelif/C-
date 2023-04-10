static int RecursiveSum(int m, int n)
{
    if (m == n)
    {
        return m;
    }
    else if (m < n)
    {
        return m + RecursiveSum(m + 1, n);
    }
    else
    {
        return n + RecursiveSum(n + 1, m);
    }   
}

Console.WriteLine("Введите значение M: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение N: ");
int n = int.Parse(Console.ReadLine()!);

int sum = RecursiveSum(m, n);

Console.WriteLine("Сумма натуральных чисел от M до N равна: " + sum);
