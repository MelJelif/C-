Console.Clear();
int[,] array = new int[4, 4];
int num = 1;

int top = 0;
int bottom = array.GetLength(0) - 1;
int left = 0;
int right = array.GetLength(1) - 1;

while (true)
{
    for (int i = left; i <= right; i++)
    {
        array[top, i] = num;
        num++;

        if (num > 16) break;
    }
    top++;

    for (int i = top; i <= bottom; i++)
    {
        array[i, right] = num;
        num++;

        if (num > 16) break;
    }
    right--;

    for (int i = right; i >= left; i--)
    {
        array[bottom, i] = num;
        num++;

        if (num > 16) break;
    }
    bottom--;

    for (int i = bottom; i >= top; i--)
    {
        array[i, left] = num;
        num++;

        if (num > 16) break;
    }
    left++;

    if (num > 16) break;
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}
