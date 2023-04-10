Console.WriteLine("Введите значение M: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение N: ");
int n = int.Parse(Console.ReadLine()!);

int sum = 0;
for (int i = m; i <= n; i++)
{
    sum += i;
}

Console.WriteLine("Сумма натуральных чисел от M до N равна: " + sum);
