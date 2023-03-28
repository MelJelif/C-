Console.Clear();
Console.Write("Введите порядковый номер дня недели: ");
int a = Convert.ToInt32(Console.ReadLine());
while (a < 1 || a > 7)
{
    Console.WriteLine("Вы допустили ощибку. Нумерация дней идет от 1 до 7.");
    Console.Write("Введите порядковый номер дня недели: ");
    a = Convert.ToInt32(Console.ReadLine());
}
if (a > 5)
   Console.WriteLine($"\n Это Выходной");
else
   Console.WriteLine($"\n Это Будний день");

