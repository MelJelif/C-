Console.Clear();
Console.Write("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = a % 100;
Console.WriteLine(b/10);