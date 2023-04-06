Console.Clear();
int[] a = new int[5]; 
int sum = 0;
for (int i = 0; i < a.Length; i++)
{
    a[i] = new Random().Next(1, 100);
}
Console.WriteLine($"[{string.Join(",", a)}]");
for (int i = 1; i < a.Length; i+=2)
{
    sum = sum + a[i];
}
Console.WriteLine("Сумма элементов, стоящих на нечетных позициях: " + sum);
