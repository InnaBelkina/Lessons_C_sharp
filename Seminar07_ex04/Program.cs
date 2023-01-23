// Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

// int SumMainDiagonal(int[,] arr)
// {
//     int sum = 0;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             if (i == j) {sum += arr[i,j];}
//         }
//     }
//     return sum;
// }
// Console.WriteLine($"Сумма главной диагонали {SumMainDiagonal(array)}");

static int[,] CreateRandomArray(int rows, int columns, int minValue, int maxValue)
    {
        int[,] array = new int[rows, columns];
        Random random = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
            for (int j = 0; j < array.GetLength(1); j++)
                array[i, j] = random.Next(minValue, maxValue + 1);
        return array;
    }

    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                Console.Write($"{array[i, j]} ");
            Console.WriteLine();
        }
    }

int SumMainDiagonal(int[,] arr)
    {
        int sum = 0;
        int size = Math.Min(arr.GetLength(0), arr.GetLength(1));
        for (int i = 0; i < size; i++)
            sum += arr[i, i];
        return sum;
    }
    Console.Clear();
        int[,] array = CreateRandomArray(5, 5, 0, 10);
        PrintArray(array);
        System.Console.WriteLine();
    Console.WriteLine($"Сумма главной диагонали {SumMainDiagonal(array)}");



    // new Random().NextDouble()
    // new Random().NextDouble() * (maxValue - minValue) + minValue;

    // Math.Round(x, 2) - чтобы округлить
