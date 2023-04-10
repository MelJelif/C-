Console.Clear();
int[,] array = new int[,] {
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9},
    {10, 11, 12}
};
int[] rowSums = new int[array.GetLength(0)];
for (int i = 0; i < array.GetLength(0); i++) {
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++) {
        sum += array[i,j];
    }
rowSums[i] = sum;
}
Console.WriteLine($"[{string.Join(",", rowSums)}]");
Console.WriteLine(rowSums.Length);
int minSumRowIndex = 0;
for (int i = 1; i < rowSums.Length; i++) {
    if (rowSums[i] < rowSums[minSumRowIndex]) {
        minSumRowIndex = i;
    }
}
Console.WriteLine($"Строка с наименьшей суммой элементов: " + (minSumRowIndex + 1));
