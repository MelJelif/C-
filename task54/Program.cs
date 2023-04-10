Console.Clear();
int[,] arr = {
    {8, 13, 7, 1},
    {4, 9, 5, 3},
    {11, 6, 2, 10}
};

for (int i = 0; i < arr.GetLength(0); i++) {
    List<int> row = new List<int>();
    for (int j = 0; j < arr.GetLength(1); j++) {
        row.Add(arr[i, j]);
    }
    row.Sort();
    row.Reverse();
    for (int j = 0; j < arr.GetLength(1); j++) {
        arr[i, j] = row[j];
    }
}

for (int i = 0; i < arr.GetLength(0); i++) {
    for (int j = 0; j < arr.GetLength(1); j++) {
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}