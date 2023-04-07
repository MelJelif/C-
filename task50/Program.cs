Console.Clear();
double[,] array = new double[,]
{
    {1.2, 2.3, 3.4},
    {4.5, 5.6, 6.7},
    {7.8, 8.9, 9.9}
};

Console.Write("Номер строки: ");
int row = Convert.ToInt32(Console.ReadLine()) - 1; // -1 because arrays start at 0 index
Console.Write("Номер столбца: ");
int col = Convert.ToInt32(Console.ReadLine()) - 1; // same as above

if(row >= 0 && row < array.GetLength(0) && col >= 0 && col < array.GetLength(1))
{
    double value = array[row, col];
    Console.WriteLine($"значение ({row+1},{col+1}) is {value}");
}
else
{
    Console.WriteLine("такой позиции нет");
}
