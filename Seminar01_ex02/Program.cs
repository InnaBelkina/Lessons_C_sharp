// Напишите программу, которая на вход принимает число и выдаёт его квадрат.

// 4 -> 16
// -3 -> 9

Console.WriteLine("Введите число:");
// string stringNumber = Console.ReadLine();
// int number;
// while(!int.TryParse(stringNumber, out number))
// {
//     System.Console.WriteLine("Ошибка! Введите целое число");
//     number = Console.ReadLine().Trim();
// }
int number = Convert.ToInt32(Console.ReadLine());
int result = number * number;

Console.WriteLine("Квадрат числа " + number + " будет равен " + result);