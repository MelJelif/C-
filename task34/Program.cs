Console.Clear();
int[] a = new int[8]; 
    for (int i = 0; i < a.Length; i++) { 
        a[i] = new Random().Next(100, 1000);
    }
Console.WriteLine($"[{string.Join(",", a)}]");
    int count = 0; 
    foreach (int num in a) { 
        if (num % 2 == 0) { 
                count++;
        }
    }
Console.WriteLine($"Количество чётных чисел в массиве: {count}");