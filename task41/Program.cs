Console.Clear();
Console.WriteLine("Введите числа через пробел: ");
double[] numb = Console.ReadLine().Split(' ')!.Select(double.Parse).ToArray();
// Console.WriteLine(string.Join(" , ", numb));
int count = 0;
foreach (double i in numb) {
    if (i > 0){
        count += 1;
    }
}
Console.WriteLine($"Чисел больше 0 : {count}");