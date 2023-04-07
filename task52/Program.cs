Console.Clear();
int[,] array = new int[,] {
    {1, 2, 3, 4},
    {4, 5, 6, 7},
    {7, 8, 9, 10},
    {17, 18, 19, 11}
};

int rows = array.GetLength(0);
int cols = array.GetLength(1);

for (int col = 0; col < cols; col++) {
    int sum = 0;
    for (int row = 0; row < rows; row++) {
        sum += array[row, col];
    }
    double average = (double)sum / rows;
    Console.WriteLine("Среднее арифметическое столбца {0}: {1}", col, average);
}
