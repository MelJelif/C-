Console.Clear();
Console.WriteLine("Введите значения для y = k1 * x + b1: ");
Console.Write("k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значения для y = k2 * x + b2: ");
Console.Write("k2: ");
double k2 = double.Parse(Console.ReadLine());
Console.Write("b2: ");
double b2 = double.Parse(Console.ReadLine());
if (k1 == k2){
    Console.WriteLine("Прямые параллельны, пересечение не существует.");
    }
else{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Точка пересечения имеет координаты ({x}, {y}).");
}
