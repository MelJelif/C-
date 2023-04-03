Console.Clear();
Console.Write("Введите координаты первой точки через пробел:");
string[] a = Console.ReadLine()!.Split(' ');

Console.WriteLine(string.Join(";", a));

Console.Write("Введите координаты второй точки через пробел:");
string[] b = Console.ReadLine()!.Split(' ');

Console.WriteLine(string.Join(";", b));

if (a.Length != b.Length)
{
    Console.WriteLine("Координаты точек должны содержать одинаковое количество значений");
    return;
}
double sum = 0;
for (int i = 0; i < a.Length; i++)
{
    sum += Math.Pow(Convert.ToDouble(b[i]) - Convert.ToDouble(a[i]), 2);
}
double distance = Math.Sqrt(sum);
Console.WriteLine($"Расстояние между точками: {distance}");
