Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 99){
   while (a > 999){
    a /= 10;
   //  Console.WriteLine(a); для проверки
   }
Console.WriteLine($"{a%10}");
}
else 
   Console.WriteLine("третьего числа нет");
