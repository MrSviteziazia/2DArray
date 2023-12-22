
        int[,] arr = new int[3, 3];
        int counter = 1;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                arr[i, j] = counter;
                counter++;
            }
        }
        Console.Write("Введите номер строки: ");
        int row = int.Parse(Console.ReadLine());
        Console.Write("Введите номер столбца: ");
        int col = int.Parse(Console.ReadLine());
        int result = GetElementValue(arr, row, col);
        if (result != int.MinValue)
        {
            Console.WriteLine($"Значение элемента: {result}");
        }
        else
        {
            Console.WriteLine("Такого элемента нет в массиве.");
        }
        Console.ReadLine();
    
int GetElementValue(int[,] array, int row, int col)
    {
        if (row >= 0 && row < array.GetLength(0) && col >= 0 && col < array.GetLength(1))
        {
            return array[row, col];
        }
        else
        {
            return int.MinValue;
        }
    }
