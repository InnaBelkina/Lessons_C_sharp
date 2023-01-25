// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Сколько чисел Вы хотите ввести?");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];

for (int i = 0; i < size; i++)
{
    Console.Write("Введите целое число: ");
    array[i] = int.Parse(Console.ReadLine());
}

//  Console.WriteLine(string.Join("," , array));

int posNum = 0;
for (int i = 0; i < size; i++)
{
    if (array[i] > 0) posNum++;
}

Console.WriteLine($"Количество чисел больше 0 равно {posNum}");



// Console.WriteLine("Введите несколько чисел: ");
// int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// int count = 0;

// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] > 0)
//     {
//         count++;
//     }
// }

// Console.WriteLine($"Кол-во элементов > 0: {count}");
