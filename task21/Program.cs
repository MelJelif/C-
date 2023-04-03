Console.Write("Введите координаты первой точки через точкус запятой:");
string[] a = Console.ReadLine()!.Split(';');
// // foreach (string c in a)
// {
//     Console.WriteLine(c);
// }
Console.WriteLine(string.Join(",", a));
Console.Write("Введите координаты второй точки через запятую:");
string[] b = Console.ReadLine()!.Split(';');
Console.WriteLine(string.Join(",", b));
// foreach (string c in b)
// {
//     Console.WriteLine(c);
// }
double r1 = Math.Pow(Convert.ToDouble(b[0]) - Convert.ToDouble(a[0]), 2);
Console.WriteLine($"r1={r1}");
double r2 = Math.Pow(Convert.ToDouble(b[1]) - Convert.ToDouble(a[1]), 2);
Console.WriteLine($"r2={r2}");
double r3 = Math.Pow(Convert.ToDouble(b[2]) - Convert.ToDouble(a[2]), 2);
Console.WriteLine($"r3={r3}");
double rang = Math.Sqrt(r1 + r2 + r3);
Console.WriteLine($"rang={rang}");
