Console.Clear();
Console.Write("Введите пятизначное число:");
string a = Console.ReadLine()!;
// Console.WriteLine(a);
while (a.Length != 5)
{   Console.WriteLine("Выдопустили ошибку");
    Console.WriteLine("Введите пятизначное число:");
    a = Console.ReadLine()!;
}
//Console.WriteLine(a);
if (a[0]==a[4] && a[1]==a[3]){
//    Console.WriteLine("Hell yeah!!! это число палиндром!");
   Console.WriteLine("Да");
   }
else
    Console.WriteLine("нет");