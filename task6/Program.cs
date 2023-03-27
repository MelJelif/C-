Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = a % 2;
if (b == 0)
   Console.Write("Да");
else
   Console.Write("Нет");