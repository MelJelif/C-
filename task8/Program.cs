Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i < a + 1)
    if (i % 2 == 0){
    // Console.Write($" {i},"); к сожалению не понял как сделать , чтобы после последнего числа не ставилась запятая
    Console.Write($" {i}");
    i++;
    }
    else
    i++;