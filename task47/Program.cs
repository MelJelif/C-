Console.Clear();
Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine()!);
double[,] a = new double[m, n];
for (int i = 0; i < m; i++){
    for (int j = 0; j < n; j++){
        a[i, j] = new Random().Next(0,10000) / 1000.000;
    }
}
Console.WriteLine("Массив случайных чисел:");
for (int i = 0; i < m; i++){
    Console.Write("[");
    for (int j = 0; j < n; j++){
        Console.Write(a[i, j] + " ");
    }
                Console.WriteLine("]");
}