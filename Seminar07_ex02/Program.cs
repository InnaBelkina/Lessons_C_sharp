// Задача 48: Задайте двумерный массив размера m на n, каждый элемент 
// в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// int[,] CreateArray(int rows, int columns, int minValue, int maxValue)
//     {
//         int[,] array = new int[rows, columns];
//         Random random = new Random();
//         foreach (int item in array)
//         {
//             item = random.Next(minValue, maxValue + 1);
//         }
//         return array;
//     }


// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int[,] CreateArray(int row, int col)
{
    int[,] Array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            Array[i, j] = i + j;
        }
        }
        return Array;
}
int[,] array = CreateArray(3,4);

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}
PrintArray(array);