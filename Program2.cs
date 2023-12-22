 int[,] arr = new int[5, 5];
        int counter = 1;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                arr[i, j] = counter;
                counter++;
            }
        }
        Console.WriteLine("Первый массив:");
        PrintArray(arr);
        SwapRows(arr, 0, arr.GetLength(0) - 1);
        Console.WriteLine("Массив после замены:");
        PrintArray(arr);
        Console.ReadLine();
 void SwapRows(int[,] array, int row1, int row2)
    {
        int cols = array.GetLength(1);

        for (int i = 0; i < cols; i++)
        {
            int temp = array[row1, i];
            array[row1, i] = array[row2, i];
            array[row2, i] = temp;
        }
    }
 void PrintArray(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }