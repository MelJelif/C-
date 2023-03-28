Console.Clear();
int a = 0;
while (a < 99 || a > 999)
{
 Console.Write("Введите трехзначное число: ");
a = Convert.ToInt32(Console.ReadLine());   
}

int b = a % 100;
Console.WriteLine(b/10);