 int[,] arr = new int[3, 3];
        int counter = 1;
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
            {
                arr[i, j] = counter;
                counter++;
            }
        int maxRowIndex = FindRowWithMaxSum(arr);
        Console.WriteLine($"Максимальная сумма: {maxRowIndex + 1}");
        Console.ReadLine();
    static int FindRowWithMaxSum(int[,] array)
    {
        int maxRow = 0;
        int maxSum = int.MinValue;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            int rowSum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                rowSum += array[i, j];
            }
            if (rowSum > maxSum)
            {
                maxSum = rowSum;
                maxRow = i;
            }
        }
        return maxRow;
    }