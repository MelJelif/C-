using System;

class Program {
    static int Ackerman(int m, int n) {
        if (m == 0) {
            return n + 1;
        } else if (n == 0) {
            return Ackerman(m - 1, 1);
        } else {
            return Ackerman(m - 1, Ackerman(m, n - 1));
        }
    }

    static void Main() {
        Console.Clear();
        Console.WriteLine("Введите значение m: ");
        int m = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Введите значение n: ");
        int n = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"A({m},{n})= " + Ackerman(m, n));
    }
}
