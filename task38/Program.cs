Console.Clear();
double[] a = new double[5]; 
for (int i = 0; i < a.Length; i++){
    a[i] = new Random().Next(0,1000) / 100.00;
}
Console.WriteLine($"[{string.Join(" , ", a)}]");
double max = a[0]; 
double min = a[0]; 
for (int i = 1; i < a.Length; i++){
    if (a[i] > max)
        max = a[i];
    if (a[i] < min)
        min = a[i];
}
double diff = max - min;
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {diff}");
