Console.Clear();
Console.Write("Введите восемь значений через точкус запятой:");
string[] a = Console.ReadLine()!.Split(';');
while (a.Length != 8){
    Console.WriteLine("Вы допустили ошибку:");
    Console.WriteLine("Введите восемь значений через точкус запятой:");
    a = Console.ReadLine()!.Split(';');
}
Console.WriteLine($"[{string.Join(",", a)}]");